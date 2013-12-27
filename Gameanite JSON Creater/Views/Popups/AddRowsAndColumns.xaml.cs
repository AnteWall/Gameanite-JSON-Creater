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
using System.Windows.Shapes;

namespace Gameanite_JSON_Creater.Views.Popups
{
    /// <summary>
    /// Interaction logic for AddRowsAndColumns.xaml
    /// </summary>
    public partial class AddRowsAndColumns : Window
    {
        private Controls.GameField gameField;
        private JSONCreator jSONCreator;
        private Model.Gameanite Gameanite;

        public AddRowsAndColumns(Controls.GameField gameField, JSONCreator jSONCreator, Model.Gameanite Gameanite)
        {
            InitializeComponent(); 
            this.gameField = gameField;
            this.jSONCreator = jSONCreator;
            this.Gameanite = Gameanite;
        }

        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            int newHeight = 0;
            int newWidth = 0;
            bool result = Int32.TryParse(addRowsBox.Text, out newHeight);
            if (result)
            {
                result = Int32.TryParse(addColumnsBox.Text, out newWidth);
                if (result)
                {
                    gameField.AddRowsandColumns(newHeight, newWidth);
                    Gameanite.GameBoardHeight = Gameanite.GameBoardHeight + newHeight;
                    Gameanite.GameBoardWidth = Gameanite.GameBoardWidth + newWidth;
                    jSONCreator.CreateAxisDrawer(Gameanite.GameBoardWidth, Gameanite.GameBoardHeight);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cant Parse Game Columns");
                }
            }
            else
            {
                MessageBox.Show("Cant Parse Game Rows");
            }
        }
    }
}
