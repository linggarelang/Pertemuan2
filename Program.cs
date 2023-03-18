using System;

namespace Pertemuan1
{
    // Code Has Created by Linggar Elang Pratama_22.11.4849 

    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("\nAplikasi Kalkulator Sederhana \n");
            Console.WriteLine("1. Penjumlahan \n2. Pengurangan \n3. Perkalian \n4. Pembagian");
            Console.WriteLine("___________________________________________________________________");
            Console.Write("Pilih 1/2/3/4 : ");
            char pilih = char.Parse(Console.ReadLine());
            Console.WriteLine("___________________________________________________________________");


            switch (pilih)
            {
                case '1':
                    // Input Angka
                    Console.Write("Input nilai a : ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Input nilai b : ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("___________________________________________________________________");

                    Console.WriteLine("Hasil");
                    Console.WriteLine(a + " + " + b + " = " + penjumlahan(a, b));
                    break;
                case '2':
                    // Input Angka
                    Console.Write("Input nilai a : ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Input nilai b : ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("___________________________________________________________________");

                    Console.WriteLine("Hasil");
                    Console.WriteLine(a + " - " + b + " = " + pengurangan(a, b));
                    break;
                case '3':
                    // Input Angka
                    Console.Write("Input nilai a : ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Input nilai b : ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("___________________________________________________________________");

                    Console.WriteLine("Hasil");
                    Console.WriteLine(a + " * " + b + " = " + perkalian(a, b));
                    break;
                case '4':
                    // Input Angka
                    Console.Write("Input nilai a : ");
                    double x = double.Parse(Console.ReadLine());
                    Console.Write("Input nilai b : ");
                    double y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("___________________________________________________________________");

                    Console.WriteLine("Hasil");
                    Console.WriteLine(x + " / " + y + " = " + pembagian(x, y));
                    break;
                default:
                    Console.WriteLine("Data Tidak Ditemukan!");
                    break;
            }

            Console.WriteLine("\n");
        }


        static int penjumlahan(int a, int b)
        {
            return a + b;
        }
        static int pengurangan(int a, int b)
        {
            return a - b;
        }
        static int perkalian(int a, int b)
        {
            return a * b;
        }
        static double pembagian(double x, double y)
        {
            return x / y;
        }
    }
}
