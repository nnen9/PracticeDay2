using System;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("№1"); 
            int a = Convert.ToInt32(Console.ReadLine());
            if (a >= 0)
            {
                a = a + 5; Console.WriteLine(a);
            }
            else if (a < 0)
            {
                a = a - 5;
                Console.WriteLine(a);
            }
            Console.WriteLine();

            Console.WriteLine("№2"); 
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine()); 
            int d = Convert.ToInt32(Console.ReadLine());
            if (b > c && b > d)
            {
                Console.WriteLine(b);
            }
            if (c > b && c > d)
            {
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine(d);
            }
            Console.WriteLine();

            Console.WriteLine("№3"); 
            int sum = 0;
            for (int f = 0; f < 3; f++)
            {
                int g = Convert.ToInt32(Console.ReadLine()); if (g > 0)
                {
                    sum += g;
                }
            }
            Console.WriteLine(sum); 
            Console.WriteLine();

            Console.WriteLine("№4");
            int x = Convert.ToInt32(Console.ReadLine()); 
            switch (x)
            {
                case (> 10):
                    Console.WriteLine(x * 2);
                    break;
            }
            if (x < 10)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();

            Console.WriteLine("№5");
            int h = Convert.ToInt32(Console.ReadLine()); 
            switch (h)
            {
                case (1):
                    Console.WriteLine("Понедельник"); 
                    break;
                case (2):
                    Console.WriteLine("Вторник");
                    break;
                case (3):
                    Console.WriteLine("Среда"); 
                    break;
                case (4):
                    Console.WriteLine("Четверг");
                    break;
                case (5):
                    Console.WriteLine("Пятница"); 
                    break;
                case (6):
                    Console.WriteLine("Суббота");
                    break;
                case (7):
                    Console.WriteLine("Воскресенье"); 
                    break;
            }
            Console.WriteLine();

            Console.WriteLine("Циклы");
            Console.WriteLine("№1"); 
            int i = 200;
            while (true)
            {
                if (i % 17 == 0)
                {
                    break;
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine(i);
            Console.WriteLine();

            Console.WriteLine("№2");
            int q = 10;
            double r = q;
            int countDays = 1;
            while (r < 20)
            {
                r += r * 0.05;
                countDays++;
            }
            Console.WriteLine(countDays + " день - 20 км");
            r = q;
            countDays = 1;
            while (r < 100)
            {
                r += r * 0.05;
                countDays++;
            }
            Console.WriteLine(countDays + " день - 100 км");
            Console.WriteLine();

            Console.WriteLine("№3"); 
            int n = Convert.ToInt32(Console.ReadLine());
            int l = 1; 
            for (int k = 1; k <= n; k++)
            {
                l *= k;
            }
            Console.WriteLine(l);
            Console.WriteLine();

            Console.WriteLine("№4"); 
            int m = Convert.ToInt32(Console.ReadLine());
            for (int p = 2; p <= m; p++)
            {
                if (m % p == 0)
                {
                    Console.WriteLine(p);
                }
            }
        }
    }
}