using System;

namespace MagiciansAgainstWarriorsGame
{
    class Program
    {
        static void RealizeGameProcessCharacter(Character character, string pressedKey)
        {
            switch (pressedKey)
            {
                case ("1"):
                    character.Step();
                    break;
                case ("2"):
                    character.Jump();
                    break;
                case ("3"):
                    character.SitDown();
                    break;
            }
        }
        static void RealizeGameProcessWarrior(Warrior warrior)
        {
            bool isExitKeyPressed = false;
            while (!isExitKeyPressed)
            {
                Console.WriteLine("Select action. 1 - make a step. 2 - jump. 3 - sit down. 4 - hit with sword. 5 - exit.");
                string pressedKey = Console.ReadLine();
                if ((pressedKey == "1") || (pressedKey == "2") || (pressedKey == "3"))
                {
                    RealizeGameProcessCharacter(warrior, pressedKey);
                }
                else
                {
                    if (pressedKey == "4")
                    {
                        warrior.HitWithSword();
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
        static void RealizeGameProcessMagician(Magician magician)
        {
            bool isExitKeyPressed = false;
            while (!isExitKeyPressed)
            {
                Console.WriteLine("Select action. 1 - make a step. 2 - jump. 3 - sit down. 4 - cast a spell. 5 - exit.");
                string pressedKey = Console.ReadLine();
                if ((pressedKey == "1") || (pressedKey == "2") || (pressedKey == "3"))
                {
                    RealizeGameProcessCharacter(magician, pressedKey);
                }
                else
                {
                    if (pressedKey == "4")
                    {
                        magician.CastSpell();
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
                         RealizeGameProcessWarrior(warrior);
                         isKeyCorrect = true;
                         break;
                     case "2":
                         var magician = new Magician();
                         RealizeGameProcessMagician(magician);
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
