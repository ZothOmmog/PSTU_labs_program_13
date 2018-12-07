using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_13
{
    static class RandElem
    {
        static Random rand = new Random();
        public static TranspSredstv Rand()
        {
            switch(rand.Next(1, 5))
            {
                case 1:
                    return new Auto();
                case 2:
                    return new Train();
                case 3:
                    return new Express();
                default:
                    break;
            }
            return new TranspSredstv();
        }
    }
}
