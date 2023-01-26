using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace KlicServisa
{
    internal class Program
    {
        static void Main(string[] args)

        {
            RunAsync().Wait();
        }

        private static async Task RunAsync()
        {
            HttpClient klient = new HttpClient();
            klient.BaseAddress = new Uri("http://localhost:55412/");
            klient.DefaultRequestHeaders.Accept.Clear();
            klient.DefaultRequestHeaders.Accept.Add(new 
                System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            //HttpResponseMessage odgovor = await klient.GetAsync("api/Produkti/1");
            //if (odgovor.IsSuccessStatusCode)
            //{
            //    Produkt p = await odgovor.Content.ReadAsAsync<Produkt>();
            //    Console.WriteLine(p.Ime+" "+p.Cena);
            //}
            HttpResponseMessage odgovor = await klient.GetAsync("api/Produkti");
            if (odgovor.IsSuccessStatusCode)
            {
                List<Produkt> vsi = await odgovor.Content.ReadAsAsync<List<Produkt>>();
                foreach(var p in vsi)
                {
                    Console.WriteLine(p.Ime + " "+ p.Cena);
                }
            }
            Console.ReadLine();
        }
    }
}
