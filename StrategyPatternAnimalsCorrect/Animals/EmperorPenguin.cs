using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternAnimalsCorrect
{
    public class EmperorPenguin : Animal
    {
        public override void Display()
        {
            Console.WriteLine("            _____                                      _____                     \r\n          ,888888b.                                  ,888888b.                   \r\n        .d888888888b                               .d888888888b                  \r\n    _..-'.`*'_,88888b                          _..-'.`*'_,88888b                 \r\n  ,'..-..`\"ad88888888b.                      ,'..-..`\"ad88888888b.               \r\n         ``-. `*Y888888b.                           ``-. `*Y888888b.             \r\n             \\   `Y888888b.                             \\   `Y888888b.           \r\n             :     Y8888888b.                           :     Y8888888b.         \r\n             :      Y88888888b.                         :      Y88888888b.       \r\n             |    _,8ad88888888.                        |    _,8ad88888888.      \r\n             : .d88888888888888b.                       : .d88888888888888b.     \r\n             \\d888888888888888888                       \\d888888888888888888     \r\n             8888;'''`88888888888                       8888;ss'`88888888888     \r\n             888'     Y8888888888                       888' \"\"  Y8888888888     \r\n             `Y8      :8888888888                       `Y8    \" :8888888888     \r\n              |`      '8888888888                        |`      '8888888888     \r\n              |        8888888888                        |        8888888888     \r\n              |        8888888888                        |        8888888888     \r\n              |        8888888888                        |        8888888888     \r\n              |       ,888888888P                        |       ,888888888P     \r\n              :       ;888888888'                        :       ;888888888'     \r\n               \\      d88888888'                         :       ;888888888'     \r\n              _.>,    888888P'                            \\      d88888888'      \r\n            <,--''`.._>8888(                             _.>     888888P'        \r\n             `>__...--' `''` SSt                       <,--' `.._>8888(          \r\n                                                        `>__ ..--' `''` SSt      \r\n                                                                                 ");
        }

        public EmperorPenguin()
        {
            flyingBehaviour = new CannotFly();
            swimmingBehaviour = new CanSwim();
            walkingBehaviour = new CanWalk();
        }
    }
}
