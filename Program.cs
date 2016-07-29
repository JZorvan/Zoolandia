using System;
using Aquarium.SeaCreatures;
using Aquarium.SeaCreatures.Species;

namespace Aquarium
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String prompt = "> ";

            HippocampusAlatus myAlutus = new HippocampusAlatus("Barry", 15);
            Console.WriteLine("My " + myAlutus.CommonName + "'s name is " + myAlutus.Name + ".");
            Console.WriteLine("He is {0}cm long and likes {1}.", myAlutus.LengthCM, myAlutus.Likes);
        
            
        }
    }
}
