using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Checksum
{
    public interface IChecksum
    {
        string? CalculateChecksum(string inPath);
    }
}
