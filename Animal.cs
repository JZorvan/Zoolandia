using System;

namespace Zoolandia
{
    public class Animal
    {
        public string prompt = ">";
        public string Name {get;set;}
        public string Color {get;set;}
        public int NumOfLegs {get;set;}
        public bool Fluffy {get;set;}
        public bool Vicious {get;set;}

        public virtual string Eat(string TypeOfFood) 
        {
            return "Nom nom nom, thanks I like " + TypeOfFood + ".";
        }
        public virtual string Play(string Toy)
        {
            return "The animal plays with the " + Toy + ".";
        }
    }
}

