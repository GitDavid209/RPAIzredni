using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaIzrazi
{
    internal class Program
    {
        //delegat //delagati so "Func(vrača nekaj)", "
       // delegate bool FunkcijaZaNize(string s); //definicija delegata
        static void Main(string[] args)
        {
            string[] imena = {"Simon","David", "Blaž", "Ivan", "Neža", "Alen", "Erik", "Mitja", "Kristjan" };
            List<string> a = DelajOperacijeNadNizi(imena, ZačneSS);

            //List<string> b = DelajOperacijeNadNizi(imena, delegate (string s) { return s.EndsWith("n"); });
            List<string> b = DelajOperacijeNadNizi(imena, s => s.EndsWith("n")); //Lambda izraz
            foreach (string x in b)
            {
                Console.WriteLine(x);
            }
            //List<string> naS = new List<string>();
            //foreach (var x in imena)
            //{
            //    if(x.EndsWith ("n")){
            //        Console.WriteLine(x);
            //        naS.Add(x);
            //    }
            //}
            Console.ReadLine();
        }
        static List<string> DelajOperacijeNadNizi(string[] mojinizi, Func<string,bool> mojaFunkcija)
        {
            List<string> rezultat = new List<string>();
            foreach(string x in mojinizi)
            {
                if (mojaFunkcija(x))
                    rezultat.Add(x);
            }
            return rezultat;
        }
        static bool ZačneSS(string a)
        {
            return a.StartsWith("S");
        }
        //static bool KončaZN(string a)
        //{
        //    return a.EndsWith("n");
        //}
    }
}
