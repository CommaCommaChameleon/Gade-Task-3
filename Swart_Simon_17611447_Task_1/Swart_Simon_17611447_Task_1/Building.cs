using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swart_Simon_17611447_Task_1
{
    class Building
    {
        private int x;
        private int y;
        private string faction;
        private int health;
        private string symbol;

        public Building()
        {
            xPosition = 4;
            yPosition = 12;
            faction = "Blue";
            health = 12;
            symbol = "BB";
        }
        
        public Building(int x, int y, string faction, int health, string symbol)
        {
            xPosition = x;
            yPosition = y;
            this.faction = faction;
            this.health = health;
            this.symbol = symbol;
        }

        public int xPosition
        {
            get { return x; }
            set { x = value; }
        }

        public int yPosition
        {
            get { return y; }
            set { y = value; }
        }

        public string Faction
        {
            get { return faction; }
            set { faction = value; }
        }


        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public string Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }

        public bool isDestroyed(Building b)
        {
            bool destroyed = false;

            if(b.health <= 0)
            {
                destroyed = true;
            }

            return destroyed;
        }

        public string toString()
        {
            string output;

            output = "Health: " + health + "\nX-Position: " + xPosition + "\nY-Position: " + yPosition + "\nFaction: " + faction + "\nSymbol: " + symbol;

            return output;
        }
    }
}
