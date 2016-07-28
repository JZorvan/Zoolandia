using System;
using Zoolandia.Species;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String prompt = "> ";
            
            FelisCatus MyKitten = new FelisCatus();
            MyKitten.Name = "Zeppelin";
            MyKitten.Color = "brown tabby";
            MyKitten.Fluffy = true;
            MyKitten.Vicious = true;
            Console.WriteLine("My Kitten's name is {0}.  He is a {1}.", MyKitten.Name, MyKitten.Color);
            Console.WriteLine("What you like to give " + MyKitten.Name + " to play with?");
            Console.Write(prompt);
            string toy = Console.ReadLine();
            Console.WriteLine(MyKitten.Play(toy));

            LoxoscelesReclusa MySpider = new LoxoscelesReclusa();

            MySpider.Name = "Mr. Creepy";
            MySpider.NumOfLegs = 8;
            MySpider.Vicious = true;
            Console.WriteLine("My house is infested with {0}-legged spiders.  I named their king {1}.", MySpider.NumOfLegs, MySpider.Name);
            Console.WriteLine(MySpider.Name + " looks hungry.  What would you like to feed it?");
            Console.Write(prompt);
            string food = Console.ReadLine();
            Console.WriteLine(MySpider.Eat(food));

            AilurusFulgens MyPanda = new AilurusFulgens();
            MyPanda.NumOfLegs = -2;
        }
    }
}
