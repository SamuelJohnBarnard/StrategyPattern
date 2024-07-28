using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternAnimalsCorrect
{
    public class CannotFly : IFly
    {
        public string Fly() { return "This animal cannot fly"; }
    }
}
