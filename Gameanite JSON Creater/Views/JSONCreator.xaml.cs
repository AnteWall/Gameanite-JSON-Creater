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

namespace Gameanite_JSON_Creater.Views
{
    /// <summary>
    /// Interaction logic for JSONCreator.xaml
    /// </summary>
    public partial class JSONCreator : UserControl
    {
        public static readonly DependencyProperty GameaniteProperty = DependencyProperty.Register("Gameanite", typeof(Model.Gameanite), typeof(JSONCreator), new PropertyMetadata(new PropertyChangedCallback(Gameanite_Changes)));
        public static readonly DependencyProperty SelectedCardProperty = DependencyProperty.Register("SelectedCard", typeof(Model.Card), typeof(JSONCreator), new PropertyMetadata(new PropertyChangedCallback(SelectedCard_Changed)));

        private static void SelectedCard_Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var _this = d as Views.JSONCreator;
            _this.DataContext = _this.SelectedCard;
        }

        private static void Gameanite_Changes(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var _this = d as Views.JSONCreator;
            _this.DataContext = _this.Gameanite;           
        }

        public Model.Card SelectedCard
        {
            get { return (Model.Card)GetValue(SelectedCardProperty); }
            set { SetValue(SelectedCardProperty, value); }
        }

        public Model.Gameanite Gameanite
        {
            get { return (Model.Gameanite)GetValue(GameaniteProperty); }
            set { SetValue(GameaniteProperty, value); }
        }
        public JSONCreator()
        {
            InitializeComponent();
            Gameanite = new Model.Gameanite(gameField, 0, 0);
            
        }

        public void NewFile(int height, int width)
        {
            gameField.UpdateGridSize(height, width);
            Gameanite = new Model.Gameanite(gameField,height,width);
            Gameanite.GameBoardHeight = height;
            Gameanite.GameBoardWidth = width;
        }
    }
}
