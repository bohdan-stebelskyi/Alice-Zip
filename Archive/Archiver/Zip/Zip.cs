using ICSharpCode.SharpZipLib.Zip;
using System;
using System.IO;
using System.Text;
using Archive;

namespace Archiver.Zip
{
    internal class Zip : IArchiver
    {
        public string SearchPattern { get; set; } = "*";
        public SearchOption SearchOption { get; set; } = SearchOption.AllDirectories;
        public Encoding Encoding { get; set; } = Encoding.UTF8;
        public int CompressionLevel { get; set; } = 5;
        public UseZip64 UseZip64 { get; set; } = UseZip64.Off;
        public string? Password { get; set; } = null;
        public int BufferSize { get; set; } = 81920;

        public void Archive(string inPath, string outPath)
        {
            Validator.ValidatePath(inPath);
            Validator.ValidatePath(outPath);

            var fileNames = Directory.GetFiles(inPath, SearchPattern, SearchOption);

            using ZipOutputStream zipOutputStream = new(File.Create(outPath));

            zipOutputStream.SetLevel(CompressionLevel);
            zipOutputStream.UseZip64 = UseZip64;
            zipOutputStream.Password = Password;

            foreach (var file in fileNames)
            {
                var relativePath = Utils.GetRelativePath(inPath, file);

                ZipEntry zipEntry = new(relativePath)
                {
                    DateTime = DateTime.Now
                };
                zipOutputStream.PutNextEntry(zipEntry);

                using var fileStream = File.OpenRead(file);
                fileStream.CopyTo(zipOutputStream, BufferSize);
            }
        }

        public void Unarchive(string inPath, string outPath)
        {
            Validator.ValidatePath(inPath);
            Validator.ValidatePath(outPath);

            if (!Directory.Exists(outPath))
            {
                Directory.CreateDirectory(outPath);
            }

            using ZipInputStream zipInputStream = new(File.OpenRead(inPath));

            while (zipInputStream.GetNextEntry() is { } zipEntry)
            {
                zipInputStream.Password = Password;
                var dirName = Path.GetDirectoryName(zipEntry.Name);
                var fileName = Path.GetFileName(zipEntry.Name);

                if (!string.IsNullOrEmpty(dirName))
                {
                    var fullDirPath = Path.Combine(outPath, dirName);
                    Directory.CreateDirectory(fullDirPath);
                }

                if (string.IsNullOrEmpty(fileName)) continue;

                using var fileStream = File.Create(Path.Combine(outPath, zipEntry.Name));
                zipInputStream.CopyTo(fileStream);
            }
        }
    }
}
