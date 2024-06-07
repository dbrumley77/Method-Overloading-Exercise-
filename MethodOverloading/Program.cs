namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(5, 6));
            Console.WriteLine(Add(7.52, 8.62));
            Console.WriteLine(Add(11, 12, true));
            Console.WriteLine(Add(24, 12, false));

        }

        public static int Add(int x, int y)
        {

            return x + y;
        }

        public static double Add(double x, double y)
        {
            return (double)x + y;
        }

        public static string Add(int x, int y, bool isTrue)
        {
            if (isTrue)
            {
                return ((x + y) > 1) ? x + y + " dollars" : "1 dollar";
            }
            return $"{x + y}";
        }


    }
}
