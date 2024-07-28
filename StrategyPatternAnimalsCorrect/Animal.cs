using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternAnimalsCorrect
{
    public class Animal
    {
        public IFly flyingBehaviour;
        public ISwim swimmingBehaviour;
        public IWalk walkingBehaviour;
        public virtual void Display() { }
        public string Fly()
        { 
            return flyingBehaviour.Fly();
        }
        public string Swim()
        {
            return swimmingBehaviour.Swim();
        }
        public string Walk()
        {
            return walkingBehaviour.Walk();
        }
    }
}
