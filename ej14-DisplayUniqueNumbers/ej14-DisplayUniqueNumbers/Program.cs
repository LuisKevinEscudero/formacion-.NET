/*
Write a program and ask the user to continously 
enter a number or type "Quit" to exit. The list 
of numbers may include duplicates. Display the 
unique numbers that the user has entered. 
 */

namespace DisplayUniqueNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter a number or type 'Quit' to exit: ");
                var input = Console.ReadLine();
                input = input.ToLower();
                if (input == "quit")
                    break;
                numbers.Add(Convert.ToInt32(input));
            }
            var uniqueNumbers = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniqueNumbers.Contains(number))
                    uniqueNumbers.Add(number);
            }
            Console.WriteLine("Unique numbers: ");
            foreach (var number in uniqueNumbers)
                Console.WriteLine(number);
        }
    }
}