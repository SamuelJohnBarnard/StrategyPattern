using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternAnimalsCorrect
{
    public class CanSwim : ISwim
    {
        public string Swim() { return "This animal swims quickly through the ocean"; }
    }
}
