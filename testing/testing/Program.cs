using System;

namespace testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Angka ke 4");
            int angka1;
            angka1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Angka ke 3");
            int angka2;
            angka2 = int.Parse(Console.ReadLine());

            int jumlah;
            int kali;
            int bagi;
            int kurang;

            jumlah = angka1 + angka2;
            kurang = angka1 - angka2; //tess
            kali = angka1 * angka2;
            bagi = angka1 / angka2;

            Console.WriteLine("inihasilnyaaaa");
            Console.WriteLine($"angka1 = {angka1}");
            Console.WriteLine($"angka2 = {angka2}");
            Console.WriteLine($"{angka1} + {angka2}");
            Console.WriteLine($"{angka1} - {angka2}");
            Console.WriteLine($"{angka1} * {angka2}");
            Console.WriteLine($"{angka1} / {angka2}");

        }
    }
}
