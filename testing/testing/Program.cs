using System;

namespace testing
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            //input data

            for(int k=0; k<10; k++)
            {
                Console.WriteLine("halo raul" + k);
                a[k] = Convert.ToInt32(Console.ReadLine());
            }
            //kebalikan dari inpudata dan menamilkan data yang di atas
            for (int k = 0; k < 10; k++)
            {
                Console.WriteLine("\n"); //spasi
                Console.WriteLine("isi array ke -" + k);
                Console.WriteLine(a[k]);
            }

        }
    }
}