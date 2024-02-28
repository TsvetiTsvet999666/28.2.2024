using System.Buffers;

namespace SortNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {-9, 2, 4 }; 
            Array.Sort(numbers); 
            Console.WriteLine(string.Join("<= ", numbers));
        }
    }
}
