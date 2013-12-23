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
    /// Interaction logic for GameField.xaml
    /// </summary>
    public partial class GameField : UserControl
    {
        public static readonly DependencyProperty GameaniteProperty = DependencyProperty.Register("Gameanite", typeof(Model.Gameanite), typeof(GameField), new PropertyMetadata(new PropertyChangedCallback(Gameanite_Changed)));

        public Gameanite_JSON_Creater.Model.Gameanite Gameanite
        {
            get { return (Model.Gameanite)GetValue(GameaniteProperty); }
            set { SetValue(GameaniteProperty, value); }
        }

        public GameField()
        {
            InitializeComponent();
            
        }

        public void UpdateDatagridSize(int height,int width)
        {
            int squareLength = 30;
            for (int gY = 0; gY < height; gY++)
            {
                RowDefinition row = new RowDefinition();
                row.Height = new GridLength(squareLength);
                dataGrid.RowDefinitions.Add(row);
            }
            for (int gX = 0; gX < width; gX++)
            {
                ColumnDefinition column = new ColumnDefinition();
                column.Width = new GridLength(squareLength);
                dataGrid.ColumnDefinitions.Add(column);
            }
            for (int y = 0; y < dataGrid.RowDefinitions.Count(); y++)
            {
                
                for (int x = 0; x < dataGrid.ColumnDefinitions.Count(); x++)
                {
                    System.Diagnostics.Debug.Print("X:" + x + " Y: " + y);
                    Label l = new Label();
                    l.Background = new SolidColorBrush(Colors.White);
                    l.BorderBrush = new SolidColorBrush(Colors.Gray);
                    l.BorderThickness = new Thickness(1);
                    l.MouseDoubleClick += new MouseButtonEventHandler(GetCardOnPosition);
                    dataGrid.Children.Add(l);
                    Grid.SetRow(l, y);
                    Grid.SetColumn(l, x);
                }
            }


            
        }

        public void DrawCreatedCard(int posx,int posy)
        {
           var _label = dataGrid.Children.Cast<Control>().Where(e => Grid.GetRow(e) == posy
                && Grid.GetColumn(e) == posx).Single();

           _label.Background = new SolidColorBrush(Colors.Green);
        }

        private void ClearPrevClicked()
        {
            var _prevLabel = dataGrid.Children.Cast<Control>().Where(e => Grid.GetRow(e) == Gameanite.SelectedPosition.PosY
                && Grid.GetColumn(e) == Gameanite.SelectedPosition.PosX).Single();

            _prevLabel.BorderBrush = new SolidColorBrush(Colors.Gray);
            _prevLabel.BorderThickness = new Thickness(1);
        }

        private void GetCardOnPosition(object sender, RoutedEventArgs arg)
        {
            ClearPrevClicked();
            Label _lbl = sender as Label;

            int _row = (int)_lbl.GetValue(Grid.RowProperty);
            int _column = (int)_lbl.GetValue(Grid.ColumnProperty);

            var _uiParts = dataGrid.Children.Cast<Control>().Where(e => Grid.GetRow(e) == _row && Grid.GetColumn(e) == _column).Single();

            _uiParts.BorderBrush = new SolidColorBrush(Colors.Red);
            _uiParts.BorderThickness = new Thickness(3);

            Gameanite.SelectedPosition = new CardPosition(_column, _row);
            System.Diagnostics.Debug.Print(Gameanite.SelectedPosition.PosX.ToString());

            MessageBox.Show(string.Format("Button clicked at column {0}, row {1}", _column, _row));
        }

        private static void Gameanite_Changed(DependencyObject sender, DependencyPropertyChangedEventArgs args)
        {
            var __this = sender as Controls.GameField;

            if (__this != null)
            {
                var __gameanite = (Model.Gameanite)args.NewValue;
            }
        }

    }
}
