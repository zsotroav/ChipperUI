using System;
using System.IO;
using System.Text;

namespace ChipperUI
{
    internal static class AlgorithmStatic
    {
        public static void GenKey(string keyPhrase, string keyName)
        {
            var keyB64 = Convert.ToBase64String(EncodeBytes(keyPhrase));
            var keyP1 = EncodeBytes(keyB64[..(keyB64.Length / 2)]);
            var keyP2 = EncodeBytes(keyB64[(keyB64.Length / 2)..]);

            var key = new byte[keyP1.Length];

            for (int i = 0; i < keyP1.Length; i++)
            {
                key[i] = (byte)(keyP1[i] ^ keyP2[i]);
            }

            Directory.CreateDirectory(External.MainPath);
            var completePath = Path.Combine(External.MainPath, keyName);
            completePath += ".key.bin";

            External.SaveBin(completePath, key);
        }


        public static byte[] EncodeBytes(string input, string encMode = "UTF-8")
        {
            return encMode switch
            {
                "ASCII" => Encoding.ASCII.GetBytes(input),
                "Unicode" => Encoding.Unicode.GetBytes(input),
                "UTF8" => Encoding.UTF8.GetBytes(input),
                "UTF32" => Encoding.UTF32.GetBytes(input),
                _ => Encoding.UTF8.GetBytes(input),
            };
        }

        public static string EncodeString(byte[] input, string encMode = "UTF-8")
        {
            return encMode switch
            {
                "ASCII" => Encoding.ASCII.GetString(input),
                "Unicode" => Encoding.Unicode.GetString(input),
                "UTF8" => Encoding.UTF8.GetString(input),
                "UTF32" => Encoding.UTF32.GetString(input),
                _ => Encoding.UTF8.GetString(input),
            };
        }
    }
}
