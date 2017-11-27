using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupiTöö
{
    class Program
    {
        static void Main(string[] args)
        {
            //Suht jama on jah, viskab mingid konfliktid sisse siia...
            Teine teineül = new Teine();
            teineül.Luger();
            
            //Kuradi mergeimine on täielik jama
            Kolmas kolmasül = new Kolmas();
            kolmasül.ülesanded();

            Console.ReadKey();
            Esimene esimeneül = new Esimene();
            esimeneül.Arvud();
        }
             
    }
}
