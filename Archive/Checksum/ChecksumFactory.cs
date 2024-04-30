namespace Checksum
{
    internal class ChecksumFactory
    {
        public static IChecksum CreateChecksum(string typeName)
        {
            IChecksum checksumType = typeName.ToLower() switch
            {
                "sha256" => new Sha256.Sha256(),
                "crc32" => new Crc32.Crc32(),
                "bzip2crc" => new BZip2Crc.BZip2Crc(),
                "adler32" => new Adler32.Adler32(),
                _ => new Sha256.Sha256(),
            };

            return checksumType;
        }
    }
}
