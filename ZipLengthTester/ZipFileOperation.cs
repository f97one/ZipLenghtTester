using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
