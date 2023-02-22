using System;


namespace LogicalExpressions
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("1) Negative XOR");
            bool b = true;
            int h = 180;
            char hc = 'b';
            if (h >= 180 ^ hc == 'b')
            {
                Console.WriteLine($"XOR: {b}");
            }
            else
            {
                Console.WriteLine($"XOR: {!b}");
            }

            for (int i = 0; i < 3; i++)
            {
                {
                    Console.WriteLine("-----------------");
                }
            }
            Console.WriteLine("2)");
            bool isOk = h >= 180 & hc == 'b';
            bool negOk = h < 180 & hc != 'c';
            Console.WriteLine($"Negative and: {negOk}");
            bool or = h >= 180 || hc == 'c';
            Console.WriteLine($"OR: {or}");
            bool and = h > 180 && hc == 'c';
            Console.WriteLine($"And: {and}");


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("-----------------");
            }
            Console.WriteLine("3)");
            if (h >= 180 && hc != 'b')
            {
                Console.WriteLine("Tall or brunette");
            }
            else if (h < 180 && hc == 'b')
            {
                Console.WriteLine("Tall or brunette");
            }
            else
            {
                Console.WriteLine("Both");
            }
            Console.WriteLine("Using OR");
            if (h < 180 || hc != 'b')
            {
                Console.WriteLine("Not tall and brunette at the same time");
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("-----------------");
            }
            Console.WriteLine("4,5)");
            bool H = true;
            Console.WriteLine($"OR | H | H ");
            Console.WriteLine($" | {H | H} | {H | H,0} ");
            Console.WriteLine($" | {H | H,1} | {H | !H} ");
            Console.WriteLine();
            Console.WriteLine($"AND | H & H ");
            Console.WriteLine($" | {H & H} | {H & H,0} ");
            Console.WriteLine($" | {H & H,1} | {H&!H} ");
        }
    }
}