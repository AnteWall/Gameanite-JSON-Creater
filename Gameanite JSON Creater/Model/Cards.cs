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

        public void LoadCard(Card c){
            cards.Add(c);
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
            if (GetCard(posY, posX) == null)
            {
                card.PosX = posX;
                card.PosY = posY;
                cards.Add(card);
            }
            else
            {
                System.Diagnostics.Debug.Print("Card Existed!, Replacing...");
                var i = cards.FindIndex(x => x.PosX == posX && x.PosY == posY);
                System.Diagnostics.Debug.Print("Index: " + i);
                card.PosX = posX;
                card.PosY = posY;
                cards[i] = card;
            }
            
        }

        public List<Card> GetAllCards()
        {
            return cards;
        }
    }
}
