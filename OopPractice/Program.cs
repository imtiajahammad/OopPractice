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
            /*Duck duckM = new MallardDucK();
            duckM.Display();
            duckM.Quack();
            duckM.Swim();
            duckM.Fly();
            Duck duckR = new RedHeadDucK();
            duckR.Display();
            duckR.Quack();
            duckR.Swim();
            duckR.Fly();*/
            /*Duck duckRubber = new RubberDuck();
            duckRubber.Fly();
            Console.ReadKey();*/

            /*Duck3 mallard = new MallardDucK3();
            //mallard.performFly();
            mallard.PerformFly();
            mallard.PerformQuack();
            //duck.*/
            Duck3 rubberDuck = new RubberDuck3();
            rubberDuck.PerformFly();
            rubberDuck.PerformQuack();

            rubberDuck.SetFlyBehavior(new FlyWithWings());
            rubberDuck.PerformFly();








            Console.ReadKey();
        }
    }

    



}
