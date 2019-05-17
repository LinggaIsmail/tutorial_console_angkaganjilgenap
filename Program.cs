using System;

namespace AngkaGanjilGenap
{
    class Program
    {
        static void Main(string[] args)
        {
            int bil;
            string strbil;
            string ket;

            Console.Write("Masukan bilangan = ");
            strbil = Console.ReadLine();

            while(!int.TryParse(strbil, out bil))
            {
                Console.WriteLine("Masukan hanya angka!");
                Console.Write("Masukan bilangan = ");
                strbil = Console.ReadLine();
            }

            if (bil % 2 == 0) {
                ket = "'Genap'";
            } else {
                ket = "'Ganjil'";
            }

            Console.WriteLine("Bilangan yang dimasukan adalah bilangan " + ket);
            Console.ReadKey();
        }
    }
}
