using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swart_Simon_17611447_Task_1
{
    class RangedUnit : Unit
    {

        #region Constructors

        public RangedUnit()
        {

            Health = 10;
            Attack = 2;
            Speed = 3;
            Range = 3;
            Faction = "Red";
            Symbol = "R";
            xPosition = 3;
            yPosition = 2;
            Name = "Ranger";

        }

        public RangedUnit(int X, int Y, int health, int speed, int attack, int range, string faction, string symbol, string name)
        {
            xPosition = X;
            yPosition = Y;
            Health = health;
            Speed = speed;
            Attack = attack;
            Range = range;
            Faction = faction;
            Symbol = symbol;
            Name = name;
        }
        #endregion

        public override void combat(Unit enemy)
        {
            if (enemy.Faction != this.Faction)
            {
                enemy.Health -= this.Attack;
            }
        }

        public override void newPosition()
        {
            base.newPosition();
        }

        public override void inRange()
        {
            base.inRange();
        }

        public override void death()
        {
            base.death();
        }

        public override int returnClosest(int x1, int y1, int x2, int y2)
        {
            int distance = Convert.ToInt32(Math.Sqrt((x2 - x1) * (x2 - x1) + ((y2 - y1) * (y2 - y1))));

            return distance;
        }

        public override string toString()
        {
            string output;

            output = "Name: " + Name
                   + "\nX: " + xPosition
                   + "\nY: " + yPosition
                   + "\nFaction: " + Faction
                   + "\nSymbol: " + Symbol
                   + "\nHealth: " + Health
                   + "\nAttack: " + Attack
                   + "\nRange: " + Range
                   + "\nSpeed: " + Speed;

            return output;
        }
    }
}
