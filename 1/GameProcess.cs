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
        enum eCharacter
        {
            Warrior = 1,
            Magician
        }
        
        public void StartGame()
        {
            eCharacter character;
            bool isCharacterSelected = false;
            while (!isCharacterSelected)
            {
                Console.WriteLine("Select character. 1 - warrior. 2 - magician.");
                if (int.TryParse(Console.ReadLine(), out int selectedCharacter))
                {
                    if (Enum.IsDefined((typeof(eCharacter)), selectedCharacter))
                    {
                        character = (eCharacter)Convert.ToInt32(selectedCharacter);
                        isCharacterSelected = true;
                        if (character == eCharacter.Warrior)
                        {
                            GetInstraction(eCharacter.Warrior);
                        }
                        else
                        {
                            GetInstraction(eCharacter.Magician);
                        }
                    }
                }
            }

        }

        static void GetInstraction(eCharacter character)
        {
            var warrior = new Warrior();
            var magician = new Magician();
            Action action;
            while (true)
            {
                Console.WriteLine("Select action. 1 - make a step. 2 - jump. 3 - sit down. 4 - special action. 5 - exit.");
                if (int.TryParse(Console.ReadLine(), out int pressedKey))
                {
                    if (Enum.IsDefined((typeof(Action)), pressedKey))
                    {
                        action = (Action)Convert.ToInt32(pressedKey);
                        if (character == eCharacter.Warrior)
                        {
                            RealizeGameProcessWarrior(action, warrior);
                        }
                        else
                        {
                            RealizeGameProcessMagician(action, magician);
                        }
                        continue;
                    }
                }
                Console.WriteLine("Something went wrong. Try again.");
            }
        }

        static void RealizeGameProcessWarrior(Action action, Warrior warrior)
        {
            if ((((int)action < 4) && (action > 0)) || ((int)action == 5))
            {
                RealizeGameProcessCharacter(warrior, action);
            }
            else
            {
                if (action == Action.SpacialAction)
                {
                    warrior.HitWithSword();
                }
            }
        }

        static void RealizeGameProcessMagician(Action action, Magician magician)
        {
            if ((((int)action < 4) && (action > 0)) || ((int)action == 5))
            {
                RealizeGameProcessCharacter(magician, action);
            }
            else
            {
                if (action == Action.SpacialAction)
                {
                    magician.CastSpell();
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
                case Action.Exit:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
