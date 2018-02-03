using System;

namespace MagiciansAgainstWarriorsGame
{
    public class GameProcess
    {
        Character _character;
        ActionTypes _action;


        public void StartGame()
        {
            CharacterTypes characterType;
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
                        characterType = (CharacterTypes)Convert.ToInt32(selectedCharacter);
                        isCharacterSelected = true;
                        Play(characterType);
                    }
                }
            }
        }

        ActionTypes GetAction()
        {
            Console.WriteLine(String.Format("Select action. {0} - make a step. {1} - jump. {2} - sit down. {3} - special action. {4} - exit.",
                               (int)ActionTypes.Step,
                               (int)ActionTypes.Jump,
                               (int)ActionTypes.SitDown,
                               (int)ActionTypes.SpecialAction,
                               (int)ActionTypes.Exit));

            int pressedKey = -1;
            bool isKeyDefined = false;

            while (!isKeyDefined)
            {
                int.TryParse(Console.ReadLine(), out pressedKey);
                isKeyDefined = Enum.IsDefined(typeof(ActionTypes), pressedKey);

                if (!isKeyDefined)
                {
                    Console.WriteLine("Something went wrong. Try again.");
                }
            }

            return (ActionTypes)pressedKey;
        }

        void Play(CharacterTypes selectedCharacter)
        {
            switch (selectedCharacter)
            {
                case (CharacterTypes.Warrior):
                    _character = new Warrior();
                    break;
                case (CharacterTypes.Magician):
                    _character = new Magician();
                    break;
            }

            bool isExitKeyPressed = false;

            while (!isExitKeyPressed)
            {
                var action = GetAction();

                isExitKeyPressed = action == ActionTypes.Exit;
                if(isExitKeyPressed)
                {
                    return;
                }
                ExecuteAction(action);
            }
        }

        void ExecuteAction(ActionTypes action)
        {
            switch (action)
            {
                case ActionTypes.Step:
                    _character.Step();
                    break;
                case ActionTypes.Jump:
                    _character.Jump();
                    break;
                case ActionTypes.SitDown:
                    _character.SitDown();
                    break;
                case ActionTypes.SpecialAction:
                    _character.SpecialAction();
                    break;

            }
        }
    }
}
