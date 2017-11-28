using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupiTöö
{
    class Esimene
    {
        public void Arvud()
        {

            Console.WriteLine("Esimene arv: ");
            int arv1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Teine arv : ");
            int arv2 = int.Parse(Console.ReadLine());

            if (arv1 % 2 != 0)
            {
                arv1++;
            }
            for (i = arv1; i <= arv2; i += 2)
            {
                    Console.WriteLine("paarisarv on: ", i);
            }
            Console.ReadLine();
        }
    }
}
