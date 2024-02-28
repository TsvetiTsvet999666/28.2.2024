namespace NumberOfNumbers
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
            nums.Sort();
            int count = 1;
            for (int i = 0; i < nums.Count; i++)
            {
                if (i < nums.Count - 1 && nums[i] == nums[i + 1])
                {
                    count++;
                }
                else
                {
                    Console.WriteLine($"{nums[i]} -> {count}");
                    count = 1; 
                }
            }
        }
    }
}
