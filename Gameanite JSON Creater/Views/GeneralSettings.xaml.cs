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
    /// Interaction logic for GeneralSettings.xaml
    /// </summary>
    public partial class GeneralSettings : Window
    {
        private Model.Gameanite Gameanite;

        public GeneralSettings(Model.Gameanite Gameanite)
        {
            InitializeComponent();
            this.Gameanite = Gameanite;
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            int temp = -1;
            bool result = Int32.TryParse(startPosXBox.Text, out temp);
            if (result)
            {
                Gameanite.GameStartX = temp;
            }
            else
            {
                MessageBox.Show("Cant Parse Game Start X Position");
            }
            temp = -1;
            result = Int32.TryParse(startPosYBox.Text, out temp);
            if (result)
            {
                Gameanite.GameStartY = temp;
                this.Close();

            }
            else
            {
                MessageBox.Show("Cant Parse Game Start Y Position");
            }
        }

        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
