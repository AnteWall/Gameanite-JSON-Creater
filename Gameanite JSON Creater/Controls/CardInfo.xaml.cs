using Gameanite_JSON_Creater.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Gameanite_JSON_Creater.Controls
{
    /// <summary>
    /// Interaction logic for CardInfo.xaml
    /// </summary>
    public partial class CardInfo : UserControl
    {
        public static readonly DependencyProperty GameaniteProperty = DependencyProperty.Register("Gameanite", typeof(Model.Gameanite), typeof(CardInfo), new PropertyMetadata(new PropertyChangedCallback(Gameanite_Changed)));

        


        public Gameanite_JSON_Creater.Model.Gameanite Gameanite
        {
            get { return (Model.Gameanite)GetValue(GameaniteProperty); }
            set { SetValue(GameaniteProperty, value); }
        }


        public CardInfo()
        {
            InitializeComponent();
        }

        private void SaveCardBtn_Click(object sender, RoutedEventArgs e)
        {
            Card newCard = new Card();

            newCard.Title = titleBox.Text;
            newCard.Description = descriptionBox.Text;
            newCard.NextX = int.Parse(nextXBox.Text);
            newCard.NextY = int.Parse(nextYBox.Text);
            Gameanite.SaveCard(newCard);
        }

        private static void Gameanite_Changed(DependencyObject sender, DependencyPropertyChangedEventArgs args)
        {
            var __this = sender as Controls.CardInfo;

            if (__this != null)
            {
                var __gameanite = (Model.Gameanite)args.NewValue;
            }
        }
    }
}
