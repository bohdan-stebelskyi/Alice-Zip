using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archiver
{
    internal interface IArchiver
    {
        public void Archive(string inPath, string outPath);

        public void Unarchive(string inPath, string outPath);
    }
}
