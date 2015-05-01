//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using System.IO.Compression;
using System.Text;

namespace CompresJSON
{
    public class CompressorDefaults
    {
        public static CompressionMethod compressionMethod = CompressionMethod.LZ77;
        public static EncodingMethod encodingMethod = EncodingMethod.Base64;
        public static Encoding encoder = UTF8Encoding.UTF8;
    }
}
