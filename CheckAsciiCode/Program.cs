using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckAsciiCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            //Console.OutputEncoding = Encoding.UTF8;
            string line;
            while (!string.IsNullOrEmpty(line = Console.ReadLine()))
            {
                var asciiCodeByte = Encoding.GetEncoding("Windows-1252").GetBytes(line);
                int asciiCode = asciiCodeByte[0];
                Console.WriteLine("Your Input is : " + line + " Ascii is : " + asciiCode + " Byte Length is : " + asciiCodeByte.Length);
            }

        }
    }
}
