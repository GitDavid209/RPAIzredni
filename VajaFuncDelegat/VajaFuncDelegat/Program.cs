using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaFuncDelegat
{
    internal class Program
    {
        //delegate string Spremeni(string s);
        static void Main(string[] args)
        {
            Func<string,string> metoda = x=>x.ToUpper();
            string ime = "Barbara";
            Console.WriteLine(metoda(ime));
            Console.ReadLine();
        }

        //private static string VVelik(string s)
        //{
        //    return s.ToUpper();
        //}
    }
}
