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
        private Player01 _playerName = new Player01();
        public void Run()      // the entry point
        {
            GameContent();
        }
        public void GameContent()
        {   // create player name
            Console.WriteLine("Welcome player! What is your name?");
            _playerName.Player01Name = _playerPocket.GetPlayerName();

            Console.Clear();
            // intro
            Console.WriteLine($"{_playerName.Player01Name}, you just woke up in this strange room. You don't know where you are but\n" +
                "what's important is that you find a way to escape. Search the room for things to help\n" +
                $"you break out. Type a number to choose a senario for the path you will take. Good luck {_playerName.Player01Name}.\n");

            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine
                    ("1) Open the door\n" +
                    "2) Open the window\n" +
                    "3) Open the box on corner table\n" +
                    "4) Scream for help\n" +
                    "5) Inspect the floorboards");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("You jiggle the handle but door is locked. \n Please try again... \n");

                        break;
                    case "2":
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
                        KeyUnderFloor();
                        keepRunning = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please enter a valid number in order to continue the story. \n");
                        break;
                }
            }
        }

        public void KeyUnderFloor()
        {
            Console.Clear();
            Console.WriteLine("Scrutinizing the floor, you notice some boards of wood are bent and loose. Prying one up,\n" +
                    "you find a key underneath. The key is now in your pocket. Press enter to continue.\n");

            Console.ReadLine();
            KeyInPocket();
        }

        public void KeyInPocket()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine
                    ("1) Try the key in the door\n" +
                    "2) Keep looking around the room\n");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("The key doesn't fit. \n Probably another key would fit? Try another option.. \n");
                        break;
                    case "2":
                        Console.Clear();
                        PictureFrame();
                        keepRunning = false;
                        break;
                    
                    default:
                        Console.Clear();
                        Console.WriteLine("Please enter a valid number in order to continue the story. \n");
                        break;
                }
            }
        }

        public void PictureFrame()
        {
            Console.Clear();
            Console.WriteLine("You notice one of the picture frames on the wall is not level.\n" +
                "You go to inspect the frame and notice that there is a small safe behind it. \n");
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine       // keeps looping here forever!?!?
                    ("1) Try to force the safe open\n" +
                    "2) Enter a combination\n" +
                    "3) Go back to the box with magazines in it\n");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine($"{ _playerName.Player01Name} - If you can force open a safe you probably could just bust out of the room.\n" +
                            " - try another option... Press enter to continue. \n");
                        break;
                    case "2":
                        Console.Clear();
                        SafeCombination();
                        keepRunning = false;
                        break;
                    case "3":
                        Console.Clear();
                        GoBackToBox();
                        keepRunning = false;        //HERE IT IS!!! 
                        
                        break;
                    case "TK-421": //SKIP to the end
                        Console.Clear();
                        Console.WriteLine($"{_playerName.Player01Name} you WIN!!! aghagahga");
                        Console.ReadLine();
                        keepRunning = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please enter a valid number in order to continue the story. \n");
                        break;
                }
                Console.ReadLine();
            }
        }

        public void SafeCombination()
        {
            Console.WriteLine("Enter the combination");
            string input = Console.ReadLine();

            switch (input)
            {
                case "421":
                case "4-2-1":
                case "four two one":
                case "Four Two One":
                    Console.WriteLine("You spin the dial back and forth carefully entering 4-2-1, you hear a click and turn the handle. \n" +
                        "inside is a large key, you put this key into your pocket. \n");
                    KeyInHand();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("You spin the dial back and forth entering what you think is the combination... \n" +
                        "you turn the handle and it doesn't budge. Press enter to continue. \n");
                    Console.ReadLine();
                    PictureFrame();
                    break;
            }
        }

        public void KeyInHand()
        {
            Console.Clear();
            Console.WriteLine("Upon opening the safe you find an old fashioned key. It's rusty but it fits perfectly in the door's keyhole.\n" +
                "To your relief there are no other locks or chains keeping the door bolted.\n" +
                "You take off in a sprint down the hall and exit the building.\n" +
                "\n" +
                $"Congratulations {_playerName.Player01Name} ! You escaped!\n");
            Console.ReadLine();
        }

        public void GoBackToBox()
        {
            Console.Clear();
            Console.WriteLine("You open the dusty box with a few old magazines in it. \n" +
                "You thumb through the magazines find nothing intresting and set them all on the table. \n" +
                "You look back into the box and at the bottom you find a small diary with small lock on the side\n");
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine(
                    "1) Try to open the diary\n" +
                    "2) Ignore the diary - it's private information and it isn't right to open it.\n" +
                    "3) Eat the small key\n");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.Clear();
                        OpenDiary();
                        keepRunning = false;
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("You take a moment to sit on the floor and close your eyes. After clearing your mind you realize maybe\n" +
                            "there might be something very important in the diary to help you escape ...\n");
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("You don't know how long you've been trapped in this room but you are certainly\n" +
                            "hungry and a bit delusional. You swallow the small key and -- CHOKE!!!\n" +
                            $"Thankfully you spit up the key. You could have died!\n" +
                            $"Try something else, {_playerName.Player01Name}.\n");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please enter a valid number in order to continue the story. \n");
                        break;

                }
            }
        }

        void OpenDiary()
        {
            Console.Clear();
            Console.WriteLine("You use the key to open the diary... \n" +
                "All the pages are blank except for one... in blood you find written \n" +
                "       Four    Two     One \n" +
                "You think to yourself that these numbers might be used somewhere... Press enter to contiune.");
            Console.ReadLine();
            Console.Clear();
            bool keepRunning = true;
            while (keepRunning) 
            {
            Console.WriteLine(
                    "1) Go back to the safe behind the picture frame.\n" +
                    "2) Ignore the diary - that was super creepy.\n" +
                    "3) Take a nap. You've earned some rest. \n");

            string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.Clear();
                        SafeCombination();
                        keepRunning = false;
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine($"Snap out of it {_playerName.Player01Name} - you've got to get out! \n");
                        
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine($"This isn't the time for a nap {_playerName.Player01Name} - you've got to get free! \n");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please enter a valid number in order to continue the story. \n");
                        break;
                }

            }
        }
    }


}