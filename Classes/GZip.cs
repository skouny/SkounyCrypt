using System;
using System.Text;
using System.IO.Compression;
using System.IO;

namespace SkounyCrypt
{
    class GZip
    {
        // Compress byte array using deflate
        public static byte[] CompressBytes(byte[] bytes)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                using (GZipStream gZipStream = new GZipStream(stream, CompressionMode.Compress, true))
                {
                    gZipStream.Write(bytes, 0, bytes.Length);
                }
                stream.Position = 0;
                // gzip output bytes without header
                byte[] bodyBytes = new byte[(Int32)stream.Length];
                stream.Read(bodyBytes, 0, bodyBytes.Length);
                // uncompressed size
                byte[] headerBytes = BitConverter.GetBytes(bytes.Length);
                // All together, header + bytes
                byte[] totalBytes = new byte[headerBytes.Length + bodyBytes.Length];
                Buffer.BlockCopy(headerBytes, 0, totalBytes, 0, headerBytes.Length);
                Buffer.BlockCopy(bodyBytes, 0, totalBytes, 4, bodyBytes.Length);
                return totalBytes;
            }
        }
        // Decompress byte array using deflate
        public static byte[] DecompressBytes(byte[] bytes)
        {
            using (var stream = new MemoryStream())
            {
                // get the result body byte length from header bytes
                int resultLength = BitConverter.ToInt32(bytes, 0);
                // write body bytes to the stream
                stream.Write(bytes, 4, bytes.Length - 4);
                stream.Position = 0;
                // create, read and return the result buffer
                byte[] resultBytes = new byte[resultLength];
                using (var gZipStream = new GZipStream(stream, CompressionMode.Decompress))
                {
                    gZipStream.Read(resultBytes, 0, resultBytes.Length);
                }
                return resultBytes;
            }
        }
    }
}
