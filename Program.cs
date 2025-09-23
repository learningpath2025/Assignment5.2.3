namespace Assignment5._2._3
{
    internal class Program
    {
        static int ln;
        static void Main(string[] args)
        {
            GetInput();
            PrintNumbers();
            //PrintNumbers1(ln);
        }

        public static void GetInput()
        {
            Console.Write("How many numbers to print: ");
            ln = Convert.ToInt32(Console.ReadLine());
        }

        public static void PrintNumbers()
        {
            if (ln > 0)
            {
                Console.Write(ln + " ");
                ln--;
                PrintNumbers();
            }
        }

        //Stack winding and unwinding using recursion
        public static void PrintNumbers1(int x)
        {
            if (x <= 0) return;
            Console.Write($"{x} ");
            PrintNumbers1(x - 1);
        }

    }
}
