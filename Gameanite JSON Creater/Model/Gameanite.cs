using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameanite_JSON_Creater.Model
{
    public class Gameanite : INotifyPropertyChanged
    {
        public int GameBoardHeight { get; set; }
        public int GameBoardWidth { get; set; }
        private CardPosition _selectedCardPos;
        public CardPosition SelectedPosition
        {
            get { return _selectedCardPos; }
            set { _selectedCardPos = value; }
        }

        public Cards Cards
        {
            get;
            set;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private Controls.GameField gameField;

        public Gameanite(int height,int width)
        {
            SelectedPosition = new CardPosition(0, 0);
            Cards = new Cards();
        }

        public Gameanite(Controls.GameField gameField, int p1, int p2)
        {
            // TODO: Complete member initialization
            this.gameField = gameField;
            SelectedPosition = new CardPosition(0, 0);
            Cards = new Cards();
        }

        public void ChangeCurrentCard()
        {
            
        }

        public void SaveCard(Card newCard)
        {

            Cards.SetCard(newCard, SelectedPosition.PosX, SelectedPosition.PosY);
            gameField.DrawCreatedCard(SelectedPosition.PosX,SelectedPosition.PosY);
        }

        private void OnPropertyChanged(string property)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(property));
        }
    }
}
