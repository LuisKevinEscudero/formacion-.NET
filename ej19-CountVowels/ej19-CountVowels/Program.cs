/*
 Write a program and ask it to enter an English word. 
Count the nunber of vowels (a, e, i, o, u) in the word. 
So, if the user enters "inadequate", the program should 
display 6 in the console.
 */

namespace CountVowels
{
	public class Programm
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Enter a word: ");
            var input = Console.ReadLine().ToLower();
			int count = 0;
			for (int i = 0; i < input.Length; i++)
			{
				if (input[i].Equals('a') || input[i].Equals('e') || input[i].Equals('i') || input[i].Equals('o') || input[i].Equals('u'))
				{
					count++;
				}
			}
			Console.WriteLine("The number of vowels are: "+count);
        }
	}
}