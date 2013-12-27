using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameanite_JSON_Creater.Model
{
    public class Cards
    {

        private List<Card> cards;

        public Cards()
        {
            cards = new List<Card>();
        }


        public Card GetCard(int y,int x){
            foreach (var card in cards)
            {
                if (card.PosX == x && card.PosY == y)
                {
                    return card;
                }
            }
            return null;
        }

        public void SetCard(Card card,int posX,int posY)
        {
            card.PosX = posX;
            card.PosY = posY;
            cards.Add(card);
        }

        public List<Card> GetAllCards()
        {
            return cards;
        }
    }
}
