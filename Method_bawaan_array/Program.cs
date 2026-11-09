using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_bawaan_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] angka = { 42, 7, 19, 3, 25 };

            Array.Sort(angka);
            Console.WriteLine("Terurutkan: " + string.Join(", ", angka));

            Array.Reverse(angka);
            Console.WriteLine("Dibalik: " + string.Join(", ", angka));

            Console.WriteLine("Indeks 19 : " + Array.IndexOf(angka, 19));
            Console.WriteLine("Jumlah    : " + angka.Sum());
            Console.WriteLine("Terbesar  : " + angka.Max());
        }
    }
}
