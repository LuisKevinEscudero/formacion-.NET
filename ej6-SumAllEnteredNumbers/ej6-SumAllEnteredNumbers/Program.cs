/*
Write a program and continuously ask the user to enter a number or "ok" to exit. 
Calculate the sum of all the previously entered numbers and display it on the console.
 */

namespace SummAllEnteredNumbers
{
	public class Class1
	{
		static void Main(string[] args)
		{
			try
			{
				int sum = 0;
				Console.WriteLine("enter a number or 'ok' to exit");
				var read = Console.ReadLine();
				while(!read.Equals("ok"))
				{
					sum = sum + Convert.ToInt32(read);
					Console.WriteLine("enter a number or 'ok' to exit");
					read= Console.ReadLine();
				}
				Console.WriteLine("the whole sum is: "+sum);
				
			}
			catch (Exception)
			{
				Console.WriteLine("Error");
			}
		}
	}
}