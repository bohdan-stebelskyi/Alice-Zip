using System;
using System.IO;

namespace Checksum.Sha256
{
    internal class Sha256 : IChecksum
    {
        public int BufferSize { get; set; } = 1024 * 50;
        public string? CalculateChecksum(string inPath)
        {
            try
            {
                using var sha256 = System.Security.Cryptography.SHA256.Create();

                var attributes = File.GetAttributes(inPath);
                var buffer = new byte[BufferSize];

                using var fileStream = File.OpenRead(inPath);   // TODO: add exception handling (if folder is opened it throws and exception)

                var bytesRead = 0;
                while ((bytesRead = fileStream.Read(buffer, 0, BufferSize)) != 0)
                {
                    sha256.TransformBlock(buffer, 0, bytesRead, buffer, 0);
                }

                sha256.TransformFinalBlock(buffer, 0, 0);

                if (sha256.Hash != null)
                {
                    return BitConverter.ToString(sha256.Hash).Replace("-", "").ToLower();
                }

                return null;
            }
            catch
            {
                throw;
            }
        }
    }
}
