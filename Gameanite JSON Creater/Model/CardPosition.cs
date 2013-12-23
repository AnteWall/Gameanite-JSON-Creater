using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameanite_JSON_Creater.Model
{
    public class CardPosition
    {
        public int PosX { get; set; }
        public int PosY { get; set; }

        public CardPosition(int x, int y)
        {
            PosX = x;
            PosY = y;
        }
    }
}
