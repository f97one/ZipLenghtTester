using System;
using System.Diagnostics;
using System.IO.Compression;
using System.Linq;

namespace ZipLengthTester
{
    class ZipFileOperation
    {
        private const int ZipLeadBytes = 0x04034b50;

        public bool IsPkZipCompressedData(byte[] data)
        {
            Debug.Assert(data != null && data.Length > 4);
            return (BitConverter.ToInt32(data, 0) == ZipLeadBytes);
        }

        public double CountLength(string filePath, int multiplier, bool thousandIsBit)
        {
            double d;
            using (var za = ZipFile.OpenRead(filePath))
            {
                var totalLength = za.Entries.Sum(entry => entry.Length);
                var kiro = thousandIsBit ? 1024 : 1000;
                d = (double) totalLength / Math.Pow((double) kiro, (double) multiplier);

            }

            return Math.Round(d, 3, MidpointRounding.AwayFromZero);

        }
    }
}
