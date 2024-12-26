namespace Operators_Practice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 2;
            var c = 3;

            Console.WriteLine(a > b); // False
            Console.WriteLine(a < b); // True
            Console.WriteLine(a >= b); // False
            Console.WriteLine(a <= b); // True
            Console.WriteLine(a == b); // False
            Console.WriteLine(a != b); // True
            Console.WriteLine(!(a != b)); // False
            Console.WriteLine(c > b && c > a); // True
            Console.WriteLine(c > b && c == a); // False    
            Console.WriteLine(c > b || c == a); // True
            Console.WriteLine(!(c > b || c == a)); // False

        }
    }
}
