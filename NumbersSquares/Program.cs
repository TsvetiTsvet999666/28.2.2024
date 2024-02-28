namespace NumbersSquares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a list of integers separated by spaces!!  :");
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');

            List<int> nums = new List<int>();
            foreach (var part in parts)
            {
                nums.Add(int.Parse(part));
            }
            List<int> squareNums = new List<int>();
            foreach (var num in nums)
            {
                double squareRoot = Math.Sqrt(num);
                if (squareRoot == (int)squareRoot)
                {
                    squareNums.Add(num);
                }
            }
            squareNums.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine("Numbers of squares in descending order!!  :");
            foreach (var num in squareNums)
            {
                Console.Write(num + " ");
            }
        }
    }
}
