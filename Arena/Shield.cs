using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Arena
{
    public class Shield
    {
        public Circle hitCircle;
        public Rectangle displayBox;
        public double maxVal;
        public double val;

        public Shield() { }
        public Shield(double max)
        {
            maxVal = max;
            val = maxVal;
        }
    }
}
