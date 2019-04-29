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
    public class Projectile
    {
        public Vector2 pos;
        public Vector2 posDot;
        public Vector2 posDotDot;
        public Vector2 orientation;
        public double thetaDot;
        public double thetaDotDot;


    }

    public class ballistic : Projectile
    {

    }

    public class guided : Projectile
    {

    }
}
