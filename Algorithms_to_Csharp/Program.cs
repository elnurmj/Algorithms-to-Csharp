using System;

namespace Algorithms_to_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Divided(21);
            Divided(17);
            Divided(-3);
            int count = OddNumbers(10, 20);
            Console.WriteLine(count);
            int sum = OddNumbersSum(20, 25);
            Console.WriteLine(sum);
            SimpleOrComplex(121);
            int[] array = { 1, 2, 4, 5, 6, 7, 8, 9, 10 };
            SumOfEvenNumbers(array);
        }
        // 3 ve 7 ye bolunenler.
        static void Divided(int x)
        {
            if (x <= 0)
            {
                Console.WriteLine("Enter the correct number");

            }
            else if (x % 3 == 0 && x % 7 == 0)
            {
                Console.WriteLine("Devided to 3 and 7");
            }
            else
            {
                Console.WriteLine("Not devided to 3 and 7");
            }


        }
        // Tek ededlerin sayi.
        static int OddNumbers(int n, int m)
        {
            int count = 0;
            if (n < 1 && m < 1)
            {
                Console.WriteLine("Enter the correct number");

            }
            else
            {
                for (int i = n; i < m; i++)
                {
                    if (i % 2 != 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        // Tek ededlerin cemi.
        static int OddNumbersSum(int n, int m)
        {
            int sum = 0;
            if (n < 1 && m < 1)
            {
                Console.WriteLine("Wrong number");

            }
            else
            {
                for (int i = n; i < m; i++)
                {
                    if (i % 2 != 0)
                    {
                        sum += i;
                    }
                }
            }
            return sum;

        }
        // Ededin sade ve ya murekkeb olmasinin teyini.
        static void SimpleOrComplex(int n)
        {
            int count = 0;
            if (n <= 1)

            {
                Console.WriteLine("Enter correct number");

            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)

                    {
                        count++;


                    }

                }
                if (count > 2)
                {
                    Console.WriteLine("The number is Complex");

                }
                else
                {
                    Console.WriteLine("The number is simple");
                }



            }
        }
        // Array icindeki cut reqemlerin cemi.
        static void SumOfEvenNumbers(int[] array)
        {
            int sumeven = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sumeven += array[i];
                }
            
            }
            Console.WriteLine(sumeven);
        }
        

    }
}


     







    
    

