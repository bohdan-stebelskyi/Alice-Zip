using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using ICSharpCode.SharpZipLib.GZip;
using ICSharpCode.SharpZipLib.BZip2;
using ICSharpCode.SharpZipLib.Tar;
using ICSharpCode.SharpZipLib.Zip;
using System.Diagnostics.Contracts;
using System.IO;
using Archive;

namespace Archiver.Tar
{
    internal class Tar : IArchiver
    {
        public string SearchPattern { get; set; } = "*";
        public SearchOption SearchOption { get; set; } = SearchOption.AllDirectories; 
        public Encoding Encoding { get; set; } = Encoding.UTF8;
        public int UserId { get; set; } = 0;
        public string UserName { get; set; }
        public int GroupId { get; set; } = 0;
        public string GroupName { get; set; } = "None";
        public bool KeepOldFiles { get; set; } = false;
        public bool AsciiTranslate { get; set; } = false;

        private string GetRelativePath(string relativeTo, string path)
        {
            var uri = new Uri(relativeTo);
            var rel = Uri.UnescapeDataString(uri.MakeRelativeUri(new Uri(path)).ToString()).Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar);
            if (rel.Contains(Path.DirectorySeparatorChar.ToString()) == false)
            {
                rel = $".{Path.DirectorySeparatorChar}{rel}";
            }
            return rel;
        }

        public Tar()
        {
            var sysUserName = Environment.UserName;
            UserName = (sysUserName ?? "");
        }

        public void Archive(string inPath, string outPath)
        {
            Validator.ValidatePath(inPath);
            Validator.ValidatePath(outPath);

            using FileStream fileStream = File.Create(outPath);
            using TarOutputStream tarOutputStream = new(fileStream, Encoding);

            using TarArchive tarArchive = TarArchive.CreateOutputTarArchive(tarOutputStream, Encoding);

            tarArchive.SetUserInfo(UserId, UserName, GroupId, GroupName);
            tarArchive.SetKeepOldFiles(KeepOldFiles);
            tarArchive.AsciiTranslate = AsciiTranslate;

            string[] fileNames = Directory.GetFiles(inPath, SearchPattern, SearchOption);

            TarEntry tarEntry;

            foreach (string file in fileNames)
            {
                string relativePath = GetRelativePath(inPath, file);

                tarEntry = TarEntry.CreateEntryFromFile(Path.GetFullPath(file));
                tarEntry.Name = relativePath;   // remove to create additional inputDirName folder with files in archive
                tarArchive.WriteEntry(tarEntry, true);
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

            using var fileStream = File.OpenRead(inPath);
            using var tarInputStream = new TarInputStream(fileStream, Encoding);

            using var tarArchive = TarArchive.CreateInputTarArchive(tarInputStream, Encoding);
            tarArchive.ExtractContents(outPath);
        }
    }
}
