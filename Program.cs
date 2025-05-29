using System;
using System.IO;
using System.Linq.Expressions;

namespace PrefetchCleanup
{

    public class Cleanup
    {

        public static void Main(string[] args)
        {

            string? userchoice;
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

            if (userchoice == No)
            {
                Console.WriteLine("Exiting...\n");
            }
        }



        }
    }