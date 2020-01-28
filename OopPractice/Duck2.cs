using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPractice
{
    public class Duck2
    {
        public virtual void Swim()
        {
            Console.WriteLine("Duck2 class Swim Method");
        }
        public virtual void Display()
        {
            Console.WriteLine("Duck2 class Display Method");
        }
    }



    public class MallardDucK2 : Duck2
    {
        public override void Display()
        {
            Console.WriteLine("MallardDucK  class  Display Method");
        }
    }
    public class RedHeadDucK2 : Duck2
    {
        public override void Display()
        {
            Console.WriteLine("RedHeadDucK class Display Method");
        }
    }

    public class RubberDuck2 : Duck2, IQuackable, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("RubberDuck class Quack Method");
        }
    
        public void Quack()
        {
        Console.WriteLine("RubberDuck class Fly Method-do nothing");
        }
        /*public override void Quack()
        {
           Console.WriteLine("RubberDuck class Quack Method");
        }
        public override void Fly()
        {
           Console.WriteLine("RubberDuck class Fly Method-do nothing");
        }*/
    }

    public interface IFlyable
    {
        void Fly();

    }
    public interface IQuackable
    {
        void Quack();
    }
}
