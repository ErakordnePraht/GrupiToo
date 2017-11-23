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
            StreamReader sr = new StreamReader("kttekst.txt");

            int sPikkus = 0;
            int luger = 0;
            string delim = " ,.";
            string[] fields = null;
            string line = null;

            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                line.Trim();
                fields = line.Split(delim.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                luger += fields.Length;

                foreach (char letter in luger.ToString())
                {
                    sPikkus++;
                }
            }


            sr.Close();
            
            Console.WriteLine("Sõnade arv: {0}", luger);
            Console.WriteLine("Väiksemad kui 5: {0}", sPikkus);

            Console.ReadLine();
        }
    }
}
