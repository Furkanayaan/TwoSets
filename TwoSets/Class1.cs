using System;

namespace TwoSets
{
    public class Class1
    {
        public static void Main()
        {
            Console.WriteLine("Bir sayi giriniz");
            string number = Console.ReadLine();
            int N = Convert.ToInt32(number);
            if (N % 4 == 1 || N % 4 == 2) Console.WriteLine("NO");
            else if (N % 4 == 3)
            {
                Console.WriteLine("YES");
                Console.WriteLine(N/2);
                for (int i = 2; i <= N/2; i+=2)
                {
                    Console.Write(i);
                    Console.Write(" ");
                    Console.Write(N-i);
                    Console.Write(" ");
                }
                
                Console.Write(N);
                Console.Write("\n");
                Console.WriteLine(N/2+1);
                for (int i = 1; i <= N/2; i+=2)
                {
                    Console.Write(i);
                    Console.Write(" ");
                    Console.Write(N-i);
                    Console.Write(" ");
                }
            }
            else
            {
                Console.WriteLine("YES");
                Console.WriteLine(N/2);
                for (int i = 2; i <= N/2; i+=2)
                {
                    Console.Write(i);
                    Console.Write(" ");
                    Console.Write(N-i+1);
                    Console.Write(" ");
                }
                Console.Write("\n");
                Console.WriteLine(N/2);
                for (int i = 1; i <= N/2; i+=2)
                {
                    Console.Write(i);
                    Console.Write(" ");
                    Console.Write(N-i+1);
                    Console.Write(" ");
                }
            }
        }
    }
}