using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int pilihan = 0;
            Bangun2D Panggil;
            Console.WriteLine("==========Perhitungan Luas==========");
            Console.WriteLine("1. Lingkaran");
            Console.WriteLine("2. Segitiga");
            Console.WriteLine("3. Persegi");
            Console.WriteLine("4. Persegi Panjang");
            Console.WriteLine("====================================");
            Console.Write("Pilihanmu : ");
            pilihan = int.Parse(Console.ReadLine());
            Console.WriteLine("====================================");
            switch (pilihan)
            {
                case 1:
                    Console.WriteLine("Anda memilih Lingkaran");
                    Console.WriteLine("====================================");
                    Console.Write("Masukkan Jari-Jari :");
                    double jari = Convert.ToDouble(Console.ReadLine());
                    Panggil = new Lingkaran(jari);
                    Panggil.CetakLuas("Lingkaran");
                    Console.WriteLine("====================================");
                    break;

                case 2:
                    Console.WriteLine("Anda memilih Segitiga");
                    Console.WriteLine("====================================");
                    Console.Write("Masukkan Alas :");
                    double alas = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukkan Tinggi :");
                    double tinggi = Convert.ToDouble(Console.ReadLine());
                    Panggil = new Segitiga(alas, tinggi);
                    Panggil.CetakLuas("Segitiga");
                    Console.WriteLine("====================================");
                    break;

                case 3:
                    Console.WriteLine("Anda memilih Persegi");
                    Console.WriteLine("====================================");
                    Console.Write("Masukkan Panjang sisi :");
                    double sisi = Convert.ToDouble(Console.ReadLine());
                    Panggil = new Persegi(sisi);
                    Panggil.CetakLuas("Persegi");
                    Console.WriteLine("====================================");
                    break;

                case 4:
                    Console.WriteLine("Anda memilih Persegi Panjang");
                    Console.WriteLine("====================================");
                    Console.Write("Masukkan Panjang :");
                    double panjang = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukkan Lebar   :");
                    double lebar = Convert.ToDouble(Console.ReadLine());
                    Panggil = new PersegiPanjang(panjang, lebar);
                    Panggil.CetakLuas("Persegi Panjang");
                    Console.WriteLine("====================================");
                    break;

                default:
                    Console.WriteLine("Your Choice is not found, try again see you later good bye.");
                    break;
            }
            Console.Read();
        }
    }
}