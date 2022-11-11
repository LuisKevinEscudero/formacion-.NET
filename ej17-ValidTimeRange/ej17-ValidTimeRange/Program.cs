/*
Write a program and ask the user to enter a time 
value in the 24 hour time format (e.g. 19:00). 
A valid time should be between 00:00 and 23:59. 
If the time is valid, display "Ok"; otherwise, 
display "Invalid Time". IF the user doesn't provide 
any values, consider it as invalid time. 
 */

namespace ValidTimeRange
{
	public class Programm
	{
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a time value in the 24 hour time format (e.g. 19:00): ");
                var input = Console.ReadLine();
                if (input.Length != 5)
                {
                    Console.WriteLine("Invalid Time");
                    return;
                }

                var firstNum = input.Substring(0, 2);
                var secondNum = input.Substring(3, 2);

                var num1 = Convert.ToInt32(firstNum);
                var num2 = Convert.ToInt32(secondNum);

                if (num1 >= 0 && num1 <= 23 && num2 >= 0 && num2 <= 59)
                {
                    Console.WriteLine("Ok, the hour {0}:{1} is between 00:00 and 23:59", num1, num2);

                }
                else
                {
                    Console.WriteLine("Invalid Time");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Enter a valid hour");
            }
        }
    }
}




























/*
Console.WriteLine("Enter a time value in the 24 hour time format (e.g. 19:00): ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            var components = input.Split(':');
            if (components.Length != 2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            try
            {
                var hour = Convert.ToInt32(components[0]);
                var minute = Convert.ToInt32(components[1]);

                if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                    Console.WriteLine("Ok");
                else
                    Console.WriteLine("Invalid Time");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Time");
            } 
 */