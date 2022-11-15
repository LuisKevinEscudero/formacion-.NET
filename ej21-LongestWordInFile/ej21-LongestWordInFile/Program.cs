/*
Write a program that reads a file and displays the longest word in the file. 
 */
namespace LongestWordInFile
{
	public class Programm
	{
        static void Main(string[] args)
        {
            string path = @"C:\Users\luiskevin.escudero\Desktop\formacion .NET/words.txt";
            string[] lines = File.ReadAllLines(path);
            string longestWord = "";
            foreach (string line in lines)
            {
                string[] words = line.Split(' ');
                foreach (string word in words)
                {
                    if (word.Length > longestWord.Length)
                    {
                        longestWord = word;
                    }
                }
            }
            Console.WriteLine("Longest word: " + longestWord);
        }
    }
}