using System;

namespace Zoolandia.Species
{
    public class FelisCatus : Animal
    {
        public override string Play(string Toy)
        {
            return "The kitten loves the " + Toy + "!  Everything is a toy!";
        }
    }
}