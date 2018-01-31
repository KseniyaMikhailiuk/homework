using System;

namespace MagiciansAgainstWarriorsGame
{
    class Program
    {

        static void gameProcessWarrior(Warrior warrior)
        {
            bool isExitKeyPressed = false;
            while (!isExitKeyPressed)
            {
                Console.WriteLine("Select action. 1 - make a step. 2 - jump. 3 - sit down. 4 - hit with sword. 5 - exit.");
                string pressedKey = Console.ReadLine();
                switch (pressedKey)
                {
                    case ("1"):
                        warrior.makeCharacterStep();
                        break;
                    case ("2"):
                        warrior.makeCharacterJump();
                        break;
                    case ("3"):
                        warrior.makeCharacterSitDown();
                        break;
                    case ("4"):
                        warrior.makeCharacterHitWithSword();
                        break;
                    case ("5"):
                        isExitKeyPressed = true;
                        break;
                    default:
                        Console.WriteLine("Something went wrong. Try again.");
                        break;
                }
            }
        }
        static void gameProcessMagician(Magician magician)
        {
            bool isExitKeyPressed = false;
            while (!isExitKeyPressed)
            {
                Console.WriteLine("Select action. 1 - make a step. 2 - jump. 3 - sit down. 4 - cast a spell. 5 - exit.");
                string pressedKey = Console.ReadLine();
                switch (pressedKey)
                {
                    case ("1"):
                        magician.makeCharacterStep();
                        break;
                    case ("2"):
                        magician.makeCharacterJump();
                        break;
                    case ("3"):
                        magician.makeCharacterSitDown();
                        break;
                    case ("4"):
                        magician.makeCharacterCastSpell();
                        break;
                    case ("5"):
                        isExitKeyPressed = true;
                        break;
                    default:
                        Console.WriteLine("Something went wrong. Try again.:)");
                        break;
                }


            }
        }

        static void Main(string[] args)
        {
             bool isKeyCorrect = false;
             while (!isKeyCorrect)
             {
                Console.WriteLine("Select a character. 1 - warrior. 2 - magician.");
                string pressedKey = Console.ReadLine();
                 switch (pressedKey)
                 {
                     case "1":
                         var warrior = new Warrior();
                         gameProcessWarrior(warrior);
                         isKeyCorrect = true;
                         break;
                     case "2":
                         var magician = new Magician();
                         gameProcessMagician(magician);
                         isKeyCorrect = true;
                         break;
                     default:
                         Console.WriteLine("Something went wrong. Try again.");
                         break;
                 }
             }

        }
    }
}
