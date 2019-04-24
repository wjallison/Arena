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
    public class ShipBlock
    {
        private double hp;
        public double HP { get { return hp; } set { hp = value; } }
        private double mass;
        public double Mass { get { return mass; } set { mass = value; } }
        public List<double> damageResistances = new List<double>();

        public ShipBlock() { }
    }
}
