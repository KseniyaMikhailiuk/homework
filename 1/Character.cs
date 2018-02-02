using System;

namespace MagiciansAgainstWarriorsGame
{
    /*abstract*/ public class Character
    {
        public void Step()
        {
            Console.WriteLine("Your character made a step");
        }
        public void Jump()
        {
            Console.WriteLine("Your character jumped");
        }
        public void SitDown()
        {
            Console.WriteLine("Your character sat down");
        }
    }
}
