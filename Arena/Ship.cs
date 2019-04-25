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
    public class Ship
    {
        private List<ShipModule> shipModules = new List<ShipModule>();
        public List<ShipModule> ShipModules { get { return shipModules; } set { shipModules = value; } }

        public Vector2 orientation;
        public double thetaDot;
        public double thetaDotDot;
        public Vector2 pos;
        public Vector2 posDot;
        public Vector2 posDotDot;

        private double totalPower;
        public List<Shield> shields = new List<Shield>();

        public List<Ship> targets = new List<Ship>();
        //private double shields;

        //private List<>
        

        public void Update(GameTime gameTime)
        {
            posDot.X = (float)(posDot.X + posDotDot.X * gameTime.ElapsedGameTime.TotalSeconds);
            posDot.Y = (float)(posDot.Y + posDotDot.Y * gameTime.ElapsedGameTime.TotalSeconds);

            pos.X = (float)(pos.X + posDot.X * gameTime.ElapsedGameTime.TotalSeconds);
            pos.Y = (float)(pos.Y + posDot.Y * gameTime.ElapsedGameTime.TotalSeconds);

            orientation = _globals.RotVect(orientation, thetaDot * gameTime.ElapsedGameTime.TotalSeconds);
            thetaDot = thetaDot + thetaDotDot * gameTime.ElapsedGameTime.TotalSeconds;


            for(int i = 0; i < shipModules.Count; i++)
            {
                shipModules[i].Update(gameTime);
            }
        }
    }
}
