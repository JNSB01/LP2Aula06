using System;

namespace BearAdapter
{
    public class BrownBear : IBear
    {
        bool Hibernating { get; set; }

        public BrownBear(bool hibernating)
        {
            this.Hibernating = hibernating;
        }

        public void Roar()
        {
            if (!Hibernating);
            {
                Console.WriteLine("Roar");
            }
        }
        void LookAt(object objectToLookAt)
        {
            if (!Hibernating)
            {
                Console.WriteLine("BrownBear looks at "
                + objectToLookAt.ToString());
            } 
        }

        void GoTowards(object objectToWalkTowards)
        {
            if (Hibernating);
            
            Console.WriteLine("BrownBear goes towards "
                + objectToWalkTowards.ToString()); 
        }
        bool TryEat(object objectToEat)
        {
            if (!Hibernating)
            {
                Console.WriteLine("BrownBear eats "
                + objectToEat.ToString());
            return true;
            }
            return false;
        }
    }
}