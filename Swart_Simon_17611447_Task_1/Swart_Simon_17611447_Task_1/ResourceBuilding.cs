using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Swart_Simon_17611447_Task_1
{
    class ResourceBuilding : Building
    {
        public string resourceType;
        public int resourcesPerTick;
        public int resourcesRemaining;

        public ResourceBuilding()
        {
            xPosition = 4;
            yPosition = 12;
            Faction = "Blue";
            Health = 12;
            Symbol = "g";
            ResourceType = "Wood";
            ResourcesPerTick = 3;
            ResourcesRemaining = 20;

        }

        public ResourceBuilding(int x, int y, string faction, int health, string symbol, string type, int rpt, int remaining)
        {
            xPosition = x;
            yPosition = y;
            Faction = faction;
            Health = health;
            Symbol = symbol;
            ResourceType = type;
            ResourcesPerTick = rpt;
            ResourcesRemaining = remaining;
        }
        #region Accessors
        public string ResourceType
        {
            get { return resourceType; }
            set { resourceType = value; }
        }

        public int ResourcesPerTick
        {
            get { return resourcesPerTick; }
            set { resourcesPerTick = value; }
        }

        public int ResourcesRemaining
        {
            get { return resourcesRemaining; }
            set { resourcesRemaining = value; }
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

        public void generateResource()
        {
            while (ResourcesRemaining > 0)
            {
                ResourcesRemaining -= ResourcesPerTick;
            }
            
        }

        public string toString()
        {
            string output;

            output = "Health: " + Health + "\nX-Position: " + xPosition + "\nY-Position: " + yPosition + "\nFaction: " + Faction + "\nSymbol: " + Symbol + "\nResource Type: " + ResourceType + "\nResources Per Tick" + ResourcesPerTick + "\nResources Remaining: " + ResourcesRemaining;

            return output;
        }

    }
}
