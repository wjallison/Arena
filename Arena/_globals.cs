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
    }
}
