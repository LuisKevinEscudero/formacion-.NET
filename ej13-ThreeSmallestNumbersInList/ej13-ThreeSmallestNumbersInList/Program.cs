/*
Write a pgram and ask the user to supply a 
list of coma separated numbers (e.g. 5, 1, 9, 2, 10). 
If the list is empty or includes less than 5 numbers, 
disply "Invalid List" and ask the user to re-try; 
otherwise, display the 3 smallest numbers in the list. 
 */

using System.Collections.Immutable;

namespace ThreeSmallestNumbersInList
{
	public class Programm
	{
		static void Main(string[] args)
		{
			try
			{
                Console.WriteLine("Enter a list of coma separated numbers (ej: 5, 1, 9, 2, 10): ");
                var input = Console.ReadLine();

                var numbers = input.Split(',');

                if (numbers.Length < 5)
                {
                    Console.WriteLine("Invalid List");
                    return;
                }

                if (!numbers.Any())
                {
                    Console.WriteLine("you must enter at least one number");
                    return;
                }

                numbers.ToList();
                var listNumber = new List<int>();
                foreach (var number in numbers)
                {
                    listNumber.Add(Convert.ToInt32(number));
                }

                listNumber.Sort();

                Console.WriteLine("three smallets numbers: ");
                Console.WriteLine(listNumber[0]);
                Console.WriteLine(listNumber[1]);
                Console.WriteLine(listNumber[2]);
            }
			catch (Exception)
			{
                Console.WriteLine("enter a valid list");
			}
        }
	}
}