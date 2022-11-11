/*
Write a program and ask the user to enter a few numbers separated by a hyphon. 
Workout if the numbers are consecutive. For example, if the input is "5-6-7-8-9" 
or "20-19-17-16", display a message: "Consecutive"; otherwise, display "Not-Consecutive".
 */

namespace ConsecutiveNumbers
{
	public class Programm
	{
		static void Main(string[] args)
		{
			try
			{
                Console.WriteLine("Enter a few numbers separated by a hyphon: ");
                var input = Console.ReadLine();
                var numbers = new List<int>();
                foreach (var number in input.Split('-'))
                    numbers.Add(Convert.ToInt32(number));
                numbers.Sort();
                var isConsecutive = true;
                for (var i = 1; i < numbers.Count; i++)
                {
                    if (numbers[i] != numbers[i - 1] + 1)
                    {
                        isConsecutive = false;
                        break;
                    }
                }
                var message = isConsecutive ? "Consecutive" : "Not-Consecutive";
                Console.WriteLine(message);
            }
			catch (Exception)
			{
                Console.WriteLine("Error");
            }
        }
	}
}


