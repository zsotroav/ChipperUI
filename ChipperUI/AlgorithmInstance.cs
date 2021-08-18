using System.Collections.Generic;

namespace LibChipper
{
    internal class AlgorithmInstance
    {
        public byte[] EncryptData(byte[] inData, byte[] keyData)
        {
            List<byte> DataOut = new();
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
