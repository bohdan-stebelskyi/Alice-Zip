﻿using Archive;
using Aspose.Zip.LZMA;
using Aspose.Zip.Saving;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archiver.Lzma
{
    internal class Lzma : IArchiver
    {
        public void Archive(string inFile, string outFile)
        {
            Validator.ValidatePath(inFile);
            Validator.ValidatePath(outFile);

            using LzmaArchive archive = new();

            archive.SetSource(inFile);
            archive.Save(outFile);
        }
        public void Unarchive(string inFile, string outFile)
        {
            Validator.ValidatePath(inFile);
            Validator.ValidatePath(outFile);

            using LzmaArchive archive = new(inFile);

            using var extracted = File.Create(outFile);
            archive.Extract(extracted);
        }
    }
}
