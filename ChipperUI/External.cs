using System;
using System.IO;
using System.Text;

namespace ChipperUI
{
    class External
    {
        public static readonly string WritePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static readonly string MainPath = Path.Combine(WritePath, "zsotroav", "chipper");

        public static void SaveBin(string loc, byte[] Data)
        {
            using FileStream fs = File.Create(loc);
            fs.Write(Data, 0, Data.Length);
            fs.Close();
        }

        public static byte[] LoadBin(string loc)
        {
            return File.ReadAllBytes(loc);
        }
    }
}
