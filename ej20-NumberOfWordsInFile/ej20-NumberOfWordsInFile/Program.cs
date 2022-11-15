/*
Write a program that reads a text file and displays the number of words. 
 */

namespace NumbersOfWordsInFile
{
	public class Programm
	{
		static void Main(string[] args)
		{
            string text = System.IO.File.ReadAllText(@"C:\Users\luiskevin.escudero\Desktop\formacion .NET/words.txt");
            int wordCount = 0, index = 0;

            // skip whitespace until first word
            while (index < text.Length && char.IsWhiteSpace(text[index]))
                index++;

            while (index < text.Length)
            {
                // check if current char is part of a word
                while (index < text.Length && !char.IsWhiteSpace(text[index]))
                    index++;

                wordCount++;

                // skip whitespace until next word
                while (index < text.Length && char.IsWhiteSpace(text[index]))
                    index++;
            }
            Console.WriteLine("the text are: "+text);
            Console.WriteLine("Number of words: " + wordCount);
        }
    
	}
}

















/*
string text = System.IO.File.ReadAllText(@"C:\Users\Public\TestFolder\WriteText.txt");
            int wordCount = 0, index = 0;

            // skip whitespace until first word
            while (index < text.Length && char.IsWhiteSpace(text[index]))
                index++;

            while (index < text.Length)
            {
                // check if current char is part of a word
                while (index < text.Length && !char.IsWhiteSpace(text[index]))
                    index++;

                wordCount++;

                // skip whitespace until next word
                while (index < text.Length && char.IsWhiteSpace(text[index]))
                    index++;
            }

            Console.WriteLine("Number of words: " + wordCount);
            Console.ReadKey(); 
 */