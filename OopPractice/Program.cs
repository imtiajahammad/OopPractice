using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duckM = new MallardDucK();
            duckM.Display();
            duckM.Quack();
            duckM.Swim();
            duckM.Fly();
            Duck duckR = new RedHeadDucK();
            duckR.Display();
            duckR.Quack();
            duckR.Swim();
            duckR.Fly();
            Console.ReadKey();
        }
    }

    public class Duck
    {
        public virtual void Quack()
        {
            Console.WriteLine("Duck class Quack Method");
        }
        public virtual void Swim()
        {
            Console.WriteLine("Duck class Swim Method");
        }
        public virtual void Display()
        {
            Console.WriteLine("Duck class Display Method");
        }
        public virtual void Fly()
        {
            Console.WriteLine("Duck class Fly Method");
        }
    }
    public class MallardDucK : Duck
    {
        public override void Display()
        {
            Console.WriteLine("MallardDucK  class  Display Method");
        }
    }
    public class RedHeadDucK : Duck
    {
        public override void Display()
        {
            Console.WriteLine("RedHeadDucK class Display Method");
        }
    }

}
