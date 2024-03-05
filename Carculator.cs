using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";


            Console.Write("Input nilai a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Input nilai b = ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Pilih menu calculator :");

            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");

            int Pilih = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (Pilih == 1)
            {

                Console.WriteLine("Hasil Penambahan " + a + "+" + b + "=" + Penambahan(a, b));
            }
            if (Pilih == 2)
            {
                Console.WriteLine("Hasil Penambahan " + a + "-" + b + "=" + Pengurangan(a, b));
            }
            if (Pilih == 3)
            {
                Console.WriteLine("Hasil Perkalian " + a + "*" + b + "=" + Penambahan(a, b));
            }
            if (Pilih == 4)
            {
                Console.WriteLine("Hasil Pembagian " + a + "/" + b + "=" + Penambahan(a, b));
            }


            /*int a = 10;
            int b = 6;*/



            Console.WriteLine("Hasil Penambahan " + a + "+" + b + "=" + Penambahan(a, b));
            Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
            Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadLine();
        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static float Pembagian(float a, float b)
        {
            return a / b;
        }
    }
}
