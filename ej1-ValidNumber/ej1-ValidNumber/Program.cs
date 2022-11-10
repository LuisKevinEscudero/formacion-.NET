/*
 Write a program and ask the user to enter a number. 
The number should be between 1 to 10. If the user 
enters a valid number, display "Valid" on the console. 
Otherwise, display "Invalid". (This logic is used a 
lot in applications where values entered into input 
boxes need to be validated).
 */

namespace ValidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number between 1 and 10: ");
                string input = Console.ReadLine();
                int number;

                int result = Convert.ToInt32(input);
                if (result >= 1 && result <= 10 )
                {
                    Console.WriteLine("Valid");
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid");
            }
            
        }
    }
}