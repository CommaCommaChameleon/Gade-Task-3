﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using System.Diagnostics;

namespace Swart_Simon_17611447_Task_1
{
    class MeleeUnit : Unit
    {

        #region Constructors

        public MeleeUnit()

        {
            Health = 10;
            Attack = 2;
            Speed = 3;
            Range = 1;
            Faction = "Red";
            Symbol = "M";
            xPosition = 3;
            yPosition = 2;
            Name = "Foot Soldier";
        }

        public MeleeUnit(int X, int Y, int health, int speed, int attack, string faction, string symbol, string name)
        {
            xPosition = X;
            yPosition = Y;
            Health = health;
            Speed = speed;
            Attack = attack;
            Range = 1;
            Faction = faction;
            Symbol = symbol;
            Name = name;
        }
        #endregion

        public override void combat(Unit enemy)
        {
            if(enemy.Faction != this.Faction)
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
            
        }

        public override void death()
        {
            if(Health <= 0)
            {
                Symbol = "X";
            }
        }

        public override int returnClosest(int x1, int y1, int x2, int y2)
        {
            int distance = Convert.ToInt32(Math.Sqrt((x2-x1) * (x2-x1) + ((y2-y1) * (y2-y1))));

            return distance;
        }

        public void loadRed()
        {
            FileStream inFile = null;
            StreamReader reader = null;

            string input;

            inFile = new FileStream(@"Files\\redMelee.txt", FileMode.Open, FileAccess.Read);
            reader = new StreamReader(inFile);

            
                try
                {                  
                    while (reader.ReadLine() != null)
                    {
                        xPosition = int.Parse(reader.ReadLine());
                        yPosition = int.Parse(reader.ReadLine());
                        Health = int.Parse(reader.ReadLine());
                        Speed = int.Parse(reader.ReadLine());
                        Attack = int.Parse(reader.ReadLine());
                        Faction = reader.ReadLine();
                        Symbol = reader.ReadLine();
                        Name = reader.ReadLine();

                        input = reader.ReadLine();
                    }
                    reader.Close();
                    inFile.Close();
                }
                catch (Exception fe)
                {
                    Debug.WriteLine(fe.Message);
                }
                finally
                {
                    if (inFile != null)
                    {
                        reader.Close();
                        inFile.Close();
                    }
                }
                       
        }

        
        public override string toString()
        {
            string output;

            output = Name
                   + "\n" + xPosition
                   + "\n" + yPosition
                   + "\n" + Faction
                   + "\n" + Symbol
                   + "\n" + Health
                   + "\n" + Attack
                   + "\n" + Range
                   + "\n" + Speed;

            return output;
        }
    }
}
