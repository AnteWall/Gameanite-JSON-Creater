using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gameanite_JSON_Creater.Model
{
    public class Card
    {
        public String Title
        {
            get;
            set;
        }
        public String Description
        {
            get;
            set;
        }
        public int PosX
        {
            get;
            set;
        }
        public int PosY
        {
            get;
            set;
        }
        public int NextX
        {
            get;
            set;
        }
        public int NextY
        {
            get;
            set;
        }
        public String function
        {
            get;
            set;
        }


        public Card()
        {
            Title = "New Card";
            Description = "No Description";
            NextX = 0;
            NextY = 0;

        }
    }
}
