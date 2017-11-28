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

            Console.WriteLine("Sisestage esimene arv: ");
            int arv1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Sisestage teine arv: ");
            int arv2 = int.Parse(Console.ReadLine());

            if (arv1 % 2 != 0)
            {
                arv1++;
            }
            for (int i = arv1; i <= arv2; i += 2)
            {
                    Console.WriteLine("Paarisarv on: " + i);
            }
            if (arv2 % 2 != 0)
            {
                arv2++;
            }
            for (int i = arv2; i <= arv1; i += 2)
            {
                Console.WriteLine("Paarisarv on: " + i);
            }
        }
    }
}
