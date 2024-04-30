﻿using Archive;
using Aspose.Zip.Lzip;
using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archiver.Lz
{
    internal class Lz : IArchiver
    {
        public void Archive(string inFile, string outFile)
        {
            Validator.ValidatePath(inFile);
            Validator.ValidatePath(outFile);

            using LzipArchive archive = new();

            archive.SetSource(inFile);
            archive.Save(outFile);
        }

        public void Unarchive(string inFile, string outFile)
        {
            Validator.ValidatePath(inFile);
            Validator.ValidatePath(outFile);

            using LzipArchive archive = new(inFile);

            using var extracted = File.Create(outFile);
            archive.Extract(extracted);
        }
    }
}
