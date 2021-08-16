using System;
using System.IO;

namespace ChipperUI
{
    internal class External
    {
        public static readonly string WritePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static readonly string MainPath = Path.Combine(WritePath, "zsotroav", "chipper");

        public static void SaveBin(string loc, byte[] data)
        {
            using var fs = File.Create(loc);
            fs.Write(data, 0, data.Length);
            fs.Close();
        }

        public static byte[] LoadBin(string loc)
        {
            return File.ReadAllBytes(loc);
        }
    }
}
