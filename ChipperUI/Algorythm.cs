using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ChipperUI
{
    class Algorythm
    {
        public static List<byte> DataIn = new();
        public static List<byte> DataOut = new();
        public static string EncMode = "UTF8";

        public static byte[] EncryptData(byte[] InData, byte[] KeyData)
        {
            DataOut.Clear();
            int x = 0;
            for (int i = 0; i < InData.Length; i++)
            {
                if (KeyData.Length < i - x + 1)
                {
                    x += KeyData.Length;
                }

                DataOut.Add((byte) (KeyData[i - x] ^ InData[i]));
            }
            return DataOut.ToArray();
        }

        public static void GenKey(string KeyPhrase, string KeyName)
        {
            string KeyB64 = Convert.ToBase64String(EncodeBytes(KeyPhrase));
            var KeyP1 = EncodeBytes(KeyB64[..(KeyB64.Length / 2)]);
            var KeyP2 = EncodeBytes(KeyB64[(KeyB64.Length / 2)..]);

            byte[] Key = new byte[KeyP1.Length];

            for (int i = 0; i < KeyP1.Length; i++)
            {
                Key[i] = (byte)(KeyP1[i] ^ KeyP2[i]);
            }

            Directory.CreateDirectory(External.MainPath);
            string CompletePath = Path.Combine(External.MainPath, KeyName);
            CompletePath += ".key.bin";

            External.SaveBin(CompletePath, Key);
            
        }


        public static byte[] EncodeBytes(string Input)
        {
            return EncMode switch
            {
                "ASCII" => Encoding.ASCII.GetBytes(Input),
                "Unicode" => Encoding.Unicode.GetBytes(Input),
                "UTF8" => Encoding.UTF8.GetBytes(Input),
                "UTF32" => Encoding.UTF32.GetBytes(Input),
                _ => Encoding.UTF8.GetBytes(Input),
            };
        }

        public static string EncodeString(byte[] Input)
        {
            return EncMode switch
            {
                "ASCII" => Encoding.ASCII.GetString(Input),
                "Unicode" => Encoding.Unicode.GetString(Input),
                "UTF8" => Encoding.UTF8.GetString(Input),
                "UTF32" => Encoding.UTF32.GetString(Input),
                _ => Encoding.UTF8.GetString(Input),
            };
        }
    }
}
