using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalSayi
{
    internal class Program
    {
        private static bool AsalSayi(int veri)
        {
            bool result = true;
            for (int i = 2; i < veri - 1; i++)
            {
                if (veri % i == 0)
                {
                    result = false;
                    i = veri;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.Write("Bir Sayı Girin:");
            int veri =Convert.ToInt32(Console.ReadLine());
            if (AsalSayi(veri))
            {
                Console.WriteLine("Asal Saydıdır.");
            }
            else
            {
                Console.WriteLine("Asal Sayı Değildir.");
            }
            Console.ReadLine();
        }
    }
}
