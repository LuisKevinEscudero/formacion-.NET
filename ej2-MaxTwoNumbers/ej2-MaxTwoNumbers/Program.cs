/*
 Write a program which takes two numbers from the console and displays the maximum of the two.
 */
namespace MaxTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string a;
                string b;
                int max;

                Console.WriteLine("Enter first number: ");
                a = Console.ReadLine();

                Console.WriteLine("Enter second number: ");
                b = Console.ReadLine();

                if (Convert.ToInt32(a) == Convert.ToInt32(b))
                {
                    Console.WriteLine("Both numbers are equal");
                }
                else
                {
                    if (Convert.ToInt32(a) > Convert.ToInt32(b))
                    {
                        max = Convert.ToInt32(a);
                    }
                    else
                    {
                        max = Convert.ToInt32(b);
                    }

                    Console.WriteLine("Max of {0} and {1} is {2}", a, b, max);
                }
                
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a valid number");
            }
            

        }
    }
}