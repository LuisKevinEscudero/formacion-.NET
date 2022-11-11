/*
Write a program and ask the user to enter their name. 
Use an array to reverse the name and then store the 
result in a new string. Display the reversed name on the console. 
 */

namespace ReverseGivenName
{
	public class Programm
	{
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            var name = Console.ReadLine();
            var array = new char[name.Length];
            for (int i = 0; i < name.Length; i++)
            {
                array[i] = name[name.Length - 1 - i];
            }

            var reverse = "";
            for (int i = 0; i < array.Length; i++)
            {
                reverse += array[i];
            }
            Console.WriteLine(reverse);

        }
    }
}
