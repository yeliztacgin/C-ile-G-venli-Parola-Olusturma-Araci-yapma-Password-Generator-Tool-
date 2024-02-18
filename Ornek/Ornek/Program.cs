using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Guvenli Parolanız Kaç Karakter Olsun");
            int sayi = int.Parse(Console.ReadLine());
            string patern = "ABCDEFGHIJKLMNOPSTYVZabcdefghjklpoıuytrew123456789-_?&(%+";
            Random rastgele = new Random();
            string createdPass = "";
            for (int i = 0; i < sayi; i++)
            {
                int rastgeleSayi = rastgele.Next(0,patern.Length);
                createdPass += patern[rastgeleSayi];

            }
            Console.WriteLine(createdPass);
            Console.ReadLine();
        }
    }
}
