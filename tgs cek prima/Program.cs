using System;

namespace tgs_cek_prima
{
    class Program
    {
        static void Main(string[] args)
        {
            int tes = 1;
            while (tes == 1)
            {
                Console.Write("Masukkan angka : ");
                int input = Convert.ToInt32(Console.ReadLine());
                int cek = 0;
                for (int i = 1; i <= input; i++)
                {
                    if (input % i == 0)
                    {
                        cek += 1;
                    }

                }
                if (cek == 2)
                {
                    Console.WriteLine("angka prima");
                }
                else
                {
                    Console.WriteLine("angka bukan prima");
                }
            }
        }
    }
}
