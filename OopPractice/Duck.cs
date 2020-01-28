using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPractice
{
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

    public class RubberDuck : Duck
    {
        public override void Quack()
        {
            Console.WriteLine("RubberDuck class Quack Method");
        }
        public override void Fly()
        {
            Console.WriteLine("RubberDuck class Fly Method-do nothing");
        }
    }
}
