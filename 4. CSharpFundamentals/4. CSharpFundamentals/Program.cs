using _4._CSharpFundamentals.Math;

namespace CSharpFundamentals
{

    public class Class1
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.FirstName = "John";
            person.LastName = "Smith";
            person.Introduce();

            Calculator calc = new Calculator();

            var result = calc.Add(1, 2);
            Console.WriteLine(result);

        }
    }
}


