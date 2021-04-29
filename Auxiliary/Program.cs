using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;

namespace Auxiliary
{
    class Program
    {
        static void Main(string[] args)
        {
            var raw = Console.ReadLine();
            byte[] rawBytes = Encoding.ASCII.GetBytes(raw);
            byte[] protectedBytes = Protect()
        }
    }
}
