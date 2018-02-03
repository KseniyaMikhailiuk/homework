using System;

namespace MagiciansAgainstWarriorsGame
{
    public class GameProcess
    {
        public Character character;
        public void StartGame()
        {
            CharacterTypes character;
            bool isCharacterSelected = false;
            while (!isCharacterSelected)
            {
                Console.WriteLine(String.Format("Select character. {0} - warrior. {1} - magician.",
                                                (int)CharacterTypes.Warrior,
                                                (int)CharacterTypes.Magician));
                if (int.TryParse(Console.ReadLine(), out int selectedCharacter))
                {
                    if (Enum.IsDefined((typeof(CharacterTypes)), selectedCharacter))
                    {
                        character = (CharacterTypes)Convert.ToInt32(selectedCharacter);
                        isCharacterSelected = true;
                        GetInstruction(character);
                    }
                }
            }
        }

        void GetInstruction(CharacterTypes selectedCharacter)
        {
            switch (selectedCharacter)
            {
                case (CharacterTypes.Warrior):
                    character = new Warrior();
                    break;
                case (CharacterTypes.Magician):
                    character = new Magician();
                    break;
            }
            ActionTypes action;
            bool isExitKeyPressed = false;
            while (!isExitKeyPressed)
            {
                Console.WriteLine(String.Format("Select action. {0} - make a step. {1} - jump. {2} - sit down. {3} - special action. {4} - exit.",
                               (int)ActionTypes.Step,
                               (int)ActionTypes.Jump,
                               (int)ActionTypes.SitDown,
                               (int)ActionTypes.SpecialAction,
                               (int)ActionTypes.Exit));
                if (int.TryParse(Console.ReadLine(), out int pressedKey))
                {
                    action = (ActionTypes)Convert.ToInt32(pressedKey);
                    if (action != ActionTypes.Exit)
                    {
                        if (selectedCharacter == CharacterTypes.Warrior)
                        {
                            ExecuteAction(action);
                        }
                        else
                        {
                            ExecuteAction(action);
                        }
                    }
                    else
                    {
                        isExitKeyPressed = true;
                    }
                    
                }
            }
        }

        void ExecuteAction(ActionTypes action)
        {
            switch (action)
            {
                case ActionTypes.Step:
                    character.Step();
                    break;
                case ActionTypes.Jump:
                    character.Jump();
                    break;
                case ActionTypes.SitDown:
                    character.SitDown();
                    break;
                case ActionTypes.SpecialAction:
                    character.SpecialAction();
                    break;
                default:
                    Console.WriteLine("Something went wrong. Try again.");
                    break;
            }
        }
    }
}
