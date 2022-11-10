/*
 Write a program and ask the user to enter a series of 
numbers separated by comma. Find the maximum of the 
numbers and display it on the console. For example, 
if the user enters “5, 3, 8, 1, 4", the program should display 8.
 */

namespace FindMaxFromList
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a series of numbers separated by comma: ");
                var input = Console.ReadLine();

                var numbers = input.Split(',');
                var max = Convert.ToInt32(numbers[0]);

                foreach (var number in numbers)
                {
                    var numberInt = Convert.ToInt32(number);
                    if (numberInt > max)
                        max = numberInt;
                }

                Console.WriteLine("Max is " + max);
            }
            catch (Exception)
            {
                Console.WriteLine("Enter correct input");
            }
            
        }
    }
}