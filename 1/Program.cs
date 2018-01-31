using System;

namespace MagiciansAgainstWarriorsGame
{
    class Program
    {
        static void gameProcessCharacter(Character character, string pressedKey)
        {
            switch (pressedKey)
            {
                case ("1"):
                    character.makeCharacterStep();
                    break;
                case ("2"):
                    character.makeCharacterJump();
                    break;
                case ("3"):
                    character.makeCharacterSitDown();
                    break;
            }
        }
        static void gameProcessWarrior(Warrior warrior)
        {
            bool isExitKeyPressed = false;
            while (!isExitKeyPressed)
            {
                Console.WriteLine("Select action. 1 - make a step. 2 - jump. 3 - sit down. 4 - hit with sword. 5 - exit.");
                string pressedKey = Console.ReadLine();
                if ((pressedKey == "1") || (pressedKey == "2") || (pressedKey == "3"))
                {
                    gameProcessCharacter(warrior, pressedKey);
                }
                else
                {
                    if (pressedKey == "4")
                    {
                        warrior.makeCharacterHitWithSword();
                    }
                    else
                    {
                        if (pressedKey == "5")
                        {
                            isExitKeyPressed = true;
                        }
                        else
                        {
                            Console.WriteLine("Something went wrong. Try again.");
                        }
                    }
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
                if ((pressedKey == "1") || (pressedKey == "2") || (pressedKey == "3"))
                {
                    gameProcessCharacter(magician, pressedKey);
                }
                else
                {
                    if (pressedKey == "4")
                    {
                        magician.makeCharacterCastSpell();
                    }
                    else
                    {
                        if (pressedKey == "5")
                        {
                            isExitKeyPressed = true;
                        }
                        else
                        {
                            Console.WriteLine("Something went wrong. Try again.");
                        }
                    }
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
