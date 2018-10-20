using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotic
{
    class Plane
    {
        public static int maxX;
        public static int maxY;

        public Plane(string input)
        {
            maxX = int.Parse(input[0].ToString());
            maxY = int.Parse(input[1].ToString());
        }
    }
}