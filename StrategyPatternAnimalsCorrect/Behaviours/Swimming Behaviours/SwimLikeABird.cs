using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternAnimalsCorrect
{
    public class SwimLikeABird : ISwim
    {
        public string Swim()
        {
            return "This animal briefly swims through the ocean to catch a fish";
        }
    }
}
