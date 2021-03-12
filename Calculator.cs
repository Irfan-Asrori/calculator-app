using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";
            Console.WriteLine("Pilih Menu Calculator:");
            Console.WriteLine();
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine();
            Console.Write("Input nomor menu {1...4}: ");
            int pilihan = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (pilihan == 1)
            {
                Console.Write("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Inputkan nilai b = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Hasil Penambahan {0} + {1} = {2}", a, b, penambahan(a, b));
            }
            else if (pilihan == 2)
            {
                Console.Write("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Inputkan nilai b = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, pengurangan(a, b));
            }
            else if (pilihan == 3)
            {
                Console.Write("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Inputkan nilai b = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, perkalian(a, b));
            }
            else if (pilihan == 4)
            {
                Console.Write("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Inputkan nilai b = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, pembagian(a, b));
            }
            else
                Console.WriteLine("Maaf, menu yang anda pilih tidak tersedia");
            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }
        static int penambahan(int a, int b)
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
        static int pembagian(int a, int b)
        {
            return a / b;
        }
    }
}


















