/*
Write a program and ask the user to enter a few numbers separated by a hyphen. 
If the user simply presses ENTER, without supplying any input, exit immediately;
otherwise, check to see if there are dulicates. If so, display "Duplicate" on the console. 
 */

namespace FindDuplicate
{
	public class Programm
	{
		static void Main(string[] args)
		{
			try
			{
                Console.WriteLine("Enter a few numbers separated by a hyphen: ");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                    return;

                var numbers = new List<int>();
                foreach (var number in input.Split("-"))
                {
                    numbers.Add(Convert.ToInt32(number));
                }

                var uniques = new List<int>();
                foreach (var num in numbers)
                {
                    if (!uniques.Contains(num))
                        uniques.Add(num);
                }
                if (uniques.Count == numbers.Count)
                {
                    Console.WriteLine("No duplicates, the numbers are: ");
                    foreach (var num in numbers)
                    {
                        Console.WriteLine(num);
                    }
                }
                else
                {
                    Console.WriteLine("Duplicate");
                    Console.WriteLine("the number(s) duplicate are: ");
                    foreach (var num in numbers)
                    {
                        if (uniques.Contains(num))
                        {
                            uniques.Remove(num);
                        }
                        else
                        {
                            Console.WriteLine(num);
                        }
                    }
                }
            }
			catch (Exception)
			{
                Console.WriteLine("Error");
			}
        }
	}
}