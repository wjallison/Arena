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
    public static class _globals
    {


        public static double Cross(Vector2 a, Vector2 b)
        {
            return a.X * b.Y - a.Y * b.X;
        }

        public enum Types
        {
            Generator = 0,
            Thruster = 1,
            Conduit = 2,
            Cockpit = 3,
            Weapon = 4
        }

        public enum AttackTypes
        {
            Laser = 0,
            Ballistic = 1,
            Missile = 2
        }

        public static Vector2 RotVect(Vector2 vect, double theta)
        {
            float x = (float)(vect.X * Math.Cos(theta) - vect.Y * Math.Sin(theta));
            float y = (float)(vect.X * Math.Sin(theta) + vect.Y * Math.Cos(theta));
            return new Vector2(x, y);
        }
    }
}
