using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Dolgozói_nyilvántartás;

namespace Dolgozói_nyilvántartás
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            List<Nyilvantartas> nyil = new List<Nyilvantartas>();
            nyil=await dolgozok();
            Console.WriteLine($"{nyil.Count()}fő dolgozik");
            int maxSalery = int.MinValue;
            foreach (Nyilvantartas nyilvan in nyil)
            {
                if (nyilvan.NyilvantartaSalary > maxSalery)
                {
                    maxSalery = (int)nyilvan.NyilvantartaSalary;
                    await Console.Out.WriteLineAsync($"{nyilvan.NyilvantartaName} rendelkezik a legnagyobb fizetéssel");
                }
            }
            foreach(var nyilvan in nyil.GroupBy(a => a.NyilvantartaPosition).Select(b => new {pozicio=b.Key,letszam=b.Count() }))
            {
                Console.WriteLine($"Munkakörök: {nyilvan.pozicio} : {nyilvan.letszam}");
            }
            Console.ReadKey();
        }
        private static async Task<List<Nyilvantartas>> dolgozok()
        {
            List<Nyilvantartas> nyil = new List<Nyilvantartas>();
            string url = $"https://retoolapi.dev/Kc6xuH/data";
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                string jsonString = await response.Content.ReadAsStringAsync();
                nyil = Nyilvantartas.FromJson(jsonString).ToList();
            }
            return nyil;
        }
    }
}
