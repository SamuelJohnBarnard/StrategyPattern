using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternAnimalsCorrect
{
    public class CanWalk : IWalk
    {
        public string Walk() { return "This animal walks around"; }
    }
}
