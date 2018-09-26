using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swart_Simon_17611447_Task_1
{
    class FactoryBuilding : Building
    {
        public int unitsAmount;
        public int unitsPerTick;
        public int spawnX;
        public int spawnY;

        public FactoryBuilding()
        {
            xPosition = 4;
            yPosition = 12;
            Faction = "Blue";
            Health = 12;
            Symbol = "F";
            UnitsAmount = 1;
            UnitsPerTick = 3;
            SpawnX = 5;
            SpawnY = 12;

        }

        public FactoryBuilding(int x, int y, string faction, int health, string symbol, int amounts, int upt, int sX, int sY)
        {
            xPosition = x;
            yPosition = y;
            Faction = faction;
            Health = health;
            Symbol = symbol;
            UnitsAmount = unitsAmount;
            UnitsPerTick = upt;
            SpawnX = sX;
            SpawnY = sY;
        }
        #region Accessors
        public int UnitsAmount
        {
            get { return unitsAmount; }
            set { unitsAmount = value; }
        }

        public int UnitsPerTick
        {
            get { return unitsPerTick; }
            set { unitsPerTick = value; }
        }

        public int SpawnX
        {
            get { return spawnX; }
            set { spawnX = value; }
        }

        public int SpawnY
        {
            get { return spawnY; }
            set { spawnY = value; }
        }

        public bool isDestroyed()
        {
            bool destroyed = false;

            if (Health <= 0)
            {
                destroyed = true;
            }

            return destroyed;
        }
        #endregion

        public Unit spawnRedUnit()
        {
            Unit u = new Unit();

            Random rng = new Random();

            if(Faction == "Red")
            {
                if (rng.Next(0, 2) == 0)
                {
                    u = new MeleeUnit(SpawnX, SpawnY, 10, 3, 2, "Red", "m", "Foot Soldier");
                }
                else
                {
                    u = new RangedUnit(SpawnX, SpawnY, 10, 2, 3, 3, "Red", "r", "Ranger");
                }
            }
                                 
            return u;
        }

        public Unit spawnBlueUnit()
        {
            Unit u = new Unit();

            Random rng = new Random();

            if (rng.Next(0, 2) == 0)
            {
                u = new MeleeUnit(SpawnX, SpawnY, 10, 3, 2, "Blue", "M", "Foot Soldier");
            }
            else
            {
                u = new RangedUnit(SpawnX, SpawnY, 10, 2, 3, 3, "Blue", "R", "Ranger");
            }

            return u;
        }

        public string toString()
        {
            string output;

            output = "Health: " + Health + "\nX-Position: " + xPosition + "\nY-Position: " + yPosition + "\nFaction: " + Faction + "\nSymbol: " + Symbol + "\nUnits Per Production: " + UnitsAmount + "\nTicks Per Production: " + UnitsPerTick;

            return output;
        }

       
    }
}
