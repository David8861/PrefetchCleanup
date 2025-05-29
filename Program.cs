namespace PrefetchCleanup
{

    public class Cleanup // Defines a public project class 
    {
        public static void Main(string[] args)
        {
            ArgumentNullException.ThrowIfNull(args); //Exception inititated, if Main args fail

            /* Strings for user input, and for defining 'Yes' or 'No; inputs */
            string? userchoice, userchoice2;

            /* Force text color to appear white in console */
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Prefetch Cleaner.");
            Console.WriteLine("David Amato. All Rights Reserved.\n");

            /* If the user inputs "Yes", the program will begin */
            Console.WriteLine("Would you like to permanently delete all files in your Prefetch folder? Enter 'Yes' to Wipe.\n");
            userchoice = Console.ReadLine(); // Collects user's response

            if (userchoice == "Yes")
            {

                Console.WriteLine("Enter 'y' to confirm.\n");
                userchoice2 = Console.ReadLine();

                // Collects user's second response, for confirmation to run cleanup
                if (userchoice2 == "y")
                {
                    Console.WriteLine("Cleaning...\n");

                    string[] filePaths = Directory.GetFiles("C:\\Windows\\Prefetch");
                    // Defines a filepath, and grabs files from indicated location

                    // For each string file in the chosen directory, delete it from that directory
                    foreach
                    (string filePath in filePaths)
                        File.Delete(filePath);

                    Console.WriteLine("Done. Press any key to exit...\n");
                    Console.ReadLine();
                    // Waits for user input to exit
                }
         
                else if (userchoice2 == "n")
                {
                    Console.WriteLine("Press any key to exit...\n");
                    Console.ReadLine();
                    // Waits for user input to exit
                }


            }

            if (userchoice == "No") // Exits program if user inputs "No"
            {
                Console.WriteLine("Press any key to exit...\n");
                Console.ReadLine();
                // Waits for user input to exit
            }
        }

    }

}