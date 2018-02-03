using System;

namespace MagiciansAgainstWarriorsGame
{
    public class Magician : Character
    {
        public override void SpecialAction()
        {
            Console.WriteLine("Your character cast a spell");
        }
    }
}
