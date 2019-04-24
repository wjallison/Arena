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
    public class ShipModule
    {
        public List<ShipBlock> blocks = new List<ShipBlock>();
        private bool enabled;
        public bool Enabled { get { return enabled; } set { enabled = value; } }
        private double mass;
        public double Mass { get { return mass; } }
        private double powerSupplied;
        public double PowerSupplied { get { return powerSupplied; } set { powerSupplied = value; } }
        private double thrust;
        public double Thrust { get { return thrust; } set { thrust = value; } }
        private double thrustCone;
        public double ThrustCone { get { return thrustCone; } set { thrustCone = value; } }


    }
}
