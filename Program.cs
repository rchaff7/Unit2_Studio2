using System;

namespace Studio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = System.IO.File.ReadAllText("TextFile1.txt");

            // Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.

            Console.WriteLine("Reading input from local text file:\n");
            CharCounter.CountInput(input);
        }
    }
}

//3.8.5.Bonus Missions
//Try these modifications on your code:
//    Prompt the user to enter the string in the command line.
//    Make the character counts case-insensitive.
//    Exclude non-alphabetic characters.

//3.8.5.1. Super Bonus
//Read the string in from a file.