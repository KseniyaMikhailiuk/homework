using System;


namespace MagiciansAgainstWarriorsGame
{
    public class GameProcess
    {
        enum Action
        {
            Step = 1,
            Jump,
            SitDown,
            SpacialAction,
            Exit
        }
        private string selectedCharacter = "";
        public void StartGame()
        {
            bool isKeyRight = false;
            while (!isKeyRight)
            {
                Console.WriteLine("Select character. 1 - warrior. 2 - magician.");
                selectedCharacter = Console.ReadLine();
                if ((selectedCharacter == "1") || (selectedCharacter == "2"))
                {
                    isKeyRight = true;
                }
            }
            if (selectedCharacter == "1")
            {
                var warrior = new Warrior();
                RealizeGameProcessWarrior(warrior);
            }
            else
            {
                var magician = new Magician();
                RealizeGameProcessMagician(magician);
            }
        }

        static void RealizeGameProcessWarrior(Warrior warrior)
        {
            Action action;
            string pressedKey;
            bool isExitKeyPressed = false;
            while (!isExitKeyPressed)
            {
                Console.WriteLine("Select action. 1 - make a step. 2 - jump. 3 - sit down. 4 - cast a spell. 5 - exit.");
                pressedKey = Console.ReadLine();
                action = (Action)Convert.ToInt32(pressedKey);
                if (((int)action < 4) && ((int)action > 0))
                {
                    RealizeGameProcessCharacter(warrior, action);
                }
                else
                {
                    if (action == Action.SpacialAction)
                    {
                        warrior.HitWithSword();
                    }
                    else
                    {
                        if (action == Action.Exit)
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
            Action action;
            string pressedKey;
            bool isExitKeyPressed = false;
            while (!isExitKeyPressed)
            {
                Console.WriteLine("Select action. 1 - make a step. 2 - jump. 3 - sit down. 4 - cast a spell. 5 - exit.");
                pressedKey = Console.ReadLine();
                action = (Action)Convert.ToInt32(pressedKey);
                if (((int)action < 4) && ((int)action > 0))
                {
                    RealizeGameProcessCharacter(magician, action);
                }
                else
                {
                    if (action == Action.SpacialAction)
                    {
                        magician.CastSpell();
                    }
                    else
                    {
                        if (action == Action.Exit)
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
        static void RealizeGameProcessCharacter(Character character, Action action)
        {
            switch (action)
            {
                case Action.Step:
                    character.Step();
                    break;
                case Action.Jump:
                    character.Jump();
                    break;
                case Action.SitDown:
                    character.SitDown();
                    break;
            }
        }
    }
}
