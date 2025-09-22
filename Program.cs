namespace Assignment5._2._3
{
    internal class Program
    {
        static int ln;
        static void Main(string[] args)
        {
            GetInput();
            PrintNumbers();
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

    }
}
