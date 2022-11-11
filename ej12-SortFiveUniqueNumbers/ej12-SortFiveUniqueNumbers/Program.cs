/*
Write a program and ask the user to enter 5 numbers. 
If a number has been previously entered, 
display an error message and ask the user to re-try. 
Once the user succesfully enters 5 unique numbers, 
sort them and display the result on the console. 
 */

namespace SortFiveUniqueNumbers
{
	public class Programm
	{
        static void Main(string[] args)
        {
			try
			{
                var numbers = new List<int>();
                while (numbers.Count < 5)
                {
                    Console.WriteLine("Enter a number: ");
                    var number = Convert.ToInt32(Console.ReadLine());
                    if (numbers.Contains(number))
                    {
                        Console.WriteLine("You've already entered " + number);
                    }
                    else
                    {
                        numbers.Add(number);
                    }
                }
                Console.WriteLine("The numbers you entered are: ");
                numbers.Sort();
                foreach (var number in numbers)
                {
                    Console.WriteLine(number);
                }
            }
			catch (Exception)
			{
                Console.WriteLine("An error occured. Please try again.");
            }
        }
    }
}
