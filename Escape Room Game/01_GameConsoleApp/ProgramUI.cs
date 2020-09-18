using _02_GameLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _01_GameConsoleApp
{
    public class ProgramUI
    {
        private Game_Repo _playerPocket = new Game_Repo();
        public void Run()      // creating the entry
        {
            GameContent();
        }
        public void GameContent()
        {   // create player name
            Console.WriteLine("Welcome player! What is your name?");
            string playerName = Console.ReadLine();     // make sure to keep using playerName in PlayerClass and PlayerRepo. Add capitol first letter?
            Console.Clear();
            // intro
            Console.WriteLine($"{playerName}, you just woke up in this strange room. You don't know where you are but\n" +
                "what's important is that you find a way to escape. Search the room for things to help\n" +
                $"you break out. Type a number to choose a senario for the path you will take. Good luck {playerName}.\n");
            // call the first menu
            //void FirstMenu() ** didn't work the way I wanted to.. 
            //{
                bool keepRunning = true;
                while (keepRunning)
                {
                    Console.WriteLine
                        ("1) Open the door\n" +
                        "2) Open the window\n" +
                        "3) Open the box\n" +
                        "4) Scream for help\n" +
                        "5) Inspect the floorboards");

                    // Get the user's input
                    string input = Console.ReadLine();
                    // Evaluate the user's input and act accordingly
                    switch (input)
                    {
                        case "1": // run open window method()
                            Console.Clear();
                            Console.WriteLine("You jiggle the handle but door is locked. \n Please try again... \n");
                            
                        break;
                        case "2": // run open window method()
                            Console.Clear();
                            Console.WriteLine("You try opening the window but notice it's nailed shut. \n Please try again... \n");
                            break;
                        case "3":
                            Console.Clear();
                            Console.WriteLine("The dusty box in the corner has magazines inside. \n Please try again... \n");
                            break;
                        case "4":
                            Console.Clear();
                            Console.WriteLine("You scream until your throat hurts but no one responds. \n Please try again... \n");
                            break;
                        case "5":
                            CaseOneFive();
                            keepRunning = false;
                            break;
                        default:
                            Console.WriteLine("Please enter a valid number in order to continue the story. \n");
                            break;
                    }
                    
                    //Console.WriteLine("Please try again");
                    //Console.ReadLine();
                }
            //}
        }


        public void CaseOneFive()
        {
            Console.Clear();
            Console.WriteLine("Scrutinizing the floor, you notice some boards of wood are bent and loose. Prying one up,\n" +
                    "you find a key underneath. The key is now in your pocket. Press enter to continue.\n");
            CaseTwoFour();
            Console.ReadLine();
            

            // couldnt we essentially add another switch case here to move the story forward or ultimately end the game?
        }
        public void CaseTwoFour()
        {
            //
            //Console.Clear();
            Console.WriteLine("You take the key to the door and unlock it... good job.\n");
            Console.ReadLine();


            // couldnt we essentially add another switch case here to move the story forward or ultimately end the game?
        }

    }
}