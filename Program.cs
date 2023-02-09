





namespace Lesson
{
    class program
    {
        public static void Main(string[] args)
        {
            int a = 1, b = 5;

            Console.WriteLine($"a = {a}\t b = {b}");

            Swap(ref a, ref b);

            Console.WriteLine($"a = {a}\t b = {b}");
        }

        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        
    }
}