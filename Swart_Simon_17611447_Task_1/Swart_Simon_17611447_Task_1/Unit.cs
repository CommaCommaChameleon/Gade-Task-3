using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swart_Simon_17611447_Task_1
{
    class Unit
    {

        private int X;
        private int Y;
        private int health;
        private int speed;
        private int attack;
        private int range;
        private string faction;
        private string symbol;
        private string name;

        #region Constructors

        public Unit()
        {
            
        }

        public Unit(int X, int Y, int health, int speed, int attack, int range, string faction, string symbol)
        {
            
        }

        #endregion

        #region Accessors

        public int xPosition
        {
            get { return X; }
            set { X = value; }
        }

        public int yPosition
        {
            get { return Y; }
            set { Y = value; }
        }

        public int Attack
        {
            get { return attack; }
            set { attack = value; }
        }


        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public int Range
        {
            get { return range; }
            set { range = value; }
        }

        public string Faction
        {
            get { return faction; }
            set { faction = value; }
        }

        public string Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        #endregion

        #region Methods

        public virtual void newPosition()
        {
            
        }

        public virtual void combat(Unit enemy)
        {

        }

        public virtual void inRange()
        {

        }

        public virtual int returnClosest(int x1, int y1, int x2, int y2)
        {
            return 1;
        }

        public virtual void loadRed()
        {

        }

        public virtual void death()
        {

        }

        public virtual string toString()
        {
            string output = "";

            return output;
        }

        #endregion
    }
}
