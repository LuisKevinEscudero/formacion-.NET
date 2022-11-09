namespace MyNamespace
{
    class MyClass
    {
        static void Main(string[] args)
        {
            var firsName = "John";
            var lastName = "Doe";

            var fullName = firsName + " " + lastName;
            var myFullName = string.Format("My name is {0} {1}", firsName, lastName);

            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            var text = "Hi John\nlook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            var text1 = @"Hi John
look into the following paths
c:\folder1\folder2
c:\folder3\folder4";

            Console.WriteLine(text);
            Console.WriteLine(text1);
        }
    }

} 