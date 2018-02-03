using System;

namespace MagiciansAgainstWarriorsGame
{
    public class Warrior : Character
    {
        public override void SpecialAction()
        {
            Console.WriteLine("Your character hit with sword");
        }
    }
}
