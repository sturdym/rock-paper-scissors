using System;
using System.Linq.Expressions;
using System.Xml.Linq;

namespace rock_paper_scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors!");
            Console.WriteLine("");
            string userSelection = "a";
            string computerSelection = "b"; 
            string outputUserSelection = SetUserSelectionFromInput(userSelection);

            Console.WriteLine("You selected " + outputUserSelection + ".");
            string outputComputerSelection = SetComputerSelection(computerSelection);
            Console.WriteLine("The computer selected " + outputComputerSelection + ".");

            Console.WriteLine("");
            CompareUserAndComputerSelections(outputUserSelection, outputComputerSelection);

        }
        //User inputs their selection of either Rock or Paper or Scissors
        public static string SetUserSelectionFromInput (string userSelection)
        {
            Console.WriteLine("Please type your selection ('Rock' or 'Paper' or 'Scissors'):");
            userSelection = Console.ReadLine();
            return userSelection;
        }

        //The computer returns its selection of either Rock or Paper or Scissors
        public static string SetComputerSelection(string computerSelection)
        {
            int computerSelectionRandom = ComputerSelectionRandomNumber(0);
            List<string> computerSelectionList = ["Rock","Paper","Scissors"];
            computerSelection = computerSelectionList[computerSelectionRandom];
            return computerSelection;
        }
        //Random number between 0 and 2 is returned for the computer's random selection
        //of either Rock or Paper or Scissors
        public static int ComputerSelectionRandomNumber(int computerSelectionRandom)
        {
            Random random = new Random();
            int randomValue = random.Next(0, 3);
            computerSelectionRandom = randomValue;
            return computerSelectionRandom;
        }

        //Compare the values selected by the user and by the computer, and output who has won, or if it was draw
        public static string CompareUserAndComputerSelections(string outputUserSelection, string outputComputerSelection)
        {
            if (outputUserSelection == "Rock" && outputComputerSelection == "Scissors")
            {
                Console.WriteLine("Well Done!!! You have BEATEN the computer. Your Rock has SMASHED the Scissors!");
            }
            else if (outputUserSelection == "Scissors" && outputComputerSelection == "Paper")
            { Console.WriteLine("Well Done!!! You have BEATEN the computer. Your Scissors have CUT the Paper!"); }
            else if (outputUserSelection == "Paper" && outputComputerSelection == "Rock")
            { Console.WriteLine("Well Done!!! You have BEATEN the computer. Your Paper has WRAPPED the Rock!"); }
            else if (outputUserSelection == "Rock" && outputComputerSelection == "Paper")
            { Console.WriteLine("Sorry you LOST :(  Your Rock was WRAPPED in the computer's Paper!"); }
            else if (outputUserSelection == "Scissors" && outputComputerSelection == "Rock")
            { Console.WriteLine("Sorry you LOST :(  Your Scissors were SMASHED by the computer's Rock!"); }
            else if (outputUserSelection == "Paper" && outputComputerSelection == "Scissors")
            { Console.WriteLine("Sorry you LOST :(  Your Paper was CUT by the computer's Scissors!"); }
            else
            {
              Console.WriteLine("***It was a DRAW. Play again***");
              Console.WriteLine("");
              Console.WriteLine("Welcome to Rock, Paper, Scissors!");
              Console.WriteLine("");
              string userSelection = "a";
              string computerSelection = "b";
              outputUserSelection = SetUserSelectionFromInput(userSelection);

              Console.WriteLine("You selected " + outputUserSelection + ".");
              outputComputerSelection = SetComputerSelection(computerSelection);
              Console.WriteLine("The computer selected " + outputComputerSelection + ".");
              Console.WriteLine("");
              CompareUserAndComputerSelections(outputUserSelection, outputComputerSelection);
            }
            return outputUserSelection;
            }
        }
    }
