/*
Write a program to count how many numbers between 
1 and 100 are divisible by 3 with no remainder. 
Display the count on the console.
 */

namespace DivisibleByThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int count=0;

            for(int i=0;i<100;i++)
            {
                if(i % 3 ==0)
                {
                    count++;
                    Console.WriteLine("{0} is divisible by 3",i);
                }
                
            }
            Console.WriteLine("************");
            Console.WriteLine("{0} are divible by 3 in 0-100", count);
        }
    }
}