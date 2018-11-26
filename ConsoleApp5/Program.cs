using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("tomb merete:");
                int m;
                m = Convert.ToInt32(Console.ReadLine());
                int[] tm = new int[m];
                for (int i = 0; i < m; i++) 
                {
                    Console.WriteLine("Kérem a {0}. számot", i + 1);
                    tm[i] = Convert.ToInt32(Console.ReadLine());
                }


                for (int i = 0; i < tm.Length; i++)
                {
                    Console.WriteLine("Szam " + i + ": " + tm[i]);
                }
                int max = tm[0];
                int n = tm.Length;
                for (int i = 0; i < n; i++)
                {
                    if (tm[i] > max)
                    {
                        max = tm[i];
                    }
                }
                Console.WriteLine("A legnagyobb elem: {0}", max);

                int min;
                min = tm[0];
                for (int i = 0; i < n; i++)
                {
                    if (tm[i] < min)
                    {
                        min = tm[i];
                    }
                }
                Console.WriteLine("A legkisebb elem: {0}", min);

            }
            catch (FormatException mess)
            {
                Console.WriteLine(mess);
                Console.WriteLine("Nem megfelelo formatumot adott meg.");
            }
            Console.ReadLine();
        }
    }
}
