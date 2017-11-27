using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupiTöö
{
    class Esimene
    {
        Console.WriteLine("Esimene arv: ");
            int arv1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Teine arv : ");
            int arv2 = int.Parse(Console.ReadLine());


        IEnumerable<int> numbers = Enumerable.Range(arv1, arv2);

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
            }
            Console.Read();       
    }
}
