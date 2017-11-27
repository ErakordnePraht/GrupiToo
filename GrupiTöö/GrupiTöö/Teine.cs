using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
=======
using System.IO;
>>>>>>> Teine

namespace GrupiTöö
{
    class Teine
    {
<<<<<<< HEAD
=======
        public void Luger()
        {
            string txt = File.ReadAllText("kttekst.txt");
            string[] sõnad = txt.Split(' ');

            int p = 0;
            foreach (var sõna in sõnad)
            {
                if (sõna.Length < 5)
                {
                    p++;
                }
            }

            Console.WriteLine("Failis on: " + sõnad.Length + " sõna.");
            Console.WriteLine("Failis on: " + p + " sõna, mis on väiksemad kui 5 tähte.");

            Console.ReadLine();
        }
>>>>>>> Teine
    }
}
