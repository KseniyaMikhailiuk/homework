using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Player
    {
        public void step()
        {
            Console.WriteLine("Your character made a step");
        }
        public void jump()
        {
            Console.WriteLine("Your character jumped");
        }
        public void sitDown()
        {
            Console.WriteLine("Your character sat down");
        }
    }

    internal class Warrior : Player
    {
        public void hitWithSword()
        {
            Console.WriteLine("Your character hit with sword");
        }
    }
    internal class Magician : Player
    {
        public void castSpell()
        {
            Console.WriteLine("Your character cast a spell");
        }
    }

    class Program
    {
        static void gameProcessWarrior(ref Warrior warrior)
        {
            //Console.WriteLine("Select action. 1 - make a step. 2 - jump. 3 - sit down. 4 - hit with sword. 5 - exit.");
            bool isExitKeyPressed = false;
            while (isExitKeyPressed != true)
            {
                Console.WriteLine("Select action. 1 - make a step. 2 - jump. 3 - sit down. 4 - hit with sword. 5 - exit.");
                string pressedKey = Console.ReadLine();
                switch (pressedKey)
                {
                    case ("1"):
                        warrior.step();
                        break;
                    case ("2"):
                        warrior.jump();
                        break;
                    case ("3"):
                        warrior.sitDown();
                        break;
                    case ("4"):
                        warrior.hitWithSword();
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
        static void gameProcessMagician(ref Magician magician)
        {
            //Console.WriteLine("Select action. 1 - make a step. 2 - jump. 3 - sit down. 4 - cast a spell. 5 - exit.");
            bool isExitKeyPressed = false;
            while (isExitKeyPressed != true)
            {
                Console.WriteLine("Select action. 1 - make a step. 2 - jump. 3 - sit down. 4 - cast a spell. 5 - exit.");
                string pressedKey = Console.ReadLine();
                switch (pressedKey)
                {
                    case ("1"):
                        magician.step();
                        break;
                    case ("2"):
                        magician.jump();
                        break;
                    case ("3"):
                        magician.sitDown();
                        break;
                    case ("4"):
                        magician.castSpell();
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

        static void Main(string[] args)
        {
             //Console.WriteLine("Select a character. 1 - warrior. 2 - magician.");
             bool correctKey = false;
             while (correctKey != true)
             {
                Console.WriteLine("Select a character. 1 - warrior. 2 - magician.");
                string pressedKey = Console.ReadLine();
                 switch (pressedKey)
                 {
                     case "1":
                         Warrior warrior = new Warrior();
                         gameProcessWarrior(ref warrior);
                         correctKey = true;
                         break;
                     case "2":
                         Magician magician = new Magician();
                        gameProcessMagician(ref magician);
                         correctKey = true;
                         break;
                     default:
                         Console.WriteLine("Something went wrong. Try again.");
                         break;
                 }
             }

        }
    }
}
