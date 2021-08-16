using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ChipperUI
{
    internal class AlgorithmInstance
    {
        public List<byte> DataIn = new();
        public List<byte> DataOut = new();

        public byte[] EncryptData(byte[] inData, byte[] keyData)
        {
            DataOut.Clear();
            int x = 0;
            for (int i = 0; i < inData.Length; i++)
            {
                if (keyData.Length < i - x + 1)
                {
                    x += keyData.Length;
                }

                DataOut.Add((byte) (keyData[i - x] ^ inData[i]));
            }
            return DataOut.ToArray();
        }
    }
}
