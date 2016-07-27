using System;

namespace Zoolandia.Species
{
    public class LoxoscelesReclusa : Animal
    {
        public override string Eat(string TypeOfFood)
        {
            return "The spider doesn't like " + TypeOfFood + ", but he'll gladly bite Janelle.";
        }
    }
}