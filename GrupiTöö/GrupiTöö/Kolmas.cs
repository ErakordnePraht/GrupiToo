using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupiTöö
{
    class Kolmas
    {
        //Mergeimine lihtsalt ei tööta vahest
        public double[] array1 = new double[] { 11, 15, 6, 13, 13, 25, 32, 11, 20, 5, 31, 16, 32, 29, 11, 13, 3, 29, 28, 24 };
        public double[] array2 = new double[] { 5, 19, 16, 4, 12, 7, 2, 28, 34, 29, 29, 36, 6, 8, 24, 18, 31, 7, 1, 7 };

        public void ülesanded()
        {
            Console.WriteLine("Mõlemas listis on: ");
            foreach (int element in array1)
            {
                if (array2.Contains(element))
                {
                    Console.WriteLine(element);
                }
            }
            Console.WriteLine();
            double Array1Max = array1.Max();
            double Array2Max = array2.Max();
            double Array1Min = array1.Min();
            double Array2Min = array2.Min();
            Console.WriteLine("Esimese listi suurim number on: " + Array1Max + " ja väikseim on: " + Array1Min);
            Console.WriteLine("Teise listi suurim number on: " + Array2Max + " ja väikseim on: " + Array2Min);
            Console.WriteLine();

            double Summa1 = 0;
            double Summa2 = 0;
            foreach (double element in array1)
            {
                Summa1 += element;
            }
            foreach (double element in array2)
            {
                Summa2 += element;
            }
            double Keskmine1 = Summa1 / array1.Length;
            double Keskmine2 = Summa2 / array2.Length;

            Console.WriteLine("Esimese listi keskmine on: " + Keskmine1);
            Console.WriteLine("Teise listi keskmine on: " + Keskmine2);
        }
    }
}
