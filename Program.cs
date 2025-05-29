using System;
using System.IO;
using System.Linq.Expressions;

namespace PrefetchCleanup
{

    public class Cleanup
    {

        public static void Main(string[] args)
        {

            string? userchoice, userchoice2;
            string Yes = "Yes";
            string No = "No";

            Console.WriteLine("Would you like to wipe your Prefetch folder? Enter 'Yes' to Wipe.\n");
            userchoice = Console.ReadLine();

            if (userchoice == Yes)
            {

                Console.WriteLine("Cleaning...\n");

                string[] filePaths = Directory.GetFiles("C:\\Windows\\prefetch");

                foreach
                (string filePath in filePaths)
                    File.Delete(filePath);


            }

            Console.WriteLine("Would you also like to Delete files in your Recycle Bin? Enter 'Yes' again.");
            userchoice2 = Console.ReadLine();

            if (userchoice2 == Yes)
            {

                string[] Paths = Directory.GetFiles("C:\\$Recycle.Bin");

                foreach (string filePath in Paths)
                    File.Delete(filePath);

            if (userchoice2 == No)
                {

                    Console.WriteLine("Exiting...\n");

                }



                if (userchoice == No)
                {
                    Console.WriteLine("Exiting...\n");
                }
            }

        }

        }
    }