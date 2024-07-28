using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternAnimalsCorrect
{
    public class BlueWhale : Animal
    {
        public override void Display()
        {
            Console.WriteLine("                                    ','. '. ; : ,','\r\n                                      '..'.,',..'\r\n                                         ';.'  ,'\r\n                                          ;;\r\n                                          ;'\r\n                            :._   _.------------.___\r\n                    __      :__:-'                  '--.\r\n             __   ,' .'    .'             ______________'.\r\n           /__ '.-  _\\___.'          0  .' .'  .'  _.-_.'\r\n              '._                     .-': .' _.' _.'_.'\r\n                 '----'._____________.'_'._:_:_.-'--'");
        }

        public BlueWhale()
        {
            flyingBehaviour = new CannotFly();
            swimmingBehaviour = new CanSwim();
            walkingBehaviour = new CannotWalk();
        }
    }
}
