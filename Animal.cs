using System;

namespace Zoolandia
{
    public class Animal
    {
        public string Name {get;set;}
        public string Color {get;set;}
        private int numOfLegs = 2;
        public bool Fluffy {get;set;}
        public bool Vicious {get;set;}

        public int NumOfLegs
        {
            get {return this.numOfLegs;}
            set
            {
                if (value < 0) { Console.WriteLine("No animal can have LESS THAN no legs, Paste-Eater!"); }
                else { this.numOfLegs = value; }
            }
        }

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

