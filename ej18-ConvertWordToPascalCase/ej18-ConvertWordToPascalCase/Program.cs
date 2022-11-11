/*
Write a program and ask the user to enter a few words separated by a space. 
Ue the words to create a variable name with PascalCase. 
For example, if the user types: "number of students", 
display "NumberOfStudents". Make sure that the program 
is not dependent on the input. So, if the user types 
"NUMBER OF STUDENTS", the program should still display "NumberOfStudents". 
 */

namespace ConverWordToPascalCase
{
	public class Programm
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Enter a few words separated by a space: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("no words enter");
                return;
            }
            List<string> words = new List<string>();
            foreach (var word in input.Split(' '))
            {
                words.Add(word.ToLower().Trim());
            }
            string pascalCase = "";
            foreach (var word in words)
            {
                pascalCase = pascalCase + char.ToUpper(word[0]) + word.Substring(1);
            }
            Console.WriteLine("the words in PascalCase is: " + pascalCase);

        }
    
	}
}