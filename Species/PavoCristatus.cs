using System;

namespace Zoolandia.Species
{
    public class PavoCristatus : Animal
    {
        public override string Eat(string TypeOfFood)
        {
            return "The peacock eats " + TypeOfFood + "and looks damn majestic doing so.";
        }
    }
}