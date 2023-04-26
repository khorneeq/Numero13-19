namespace Numero13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Numero 13");
            Console.WriteLine(OptimalTemp(120, -1));
            Console.WriteLine(OptimalTemp(-1, 120));
            Console.WriteLine(OptimalTemp(2, 120));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Numero 14");
            Console.WriteLine(InRange(100, 199));
            Console.WriteLine(InRange(250, 300));
            Console.WriteLine(InRange(105, 190));

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Numero 15");
            Console.WriteLine(TripleRange(11, 20, 12));
            Console.WriteLine(TripleRange(30, 30, 17));
            Console.WriteLine(TripleRange(25, 35, 50));
            Console.WriteLine(TripleRange(15, 12, 8));

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Numero 16");
            Console.WriteLine(Check(20, 84));
            Console.WriteLine(Check(14, 15));
            Console.WriteLine(Check(11, 45));
            Console.WriteLine(Check(25, 40));

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Numero 18");
            Console.WriteLine(TheLargest(1, 2, 3));
            Console.WriteLine(TheLargest(1, 3, 2));
            Console.WriteLine(TheLargest(1, 1, 1));
            Console.WriteLine(TheLargest(1, 2, 2));

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Numero 19");
            Console.WriteLine(Closer(78,95));
            Console.WriteLine(Closer(95,95));
            Console.WriteLine(Closer(99,70));

        }
        public static bool OptimalTemp(int x, int y)
        {
            if (((x < 0) && (y > 100)) || ((y < 0) && (x > 100))) return true;
            return false;
        }

        public static bool InRange(int x, int y)
        {
            if ((100 < x && x < 200) || (100 < y && y < 200)) return true;
            return false;
        }

        static bool TripleRange(int x, int y, int z)
        {
            if (20 <= x && x <= 50)
            {
                return true;
            }
            else if (20 <= y && y <= 50)
            {
                return true;
            }
            else if (20 <= z && z <= 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool Check(int x, int y)
        {
            return (x <= 20 && x <= 50) || (y <= 20 && y <= 50);
        }
        static int TheLargest(int x, int y, int z)
        {
            if (x > y && x > z)
            {
                return x;
            }
            else if (y > x && y > z)
            {
                return y;
            }
            else
            {
                return z;
            }
        }
        static int Closer(int x, int y)
        {
            if (Math.Abs(100 - x) < Math.Abs(100 - y))
            {
                return x;
            }
            else if (Math.Abs(100 - x) > Math.Abs(100 - y))
            {
                return y;
            }
            else
            {
                return 0;
            }
        }

    }
}
