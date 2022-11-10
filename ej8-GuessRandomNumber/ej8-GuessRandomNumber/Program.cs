/*
Write a program that picks a random number between 1 and 10. 
Give the user 4 chances to guess the number. 
If the user guesses the number, display “You won"; 
otherwise, display “You lost". 
(To make sure the program is behaving correctly, 
you can display the secret number on the console first).
 */

using System.Net.Mail;

namespace GuessRandomNumber
{
	public class Programm
	{
		static void Main(string[] args)
		{
			try
			{
                var random = new Random();
                int r = random.Next(1, 11);
                var looser = true;

                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine("pick a number beetween 1 - 10");
                    var n = Convert.ToInt32(Console.ReadLine());
                    if (n == r)
                    {
                        Console.WriteLine("you win");
                        looser = false;
                        break;
                    }
                }
                if (looser)
                {
                    Console.WriteLine("you looser, the number is " + r);
                }
            }
			catch (Exception)
			{
                Console.WriteLine("please enter a valid number");
			}
			
			
        }
    }
}