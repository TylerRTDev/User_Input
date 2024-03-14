using System.Diagnostics;

namespace UserInput.String
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string? readResult;
            bool validEntry = false;
            string? tryAgain;
            bool enterAgain = true;
            Console.WriteLine("Enter a word that contains at least 3 characters.");

            /*
             * User will input a string that has more than
             * 3 characters and will then ask if you want to
             * try again by entering yes or no (console will
             * close if no).
             */

            do
            {
                //Taking user input
                readResult = Console.ReadLine();

                if (readResult != null)
                {
                    //evaluate string length
                    if (readResult.Length >= 3)
                    {
                        validEntry = true;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid input, please try again\n");
                    }
                }

                Console.WriteLine("To try again enter:\tyes or no");

                tryAgain = Console.ReadLine();

                if (tryAgain == "yes")
                {
                    enterAgain = true;
                    Console.WriteLine("Enter a word that contains at least 3 characters.\n");
                }
                else
                {
                    Console.WriteLine("Goodbye.");
                }
                Environment.Exit(0);

            } while (enterAgain == true);

        }
    }
}