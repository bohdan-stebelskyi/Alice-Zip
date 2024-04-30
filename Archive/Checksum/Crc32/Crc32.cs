﻿using System;
using System.IO;

namespace Checksum.Crc32
{
    internal class Crc32 : IChecksum
    {
        public int BufferSize { get; set; } = 4096;
        public string? CalculateChecksum(string inPath)
        {
            try
            {
                using var checksumStream = File.OpenRead(inPath);

                var currentCrc = new ICSharpCode.SharpZipLib.Checksum.Crc32();

                var buffer = new byte[BufferSize];
                var bytesRead = 0;


                while ((bytesRead = checksumStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    currentCrc.Update(new ArraySegment<byte>(buffer, 0, bytesRead));
                }

                return currentCrc.Value.ToString("X");
            }
            catch
            {
                throw;
            }
        }
    }
}
