using System;

namespace SONGUYENTO
{ 
    class Program
    {
        static void Main(string[] args)
        {
            int number = 20;
            int count = 0;
            int n = 2;
            while (count < number)
            {
                int i = 2;
                bool check = true;
                while (i <= Math.Sqrt(n))
                {
                     if (n % i == 0)
                     {
                        check = false;
                        break;
                     }
                     i++;

                }
                if (check)
                {
                    Console.WriteLine(n + " is a prime");
                    count++;
                }
                n++;
            }

        }



        
    }
}
