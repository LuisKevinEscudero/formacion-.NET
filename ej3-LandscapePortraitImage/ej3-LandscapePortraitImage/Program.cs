/*
 Write a program and ask the user to enter the width and height of an image. 
Then tell if the image is landscape or portrait.
 */
namespace LandscapePortraitImage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the image width: ");
                int width = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the image height: ");
                int height = Convert.ToInt32(Console.ReadLine());

                if (width > height)
                {
                    Console.WriteLine("The image is landscape");
                }
                else if (width < height)
                {
                    Console.WriteLine("The image is portrait");
                }
                else
                {
                    Console.WriteLine("The image is square");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
            
        }
    }
}