using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swart_Simon_17611447_Task_1
{
    class GameEngine : Unit
    {

        Map m = new Map();

        public string movementUnits()
        {
            return m.moveUnit();
        }


    }
}
