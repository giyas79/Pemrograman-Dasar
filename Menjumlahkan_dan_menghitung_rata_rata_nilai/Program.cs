using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menjumlahkan_dan_menghitung_rata_rata_nilai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nilai = { 80, 75, 90, 85, 70 };
            int total = 0;

            for (int i = 0; i < nilai.Length; i++)
            {
                total += nilai[i];          // total = total + nilai[i]
            }

            double rata = (double)total / nilai.Length;

            Console.WriteLine("Total      : " + total);
            Console.WriteLine("Rata-rata  : " + rata);   
        }
    }
}
