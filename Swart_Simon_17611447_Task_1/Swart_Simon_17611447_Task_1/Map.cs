using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Swart_Simon_17611447_Task_1
{
    class Map
    {

        
        int x, y, blueRangers, blueMelee, blueHealers, blueArtillery, blueRepair, blueFactories, blueResources, redRangers, redMelee, redHealers, redArtillery, redRepair, redFactories, redResources, count;

        string[,] setMap = new string[21, 21];

        Random rng = new Random();
        Unit[] redTeamMelee;
        Unit[] redTeamRanged;
        Unit[] redTeamHealer;
        Unit[] redTeamArtillery;
        Unit[] redTeamRepair;

        Unit[] blueTeamMelee;
        Unit[] blueTeamRanged;
        Unit[] blueTeamHealer;
        Unit[] blueTeamArtillery;
        Unit[] blueTeamRepair;
        FactoryBuilding[] redTeamFactories;
        FactoryBuilding[] blueTeamFactories;
        ResourceBuilding[] redTeamResources;
        ResourceBuilding[] blueTeamResources;

        public string createMap()
        {
            string map = "";

            redRangers = rng.Next(1, 10);
            redMelee = rng.Next(1, 10);
            redFactories = rng.Next(1, 3);
            redResources = rng.Next(1, 3);
            redHealers = rng.Next(1, 5);
            redArtillery = rng.Next(1, 2);
            redRepair = rng.Next(1, 3);

            redTeamMelee = new MeleeUnit[redMelee];
            redTeamRanged = new RangedUnit[redRangers];
            redTeamHealer = new HealerUnit[redHealers];
            redTeamArtillery = new ArtilleryUnit[redArtillery];
            redTeamRepair = new RepairUnit[redRepair];
            
            redTeamFactories = new FactoryBuilding[redFactories];
            redTeamResources = new ResourceBuilding[redResources];

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    setMap[i, j] = " . ";                   
                }
            }

            count = 0;

            while (redRangers > 0)
            {
                
                x = rng.Next(0, 20);
                y = rng.Next(0, 20);

                if (setMap[x,y] == "R" || setMap[x,y] == "M" || setMap[x,y] == "r" || setMap[x,y] == "m" || setMap[x, y] == "F" || setMap[x, y] == "G" || setMap[x, y] == "f" || setMap[x, y] == "g")
                {
                    x = rng.Next(0, 20);
                    y = rng.Next(0, 20);
                    
                }
                else
                {
                    redTeamRanged[count] = new RangedUnit(x, y, 10, 3, 2, 3, "Red", "r", "Ranger");
                    setMap[x, y] = redTeamRanged[count].Symbol;                    
                    count++;
                    redRangers--;
                }
                
            }

            count = 0;

            while (redMelee > 0)
            {
                
                x = rng.Next(0, 20);
                y = rng.Next(0, 20);

                if (setMap[x, y] == "R" || setMap[x, y] == "M" || setMap[x, y] == "r" || setMap[x, y] == "m" || setMap[x, y] == "F" || setMap[x, y] == "G" || setMap[x, y] == "f" || setMap[x, y] == "g")
                {
                    x = rng.Next(0, 20);
                    y = rng.Next(0, 20);
                }
                else
                {
                   redTeamMelee[count] = new MeleeUnit(x, y, 10, 3, 2, "Red", "m", "Foot Soldier");
                   setMap[x, y] = redTeamMelee[count].Symbol;
                   count++;
                   redMelee--;
                }
            }            

            count = 0;

            while (redFactories > 0)
            {
                x = rng.Next(0, 20);
                y = rng.Next(0, 20);

                if(setMap[x, y] == "R" || setMap[x, y] == "M" || setMap[x, y] == "r" || setMap[x, y] == "m" || setMap[x, y] == "F" || setMap[x, y] == "G" || setMap[x, y] == "f" || setMap[x, y] == "g")
                {
                    x = rng.Next(0, 20);
                    y = rng.Next(0, 20);
                }
                else
                {
                    redTeamFactories[count] = new FactoryBuilding(x, y, "Red", 20, "f", 2, 1, x + 1, y);
                    setMap[x, y] = redTeamFactories[count].Symbol;
                    count++;
                    redFactories--;
                }
            }

            count = 0;

            while (redResources > 0)
            {
                x = rng.Next(0, 20);
                y = rng.Next(0, 20);

                if (setMap[x, y] == "R" || setMap[x, y] == "M" || setMap[x, y] == "r" || setMap[x, y] == "m" || setMap[x, y] == "F" || setMap[x, y] == "G" || setMap[x, y] == "f" || setMap[x, y] == "g")
                {
                    x = rng.Next(0, 20);
                    y = rng.Next(0, 20);
                }
                else
                {
                    redTeamResources[count] = new ResourceBuilding(x, y, "Red", 20, "g", "Wood", 3, 30);
                    setMap[x, y] = redTeamResources[count].Symbol;
                    count++;
                    redResources--;
                }
            }

            blueRangers = rng.Next(1, 10);
            blueMelee = rng.Next(1, 10);
            blueFactories = rng.Next(1, 3);
            blueResources = rng.Next(1, 3);
            blueHealers = rng.Next(1, 5);
            blueArtillery = rng.Next(1, 2);
            blueRepair = rng.Next(1, 3);

            blueTeamMelee = new MeleeUnit[blueMelee];
            blueTeamRanged = new RangedUnit[blueRangers];
            blueTeamHealer = new HealerUnit[blueHealers];
            blueTeamArtillery = new ArtilleryUnit[blueArtillery];
            blueTeamRepair = new RepairUnit[blueRepair];

            blueTeamFactories = new FactoryBuilding[blueFactories];
            blueTeamResources = new ResourceBuilding[blueResources];

            count = 0;

            while (blueRangers > 0)
            {
                
                x = rng.Next(0, 20);
                y = rng.Next(0, 20);
                if (setMap[x, y] == "R" || setMap[x, y] == "M" || setMap[x, y] == "r" || setMap[x, y] == "m")
                {
                    x = rng.Next(0, 20);
                    y = rng.Next(0, 20);

                }
                else
                {
                    blueTeamRanged[count] = new RangedUnit(x,y,10,3,2,3,"Blue","R", "Ranger");
                    setMap[x, y] = blueTeamRanged[count].Symbol;
                    count++;
                    blueRangers--;
                }

            }

            count = 0;

            while (blueMelee > 0)
            {
                
                x = rng.Next(0, 20);
                y = rng.Next(0, 20);
                if (setMap[x, y] == "R" || setMap[x, y] == "M" || setMap[x, y] == "r" || setMap[x, y] == "m")
                {
                    x = rng.Next(0, 20);
                    y = rng.Next(0, 20);
                }
                else
                {
                    blueTeamMelee[count] = new MeleeUnit(x,y, 10, 3, 2, "Blue", "M", "Foot Soldier");
                    setMap[x, y] = blueTeamMelee[count].Symbol;
                    count++;
                    blueMelee--;
                }
            }

            count = 0;

            while (blueFactories > 0)
            {
                x = rng.Next(0, 20);
                y = rng.Next(0, 20);

                if (setMap[x, y] == "R" || setMap[x, y] == "M" || setMap[x, y] == "r" || setMap[x, y] == "m" || setMap[x, y] == "F" || setMap[x, y] == "G" || setMap[x, y] == "f" || setMap[x, y] == "g")
                {
                    x = rng.Next(0, 20);
                    y = rng.Next(0, 20);
                }
                else
                {
                    blueTeamFactories[count] = new FactoryBuilding(x, y, "Blue", 20, "F", 1, 1, x + 1, y);
                    setMap[x, y] = blueTeamFactories[count].Symbol;
                    count++;
                    blueFactories--;
                }
            }

            count = 0;

            while (blueResources > 0)
            {
                x = rng.Next(0, 20);
                y = rng.Next(0, 20);

                if (setMap[x, y] == "R" || setMap[x, y] == "M" || setMap[x, y] == "r" || setMap[x, y] == "m" || setMap[x, y] == "F" || setMap[x, y] == "G" || setMap[x, y] == "f" || setMap[x, y] == "g")
                {
                    x = rng.Next(0, 20);
                    y = rng.Next(0, 20);
                }
                else
                {
                    blueTeamResources[count] = new ResourceBuilding(x, y, "Blue", 20, "G", "Wood", 3, 30);
                    setMap[x, y] = blueTeamResources[count].Symbol;
                    count++;
                    blueResources--;
                }
            }



            for (int i = 0; i <= 20; i++)
            {
                for (int j = 0; j <= 20; j++)
                {
                    map += setMap[i, j];
                }
                map += "\n";
                
            }

            return map;
        }

        public string moveUnit()
        {
            count = 0;
            int distance = 100;
            int closestX = 0;
            int closestY = 0;

            for (int i = 0; i <= blueMelee; i++)
            {
                

                for (int s = 1; s <= blueTeamMelee[i].Speed; s++)
                {
                    for (int j = 0; j < redTeamMelee.Length - 1; j++)
                    {
                        if (redTeamMelee[j].returnClosest(redTeamMelee[j].xPosition, redTeamMelee[j].yPosition, blueTeamMelee[i].xPosition, blueTeamMelee[i].yPosition) < distance)
                        {
                            distance = redTeamMelee[j].returnClosest(redTeamMelee[j].xPosition, redTeamMelee[j].yPosition, blueTeamMelee[i].xPosition, blueTeamMelee[i].yPosition);
                            closestX = redTeamMelee[j].xPosition;
                            closestY = redTeamMelee[j].yPosition;
                        }
                    }

                    for (int j = 0; j < redTeamRanged.Length - 1; j++)
                    {
                        if (redTeamRanged[j].returnClosest(redTeamRanged[j].xPosition, redTeamRanged[j].yPosition, blueTeamMelee[i].xPosition, blueTeamMelee[i].yPosition) < distance)
                        {
                            distance = redTeamRanged[j].returnClosest(redTeamRanged[j].xPosition, redTeamRanged[j].yPosition, blueTeamMelee[i].xPosition, blueTeamMelee[i].yPosition);
                            closestX = redTeamRanged[j].xPosition;
                            closestY = redTeamRanged[j].yPosition;
                        }
                    }

                    if ((closestX - blueTeamMelee[i].xPosition) > (closestY - blueTeamMelee[i].yPosition))
                    {
                        
                        int tempX = blueTeamMelee[i].xPosition;

                        if ((closestX - blueTeamMelee[i].xPosition) < 0)
                        {

                            if(blueTeamMelee[i].xPosition - 1 < 0)
                            {
                                blueTeamMelee[i].xPosition = 0;
                            }
                            else
                            {
                                blueTeamMelee[i].xPosition -= 1;
                            }

                        }
                        else if ((closestX - blueTeamMelee[i].xPosition) > 0)
                        {

                            if (blueTeamMelee[i].xPosition + 1 > 20)
                            {
                                blueTeamMelee[i].xPosition = 20;
                            }
                            else
                            {
                                blueTeamMelee[i].xPosition += 1;
                            }

                        }
                        else if ((closestX - blueTeamMelee[i].xPosition) <= blueTeamMelee[i].Range)
                        {
                            blueTeamMelee[i].xPosition += 0;
                        }
                        

                        setMap[tempX, blueTeamMelee[i].yPosition] = " . ";
                        setMap[blueTeamMelee[i].xPosition, blueTeamMelee[i].yPosition] = blueTeamMelee[i].Symbol;

                    }
                    else
                    {

                        int tempY = blueTeamMelee[i].yPosition;

                        if((closestY - blueTeamMelee[i].yPosition) <= 0)
                        {

                            if (blueTeamMelee[i].yPosition - 1 < 0)
                            {
                                blueTeamMelee[i].yPosition = 0;
                            }
                            else
                            {
                                blueTeamMelee[i].yPosition -= 1;
                            }

                        }
                        else if((closestY - blueTeamMelee[i].yPosition >= 0))
                        {

                            if (blueTeamMelee[i].yPosition + 1 > 20)
                            {
                                blueTeamMelee[i].yPosition = 20;
                            }
                            else
                            {
                                blueTeamMelee[i].yPosition -= 1;
                            }

                        }
                        else
                        {
                            blueTeamMelee[i].yPosition += 0;
                        }

                        

                        setMap[blueTeamMelee[i].xPosition, tempY] = " . ";
                        setMap[blueTeamMelee[i].xPosition, blueTeamMelee[i].yPosition] = blueTeamMelee[i].Symbol;

                    }
                }
                

            }
            
            for (int i = 0; i <= blueRangers; i++)
            {
                for (int j = 0; j <= redTeamMelee.Length - 1; j++)
                {
                    if (redTeamMelee[j].returnClosest(redTeamMelee[j].xPosition, redTeamMelee[j].yPosition, blueTeamRanged[i].xPosition, blueTeamRanged[i].yPosition) < distance)
                    {
                        distance = redTeamMelee[j].returnClosest(redTeamMelee[j].xPosition, redTeamMelee[j].yPosition, blueTeamRanged[i].xPosition, blueTeamRanged[i].yPosition);
                        closestX = redTeamMelee[j].xPosition;
                        closestY = redTeamMelee[j].yPosition;
                    }
                }

                for (int k = 0; k <= redTeamRanged.Length - 1; k++)
                {
                    if (redTeamRanged[k].returnClosest(redTeamRanged[k].xPosition, redTeamRanged[k].yPosition, blueTeamMelee[i].xPosition, blueTeamMelee[i].yPosition) < distance)
                    {
                        distance = redTeamRanged[k].returnClosest(redTeamRanged[k].xPosition, redTeamRanged[k].yPosition, blueTeamRanged[i].xPosition, blueTeamRanged[i].yPosition);
                        closestX = redTeamRanged[k].xPosition;
                        closestY = redTeamRanged[k].yPosition;
                    }
                }

                for (int s = 1; s <= blueTeamRanged[i].Speed; s++)
                {
                    if ((closestX - blueTeamRanged[i].xPosition) > (closestY - blueTeamRanged[i].yPosition))
                    {

                        int tempX = blueTeamRanged[i].xPosition;

                        if ((closestX - blueTeamRanged[i].xPosition) < 0)
                        {

                            if (blueTeamRanged[i].xPosition - 1 < 0)
                            {
                                blueTeamRanged[i].xPosition += 0;
                            }
                            else
                            {
                                blueTeamRanged[i].xPosition -= 1;
                            }

                        }
                        else if ((closestX - blueTeamRanged[i].xPosition) > 0)
                        {

                            if (blueTeamRanged[i].xPosition + 1 > 20)
                            {
                                blueTeamRanged[i].xPosition += 0;
                            }
                            else
                            {
                                blueTeamRanged[i].xPosition += 1;
                            }

                        }
                        else if ((closestX - blueTeamRanged[i].xPosition) <= blueTeamRanged[i].Range)
                        {
                            blueTeamRanged[i].xPosition += 0;
                        }


                        setMap[tempX, blueTeamRanged[i].yPosition] = " . ";
                        setMap[blueTeamRanged[i].xPosition, blueTeamRanged[i].yPosition] = blueTeamRanged[i].Symbol;

                    }
                    else
                    {

                        int tempY = blueTeamRanged[i].yPosition;

                        if ((closestY - blueTeamRanged[i].yPosition) < 0)
                        {

                            if (blueTeamRanged[i].yPosition - 1 < 0)
                            {
                                blueTeamRanged[i].yPosition += 0;
                            }
                            else
                            {
                                blueTeamRanged[i].yPosition -= 1;
                            }

                        }
                        else
                        {

                            if (blueTeamRanged[i].yPosition + 1 > 20)
                            {
                                blueTeamRanged[i].yPosition += 0;
                            }
                            else
                            {
                                blueTeamRanged[i].yPosition += 1;
                            }

                        }



                        setMap[blueTeamRanged[i].xPosition, tempY] = " . ";
                        setMap[blueTeamRanged[i].xPosition, blueTeamRanged[i].yPosition] = blueTeamRanged[i].Symbol;

                    }
                }


            }

            for (int i = 0; i <= redMelee; i++)
            {
                for (int j = 0; j <= blueTeamMelee.Length - 1; j++)
                {
                    if (blueTeamMelee[j].returnClosest(blueTeamMelee[j].xPosition, blueTeamMelee[j].yPosition, redTeamMelee[i].xPosition, redTeamMelee[i].yPosition) < distance)
                    {
                        distance = blueTeamMelee[j].returnClosest(blueTeamMelee[j].xPosition, blueTeamMelee[j].yPosition, redTeamMelee[i].xPosition, redTeamMelee[i].yPosition);
                        closestX = blueTeamMelee[j].xPosition;
                        closestY = blueTeamMelee[j].yPosition;
                    }
                }

                for (int j = 0; j <= blueTeamRanged.Length - 1; j++)
                {
                    if (blueTeamRanged[j].returnClosest(blueTeamRanged[j].xPosition, blueTeamRanged[j].yPosition, redTeamMelee[i].xPosition, redTeamMelee[i].yPosition) < distance)
                    {
                        distance = blueTeamRanged[j].returnClosest(blueTeamRanged[j].xPosition, blueTeamRanged[j].yPosition, redTeamMelee[i].xPosition, redTeamMelee[i].yPosition);
                        closestX = blueTeamRanged[j].xPosition;
                        closestY = blueTeamRanged[j].yPosition;
                    }
                }

                for (int s = 1; s <= redTeamMelee[i].Speed; s++)
                {
                    if ((closestX - redTeamMelee[i].xPosition) > (closestY - redTeamMelee[i].yPosition))
                    {

                        int tempX = redTeamMelee[i].xPosition;

                        if ((closestX - redTeamMelee[i].xPosition) < 0)
                        {

                            if (redTeamMelee[i].xPosition - 1 < 0)
                            {
                                redTeamMelee[i].xPosition += 0;
                            }
                            else
                            {
                                redTeamMelee[i].xPosition -= 1;
                            }

                        }
                        else if ((closestX - redTeamMelee[i].xPosition) > 0)
                        {

                            if (redTeamMelee[i].xPosition + 1 > 20)
                            {
                                redTeamMelee[i].xPosition += 0;
                            }
                            else
                            {
                                redTeamMelee[i].xPosition += 1;
                            }

                        }
                        else if ((closestX - redTeamMelee[i].xPosition) <= redTeamMelee[i].Range)
                        {
                            redTeamMelee[i].xPosition += 0;
                        }


                        setMap[tempX, redTeamMelee[i].yPosition] = " . ";
                        setMap[redTeamMelee[i].xPosition, redTeamMelee[i].yPosition] = redTeamMelee[i].Symbol;

                    }
                    else
                    {

                        int tempY = redTeamMelee[i].yPosition;

                        if ((closestY - redTeamMelee[i].yPosition) < 0)
                        {

                            if (redTeamMelee[i].yPosition - 1 < 0)
                            {
                                redTeamMelee[i].yPosition += 0;
                            }
                            else
                            {
                                redTeamMelee[i].yPosition -= 1;
                            }

                        }
                        else
                        {

                            if (redTeamMelee[i].yPosition + 1 > 20)
                            {
                                redTeamMelee[i].yPosition += 0;
                            }
                            else
                            {
                                redTeamMelee[i].yPosition += 1;
                            }

                        }



                        setMap[redTeamMelee[i].xPosition, tempY] = " . ";
                        setMap[redTeamMelee[i].xPosition, redTeamMelee[i].yPosition] = redTeamMelee[i].Symbol;

                    }
                }


            }

            for (int i = 0; i <= redRangers; i++)
            {
                for (int j = 0; j <= blueTeamMelee.Length - 1; j++)
                {
                    if (blueTeamMelee[j].returnClosest(blueTeamMelee[j].xPosition, blueTeamMelee[j].yPosition, redTeamRanged[i].xPosition, redTeamRanged[i].yPosition) < distance)
                    {
                        distance = blueTeamMelee[j].returnClosest(blueTeamMelee[j].xPosition, blueTeamMelee[j].yPosition, redTeamRanged[i].xPosition, redTeamRanged[i].yPosition);
                        closestX = blueTeamMelee[j].xPosition;
                        closestY = blueTeamMelee[j].yPosition;
                    }
                }

                for (int j = 0; j <= blueTeamRanged.Length - 1; j++)
                {
                    if (blueTeamRanged[j].returnClosest(blueTeamRanged[j].xPosition, blueTeamRanged[j].yPosition, redTeamRanged[i].xPosition, redTeamRanged[i].yPosition) < distance)
                    {
                        distance = blueTeamRanged[j].returnClosest(blueTeamRanged[j].xPosition, blueTeamRanged[j].yPosition, redTeamRanged[i].xPosition, redTeamRanged[i].yPosition);
                        closestX = blueTeamRanged[j].xPosition;
                        closestY = blueTeamRanged[j].yPosition;
                    }
                }

                for (int s = 1; s <= redTeamRanged[i].Speed; s++)
                {
                    if ((closestX - redTeamRanged[i].xPosition) > (closestY - redTeamRanged[i].yPosition))
                    {

                        int tempX = redTeamRanged[i].xPosition;

                        if ((closestX - redTeamRanged[i].xPosition) < 0)
                        {

                            redTeamRanged[i].xPosition -= 1;

                        }
                        else if ((closestX - redTeamRanged[i].xPosition) > 0)
                        {

                            redTeamRanged[i].xPosition += 1;

                        }
                        else if ((closestX - redTeamRanged[i].xPosition) <= redTeamRanged[i].Range)
                        {
                            redTeamRanged[i].xPosition += 0;
                        }


                        setMap[tempX, redTeamRanged[i].yPosition] = " . ";
                        setMap[redTeamRanged[i].xPosition, redTeamRanged[i].yPosition] = redTeamRanged[i].Symbol;

                    }
                    else
                    {

                        int tempY = redTeamRanged[i].yPosition;

                        if ((closestY - redTeamRanged[i].yPosition) < 0)
                        {

                            redTeamRanged[i].yPosition -= 1;

                        }
                        else
                        {

                            redTeamRanged[i].yPosition += 1;

                        }



                        setMap[redTeamRanged[i].xPosition, tempY] = " . ";
                        setMap[redTeamRanged[i].xPosition, redTeamRanged[i].yPosition] = redTeamRanged[i].Symbol;

                    }
                }


            }
            
            string map = "";

            for (int i = 0; i <= 20; i++)
            {
                for (int j = 0; j <= 20; j++)
                {
                    map += setMap[i, j];
                }
                map += "\n";

            }

            return map;
        }

        public void spawnUnit()
        {
            for (int i = 0; i < 21; i++)
            {
                for (int j = 0; j < 21; j++)
                {
                    if(setMap[i,j] == "f")
                    {
                        for (int k = 0; k < redTeamFactories.Length - 1; k++)
                        {
                            setMap[redTeamFactories[k].spawnRedUnit().xPosition, redTeamFactories[k].spawnRedUnit().yPosition] = redTeamFactories[k].spawnRedUnit().Symbol;
                        }
                    }
                    else if(setMap[i,j] == "F")
                    {
                        for (int k = 0; k < blueTeamFactories.Length - 1; k++)
                        {
                            setMap[blueTeamFactories[k].spawnRedUnit().xPosition, blueTeamFactories[k].spawnRedUnit().yPosition] = blueTeamFactories[k].spawnRedUnit().Symbol;
                        }

                    }
                }
            }
        }

        public void saveInfo()
        {
            int count = 0;

            #region Open the File
            FileStream outRedMelee = new FileStream(@"Files\\redMelee.txt",
            FileMode.Create, FileAccess.Write);
            StreamWriter writerRedMelee = new StreamWriter(outRedMelee);

            FileStream outRedRanged = new FileStream(@"Files\\redRanged.txt",
            FileMode.Create, FileAccess.Write);
            StreamWriter writerRedRanged = new StreamWriter(outRedRanged);

            FileStream outBlueMelee = new FileStream(@"Files\\blueMelee.txt",
            FileMode.Create, FileAccess.Write);
            StreamWriter writerBlueMelee = new StreamWriter(outBlueMelee);

            FileStream outBlueRanged = new FileStream(@"Files\\blueRanged.txt",
            FileMode.Create, FileAccess.Write);
            StreamWriter writerBlueRanged = new StreamWriter(outBlueRanged);

            FileStream outBlueFactory = new FileStream(@"Files\\blueFactory.txt",
            FileMode.Create, FileAccess.Write);
            StreamWriter writerBlueFactory = new StreamWriter(outBlueFactory);

            FileStream outRedFactory = new FileStream(@"Files\\redFactory.txt",
            FileMode.Create, FileAccess.Write);
            StreamWriter writerRedFactory = new StreamWriter(outRedFactory);

            FileStream outBlueResources = new FileStream(@"Files\\blueResources.txt",
            FileMode.Create, FileAccess.Write);
            StreamWriter writerBlueResources = new StreamWriter(outBlueResources);

            FileStream outRedResources = new FileStream(@"Files\\redResources.txt",
            FileMode.Create, FileAccess.Write);
            StreamWriter writerRedResources = new StreamWriter(outRedResources);

            FileStream outUnitsAmount = new FileStream(@"Files\\unitsAmount.txt",
            FileMode.Create, FileAccess.Write);
            StreamWriter writerUnitsAmount = new StreamWriter(outUnitsAmount);

            FileStream outRedHealer = new FileStream(@"Files\\redHealer.txt",
            FileMode.Create, FileAccess.Write);
            StreamWriter writerRedHealer = new StreamWriter(outRedHealer);

            FileStream outBlueHealer = new FileStream(@"Files\\blueHealer.txt",
            FileMode.Create, FileAccess.Write);
            StreamWriter writerBlueHealer = new StreamWriter(outBlueHealer);

            FileStream outRedRepair = new FileStream(@"Files\\redRepair.txt",
            FileMode.Create, FileAccess.Write);
            StreamWriter writerRedRepair = new StreamWriter(outRedRepair);

            FileStream outBlueRepair = new FileStream(@"Files\\blueRepair.txt",
            FileMode.Create, FileAccess.Write);
            StreamWriter writerBlueRepair = new StreamWriter(outBlueRepair);

            FileStream outRedArtillery = new FileStream(@"Files\\redArtillery.txt",
            FileMode.Create, FileAccess.Write);
            StreamWriter writerRedArtillery = new StreamWriter(outRedArtillery);

            FileStream outBlueArtillery = new FileStream(@"Files\\blueArtillery.txt",
            FileMode.Create, FileAccess.Write);
            StreamWriter writerBlueArtillery = new StreamWriter(outBlueArtillery);
            #endregion


            // write to the file
            #region Write Red Melee
            for (int i = 0; i < redTeamMelee.Length - 1; i++)
            {
                writerRedMelee.WriteLine(redTeamMelee[i].xPosition);
                writerRedMelee.WriteLine(redTeamMelee[i].yPosition);
                writerRedMelee.WriteLine(redTeamMelee[i].Health);
                writerRedMelee.WriteLine(redTeamMelee[i].Attack);
                writerRedMelee.WriteLine(redTeamMelee[i].Speed);
                writerRedMelee.WriteLine(redTeamMelee[i].Faction);
                writerRedMelee.WriteLine(redTeamMelee[i].Symbol);
                writerRedMelee.WriteLine(redTeamMelee[i].Name);
                count++;
            }

            writerUnitsAmount.WriteLine(count);
            #endregion

            #region Write Red Ranged

            count = 0;
            for (int i = 0; i < redTeamRanged.Length - 1; i++)
            {

                writerRedRanged.WriteLine(redTeamRanged[i].xPosition);
                writerRedRanged.WriteLine(redTeamRanged[i].yPosition);
                writerRedRanged.WriteLine(redTeamRanged[i].Health);
                writerRedRanged.WriteLine(redTeamRanged[i].Attack);
                writerRedRanged.WriteLine(redTeamRanged[i].Range);
                writerRedRanged.WriteLine(redTeamRanged[i].Speed);
                writerRedRanged.WriteLine(redTeamRanged[i].Faction);
                writerRedRanged.WriteLine(redTeamRanged[i].Symbol);
                writerRedRanged.WriteLine(redTeamRanged[i].Name);
                count++;
            }

            writerUnitsAmount.WriteLine(count);
            #endregion

            #region Write Blue Melee

            count = 0;
            for (int i = 0; i < blueTeamMelee.Length - 1; i++)
            {
                writerBlueMelee.WriteLine(blueTeamMelee[i].xPosition);
                writerBlueMelee.WriteLine(blueTeamMelee[i].yPosition);
                writerBlueMelee.WriteLine(blueTeamMelee[i].Health);
                writerBlueMelee.WriteLine(blueTeamMelee[i].Attack);
                writerBlueMelee.WriteLine(blueTeamMelee[i].Speed);
                writerBlueMelee.WriteLine(blueTeamMelee[i].Faction);
                writerBlueMelee.WriteLine(blueTeamMelee[i].Symbol);
                writerBlueMelee.WriteLine(blueTeamMelee[i].Name);
                count++;
            }

            writerUnitsAmount.WriteLine(count);
            #endregion

            #region Write Blue Ranged

            count = 0;
            for (int i = 0; i < blueTeamRanged.Length - 1; i++)
            {
                writerBlueRanged.WriteLine(blueTeamRanged[i].xPosition);
                writerBlueRanged.WriteLine(blueTeamRanged[i].yPosition);
                writerBlueRanged.WriteLine(blueTeamRanged[i].Health);
                writerBlueRanged.WriteLine(blueTeamRanged[i].Attack);
                writerBlueRanged.WriteLine(blueTeamRanged[i].Range);
                writerBlueRanged.WriteLine(blueTeamRanged[i].Speed);
                writerBlueRanged.WriteLine(blueTeamRanged[i].Faction);
                writerBlueRanged.WriteLine(blueTeamRanged[i].Symbol);
                writerBlueRanged.WriteLine(blueTeamRanged[i].Name);
                count++;
            }

            writerUnitsAmount.WriteLine(count);
            #endregion

            #region Write Blue Factory

            count = 0;
            for (int i = 0; i < blueTeamFactories.Length - 1; i++)
            {
                writerBlueFactory.WriteLine(blueTeamFactories[i].xPosition);
                writerBlueFactory.WriteLine(blueTeamFactories[i].yPosition);
                writerBlueFactory.WriteLine(blueTeamFactories[i].Faction);
                writerBlueFactory.WriteLine(blueTeamFactories[i].Health);
                writerBlueFactory.WriteLine(blueTeamFactories[i].Symbol);
                writerBlueFactory.WriteLine(blueTeamFactories[i].UnitsAmount);
                writerBlueFactory.WriteLine(blueTeamFactories[i].UnitsPerTick);
                writerBlueFactory.WriteLine(blueTeamFactories[i].SpawnX);
                writerBlueFactory.WriteLine(blueTeamFactories[i].SpawnY);
                count++;
            }

            writerUnitsAmount.WriteLine(count);
            #endregion

            #region Write Red Factory

            count = 0;
            for (int i = 0; i < redTeamFactories.Length - 1; i++)
            {
                writerBlueFactory.WriteLine(blueTeamFactories[i].xPosition);
                writerBlueFactory.WriteLine(blueTeamFactories[i].yPosition);
                writerBlueFactory.WriteLine(blueTeamFactories[i].Faction);
                writerBlueFactory.WriteLine(blueTeamFactories[i].Health);
                writerBlueFactory.WriteLine(blueTeamFactories[i].Symbol);
                writerBlueFactory.WriteLine(blueTeamFactories[i].UnitsAmount);
                writerBlueFactory.WriteLine(blueTeamFactories[i].UnitsPerTick);
                writerBlueFactory.WriteLine(blueTeamFactories[i].SpawnX);
                writerBlueFactory.WriteLine(blueTeamFactories[i].SpawnY);
                count++;
            }

            writerUnitsAmount.WriteLine(count);
            #endregion

            #region Write Red Resources

            count = 0;
            for (int i = 0; i < redTeamResources.Length - 1; i++)
            {
                writerRedResources.WriteLine(redTeamResources[i].xPosition);
                writerRedResources.WriteLine(redTeamResources[i].yPosition);
                writerRedResources.WriteLine(redTeamResources[i].Faction);
                writerRedResources.WriteLine(redTeamResources[i].Health);
                writerRedResources.WriteLine(redTeamResources[i].Symbol);
                writerRedResources.WriteLine(redTeamResources[i].ResourceType);
                writerRedResources.WriteLine(redTeamResources[i].ResourcesPerTick);
                writerRedResources.WriteLine(redTeamResources[i].ResourcesRemaining);
                count++;
            }

            writerUnitsAmount.WriteLine(count);
            #endregion

            #region Write Blue Resources

            count = 0;
            for (int i = 0; i < blueTeamResources.Length - 1; i++)
            {
                writerBlueResources.WriteLine(blueTeamResources[i].xPosition);
                writerBlueResources.WriteLine(blueTeamResources[i].yPosition);
                writerBlueResources.WriteLine(blueTeamResources[i].Faction);
                writerBlueResources.WriteLine(blueTeamResources[i].Health);
                writerBlueResources.WriteLine(blueTeamResources[i].Symbol);
                writerBlueResources.WriteLine(blueTeamResources[i].ResourceType);
                writerBlueResources.WriteLine(blueTeamResources[i].ResourcesPerTick);
                writerBlueResources.WriteLine(blueTeamResources[i].ResourcesRemaining);
                count++;
            }

            writerUnitsAmount.WriteLine(count);
            #endregion

            #region Write Red Healer

            count = 0;
            for (int i = 0; i < redTeamHealer.Length - 1; i++)
            {

                writerRedHealer.WriteLine(redTeamHealer[i].xPosition);
                writerRedHealer.WriteLine(redTeamHealer[i].yPosition);
                writerRedHealer.WriteLine(redTeamHealer[i].Health);
                writerRedHealer.WriteLine(redTeamHealer[i].Attack);
                writerRedHealer.WriteLine(redTeamHealer[i].Range);
                writerRedHealer.WriteLine(redTeamHealer[i].Speed);
                writerRedHealer.WriteLine(redTeamHealer[i].Faction);
                writerRedHealer.WriteLine(redTeamHealer[i].Symbol);
                writerRedHealer.WriteLine(redTeamHealer[i].Name);
                count++;
            }

            #endregion

            #region Write Blue Healer

            count = 0;
            for (int i = 0; i < blueTeamHealer.Length - 1; i++)
            {

                writerBlueHealer.WriteLine(blueTeamHealer[i].xPosition);
                writerBlueHealer.WriteLine(blueTeamHealer[i].yPosition);
                writerBlueHealer.WriteLine(blueTeamHealer[i].Health);
                writerBlueHealer.WriteLine(blueTeamHealer[i].Attack);
                writerBlueHealer.WriteLine(blueTeamHealer[i].Range);
                writerBlueHealer.WriteLine(blueTeamHealer[i].Speed);
                writerBlueHealer.WriteLine(blueTeamHealer[i].Faction);
                writerBlueHealer.WriteLine(blueTeamHealer[i].Symbol);
                writerBlueHealer.WriteLine(blueTeamHealer[i].Name);
                count++;
            }

            #endregion

            #region Write Red Repair

            count = 0;
            for (int i = 0; i < redTeamRepair.Length - 1; i++)
            {

                writerRedRepair.WriteLine(redTeamRepair[i].xPosition);
                writerRedRepair.WriteLine(redTeamRepair[i].yPosition);
                writerRedRepair.WriteLine(redTeamRepair[i].Health);
                writerRedRepair.WriteLine(redTeamRepair[i].Attack);
                writerRedRepair.WriteLine(redTeamRepair[i].Range);
                writerRedRepair.WriteLine(redTeamRepair[i].Speed);
                writerRedRepair.WriteLine(redTeamRepair[i].Faction);
                writerRedRepair.WriteLine(redTeamRepair[i].Symbol);
                writerRedRepair.WriteLine(redTeamRepair[i].Name);
                count++;
            }

            #endregion

            #region Write Blue Repair

            count = 0;
            for (int i = 0; i < blueTeamRepair.Length - 1; i++)
            {

                writerBlueRepair.WriteLine(blueTeamRepair[i].xPosition);
                writerBlueRepair.WriteLine(blueTeamRepair[i].yPosition);
                writerBlueRepair.WriteLine(blueTeamRepair[i].Health);
                writerBlueRepair.WriteLine(blueTeamRepair[i].Attack);
                writerBlueRepair.WriteLine(blueTeamRepair[i].Range);
                writerBlueRepair.WriteLine(blueTeamRepair[i].Speed);
                writerBlueRepair.WriteLine(blueTeamRepair[i].Faction);
                writerBlueRepair.WriteLine(blueTeamRepair[i].Symbol);
                writerBlueRepair.WriteLine(blueTeamRepair[i].Name);
                count++;
            }

            #endregion

            #region Write Red Artillery

            count = 0;
            for (int i = 0; i < redTeamArtillery.Length - 1; i++)
            {

                writerRedArtillery.WriteLine(redTeamArtillery[i].xPosition);
                writerRedArtillery.WriteLine(redTeamArtillery[i].yPosition);
                writerRedArtillery.WriteLine(redTeamArtillery[i].Health);
                writerRedArtillery.WriteLine(redTeamArtillery[i].Attack);
                writerRedArtillery.WriteLine(redTeamArtillery[i].Range);
                writerRedArtillery.WriteLine(redTeamArtillery[i].Speed);
                writerRedArtillery.WriteLine(redTeamArtillery[i].Faction);
                writerRedArtillery.WriteLine(redTeamArtillery[i].Symbol);
                writerRedArtillery.WriteLine(redTeamArtillery[i].Name);
                count++;
            }

            #endregion

            #region Write Blue Artillery

            count = 0;
            for (int i = 0; i < blueTeamArtillery.Length - 1; i++)
            {

                writerBlueArtillery.WriteLine(blueTeamArtillery[i].xPosition);
                writerBlueArtillery.WriteLine(blueTeamArtillery[i].yPosition);
                writerBlueArtillery.WriteLine(blueTeamArtillery[i].Health);
                writerBlueArtillery.WriteLine(blueTeamArtillery[i].Attack);
                writerBlueArtillery.WriteLine(blueTeamArtillery[i].Range);
                writerBlueArtillery.WriteLine(blueTeamArtillery[i].Speed);
                writerBlueArtillery.WriteLine(blueTeamArtillery[i].Faction);
                writerBlueArtillery.WriteLine(blueTeamArtillery[i].Symbol);
                writerBlueArtillery.WriteLine(blueTeamArtillery[i].Name);
                count++;
            }

            #endregion

            // close the file

            #region Close Files

            writerBlueFactory.Close();
            outBlueFactory.Close();

            writerBlueResources.Close();
            outBlueResources.Close();

            writerBlueMelee.Close();
            outBlueMelee.Close();

            writerBlueRanged.Close();
            outBlueRanged.Close();

            writerBlueHealer.Close();
            outBlueHealer.Close();

            writerBlueArtillery.Close();
            outBlueArtillery.Close();

            writerBlueRepair.Close();
            outBlueRepair.Close();

            writerRedFactory.Close();
            outRedFactory.Close();

            writerRedResources.Close();
            outRedResources.Close();

            writerRedMelee.Close();
            outRedMelee.Close();

            writerRedRanged.Close();
            outRedRanged.Close();

            writerRedHealer.Close();
            outBlueHealer.Close();

            writerRedArtillery.Close();
            outBlueArtillery.Close();

            writerRedRepair.Close();
            outBlueRepair.Close();

            writerUnitsAmount.Close();
            outUnitsAmount.Close();

            #endregion
        }
        
        public string loadInfo()
        {
            FileStream inFile = null;
            StreamReader reader = null;

            string input;
            string map = "";

            int redMeleeAmount = 0;
            int redRangedAmount = 0;
            int blueMeleeAmount = 0;
            int blueRangedAmount = 0;
            int blueFactoryAmount = 0;
            int redFactoryAmount = 0;
            int redResourcesAmount = 0;
            int blueResourcesAmount = 0;

            try
            {
                inFile = new FileStream(@"Files\\unitsAmount.txt", FileMode.Open, FileAccess.Read);
                reader = new StreamReader(inFile);
                input = reader.ReadLine();
                while (input != null)
                {
                    redMeleeAmount = int.Parse(input);
                    redRangedAmount = int.Parse(input);
                    blueMeleeAmount = int.Parse(input);
                    blueRangedAmount = int.Parse(input);
                    blueFactoryAmount = int.Parse(input);
                    redFactoryAmount = int.Parse(input);
                    redResourcesAmount = int.Parse(input);
                    blueResourcesAmount = int.Parse(input);


                    input = reader.ReadLine();      // secondary read
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

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    setMap[i, j] = " . ";
                }
            }

            for (int i = 0; i < redMeleeAmount; i++)
            {
                redTeamMelee[i].loadRed();
            }

            

            int length;
            string line;

                
            for (int i = 0; i <= 20; i++)
            {
                for (int j = 0; j <= 20; j++)
                {
                    map += setMap[i, j];
                }
                map += "\n";

            }
            
            
            return map;

        }
        
        public void traitorUnit()
        {
            string map = "";
            int faction = rng.Next(1, 3);
            int type = rng.Next(1, 6);

            if (faction == 1)
            {
                if (type == 1)
                {
                    int traitor = rng.Next(1, redMelee + 1);

                    for (int i = 0; i < redMelee; i++)
                    {
                        if (i == traitor)
                        {
                            redTeamMelee[i].Faction = "Blue";
                            redTeamMelee[i].Symbol = "M";
                        }
                    }
                }
                else
                {
                    if (type == 2)
                    {
                        int traitor = rng.Next(1, redRangers + 1);

                        for (int i = 0; i < redRangers; i++)
                        {
                            if (i == traitor)
                            {
                                redTeamRanged[i].Faction = "Blue";
                                redTeamRanged[i].Symbol = "R";
                            }
                        }
                    }
                    else
                    {
                        if(type == 3)
                        {
                            int traitor = rng.Next(1, redHealers + 1);

                            for (int i = 0; i < redHealers; i++)
                            {
                                if (i == traitor)
                                {
                                    redTeamHealer[i].Faction = "Blue";
                                    redTeamHealer[i].Symbol = "H";
                                }
                            }
                        }
                        else
                        {
                            if (type == 4)
                            {
                                int traitor = rng.Next(1, redArtillery + 1);

                                for (int i = 0; i < redArtillery; i++)
                                {
                                    if (i == traitor)
                                    {
                                        redTeamArtillery[i].Faction = "Blue";
                                        redTeamArtillery[i].Symbol = "A";
                                    }
                                }
                            }
                            else
                            {
                                int traitor = rng.Next(1, redRepair + 1);

                                for (int i = 0; i < redRepair; i++)
                                {
                                    if (i == traitor)
                                    {
                                        redTeamRepair[i].Faction = "Blue";
                                        redTeamRepair[i].Symbol = "P";
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                if (type == 1)
                {
                    int traitor = rng.Next(1, blueMelee + 1);

                    for (int i = 0; i < blueMelee; i++)
                    {
                        if (i == traitor)
                        {
                            blueTeamMelee[i].Faction = "Red";
                            blueTeamMelee[i].Symbol = "m";
                        }
                    }
                }
                else
                {
                    if (type == 2)
                    {
                        int traitor = rng.Next(1, blueRangers + 1);

                        for (int i = 0; i < blueRangers; i++)
                        {
                            if (i == traitor)
                            {
                                blueTeamRanged[i].Faction = "Red";
                                blueTeamRanged[i].Symbol = "r";
                            }
                        }
                    }
                    else
                    {
                        if (type == 3)
                        {
                            int traitor = rng.Next(1, blueHealers + 1);

                            for (int i = 0; i < blueHealers; i++)
                            {
                                if (i == traitor)
                                {
                                    blueTeamHealer[i].Faction = "Red";
                                    blueTeamHealer[i].Symbol = "h";
                                }
                            }
                        }
                        else
                        {
                            if (type == 4)
                            {
                                int traitor = rng.Next(1, blueArtillery + 1);

                                for (int i = 0; i < blueArtillery; i++)
                                {
                                    if (i == traitor)
                                    {
                                        blueTeamArtillery[i].Faction = "Red";
                                        blueTeamArtillery[i].Symbol = "a";
                                    }
                                }
                            }
                            else
                            {
                                int traitor = rng.Next(1, blueRepair + 1);

                                for (int i = 0; i < blueRepair; i++)
                                {
                                    if (i == traitor)
                                    {
                                        blueTeamRepair[i].Faction = "Red";
                                        blueTeamRepair[i].Symbol = "p";
                                    }
                                }
                            }
                        }
                    }
                }
            }

            for (int i = 0; i <= 20; i++)
            {
                for (int j = 0; j <= 20; j++)
                {
                    map += setMap[i, j];
                }
                map += "\n";

            }

        }
        public void updateUnit()
        {

        }
    }
}
