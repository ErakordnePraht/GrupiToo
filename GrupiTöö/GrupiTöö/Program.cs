using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GrupiTöö
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = File.OpenText("kttekst.txt");
            string sisu = sr.ReadToEnd();
            sisu = sisu.Replace("\r\n", "\r");
            int tähed = sisu.Length;
            int read = sisu.Split('\r').Length;
            sisu = sisu.Replace('\r',' ');
            int sõnad = sisu.Split(' ').Length;


            if (read < 5)
            {
                Console.WriteLine("OK");
            }

            Console.WriteLine(sõnad);

            Console.ReadLine();
        }
    }
}
