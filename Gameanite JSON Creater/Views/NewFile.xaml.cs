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

namespace Gameanite_JSON_Creater.Views
{
    /// <summary>
    /// Interaction logic for NewFile.xaml
    /// </summary>
    public partial class NewFile : Window
    {
        private MainWindow mainWindow;
        private int textRows,textColumns;

        public NewFile()
        {
            InitializeComponent();
        }

        public NewFile(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            this.Topmost = true;
            this.Focus();
        }

        private void close_Btn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void create_Btn_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.CreateNew(textRows, textColumns);
            this.Close();
        }

        private void gameColumnsBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            int temp = -1;
            bool result = Int32.TryParse(gameColumnsBox.Text, out temp);
            if (result)
            {
                textColumns = temp;
            }
            else
            {
                MessageBox.Show("Cant Parse Game Coulmns");
            }
        }

        private void gameRowsBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            int temp = -1;
            bool result = Int32.TryParse(gameRowsBox.Text, out temp);
            if (result)
            {
                textRows = temp;
            }
            else
            {
                MessageBox.Show("Cant Parse Game Rows");
            }
            
        }

    }
}
