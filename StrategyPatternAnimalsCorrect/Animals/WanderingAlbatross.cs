using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternAnimalsCorrect
{
    public class WanderingAlbatross : Animal
    {
        public override void Display()
        {
            Console.WriteLine("                                                                  ___\r\n                                                   ________.-----''\r\n                                          ___.--'\"\"___.----''\r\n                                       .-'    _.-'\"\r\n                            _ .-.__.--'    .-'\r\n                          .' `  / ' __ _.-'\r\n                          ) '  '   )   /`-._.\r\n                         (.'\\          )/))-)\\\r\n                       .'    >.________.--'\r\n                    .-'   .-'\r\n                  .'    .'\r\n               .-'   .-'\r\n             .'    .'\r\n            /    .'\r\n          .'   .'                               \r\n         /  ,,/                                                      \r\n        /'''/                                                           \r\n       / ,''                                                             \r\n      /''     ");
        }

        public WanderingAlbatross()
        {
            flyingBehaviour = new CanFly();
            swimmingBehaviour = new SwimLikeABird();
            walkingBehaviour = new CanWalk();
        }
    }
}
