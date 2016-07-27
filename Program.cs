using System;
using Zoolandia.Species;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            FelisCatus MyKitten = new FelisCatus();

            MyKitten.Name = "Zeppelin";
            MyKitten.Color = "brown tabby";
            MyKitten.Fluffy = true;
            MyKitten.Vicious = true;
            Console.WriteLine("My Kitten's name is {0}.  He is a {1}.", MyKitten.Name, MyKitten.Color);
            Console.WriteLine(MyKitten.Play("straw"));

            LoxoscelesReclusa MySpider = new LoxoscelesReclusa();

            MySpider.Name = "Mr. Creepy";
            MySpider.NumOfLegs = 8;
            MySpider.Vicious = true;
            Console.WriteLine("My house is infested with {0}-legged spiders.  I named their king {1}.", MySpider.NumOfLegs, MySpider.Name);

            Console.WriteLine(MySpider.Eat("bugs"));
        }
    }
}
