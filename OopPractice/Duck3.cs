using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPractice
{
    public abstract class Duck3
    {
        public IFlyBehaviour flyBehaviour;
        public IQuackBehaviour quackBehaviour;
        public void SetFlyBehavior(IFlyBehaviour fb)
        {
            flyBehaviour = fb;
        }
        public void SetQuackBehaviour(IQuackBehaviour qb)
        {
            quackBehaviour = qb;
        }
        public abstract void Display();
        public void PerformFly()
        {
            flyBehaviour.Fly();
        }
        public void PerformQuack()
        {
            quackBehaviour.Quack();
        }
        public virtual void Swim()
        {
            Console.WriteLine("Duck3 class Swim Method--all ducks swim");
        }
    }








    public class MallardDucK3 : Duck3
    {
        public MallardDucK3()
        {
            quackBehaviour = new Quack();
            flyBehaviour = new FlyWithWings();
        }
        public override void Display()
        {
            Console.WriteLine("MallardDucK  class  Display Method");
        }
    }
    public class RedHeadDuck3 : Duck3
    {
        public RedHeadDuck3()
        {
            quackBehaviour = new Quack();
            flyBehaviour = new FlyWithWings();
        }
        public override void Display()
        {
            Console.WriteLine("RedHeadDucK class Display Method");
        }
    }

    public class RubberDuck3 : Duck3
    {
        public RubberDuck3()
        {
            quackBehaviour = new Quack();
            flyBehaviour = new FlyNoWay();
        }
        public override void Display()
        {
            Console.WriteLine("RubberDuck class Display Method");
        }
    }















    public interface IFlyBehaviour
    {
        void Fly();
    }
    public interface IQuackBehaviour
    {
        void Quack();
    }
    public class FlyWithWings : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("FlyWithWings");
        }
    }
    public class FlyNoWay : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("FlyNoWay");
        }
    }
    public class Quack : IQuackBehaviour
    {
        void IQuackBehaviour.Quack()
        {
            Console.WriteLine("Quack");
        }
    }
    public class Squeak : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
    public class MuteQuack : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Mute");
        }
    }
    
}
