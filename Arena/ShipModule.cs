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
        private double powerUsed;
        public double PowerUsed { get { return powerUsed; } set { powerUsed = value; } }
        public Enum type;
        private Enum attackType;
        private double attackCone;
        public double AttackCone { get { return attackCone; } set { attackCone = value; } }


        public Texture2D textureMain;
        public Texture2D textureSecondary;
        public Texture2D textureDestroyed;
        public Rectangle displayBox;

        private Vector2 upperLeftPos;
        public Vector2 UpperLeftPos { get { return upperLeftPos; } set { upperLeftPos = value; } }

        private Vector2 pos;
        public Vector2 Pos { get { return pos; } set { pos = value; } }

        public int relX;
        public int relY;

        private double activeIntervalMax;
        private double activeInterval;

        public ShipModule() { }

        public delegate void UsePower(object sender);
        public event UsePower UsePowerEvent;

        public delegate void FireWeapon(object sender);
        public event FireWeapon FireWeaponEvent;

        public delegate void ExertThrust(object sender);
        public event ExertThrust ExertThrustEvent;

        public delegate void RechargeShield(double val);
        public event RechargeShield RechargeShieldEvent;


        public void Update(GameTime gameTime)
        {
            if(powerUsed > 0)
            {

            }
        }

    }
}
