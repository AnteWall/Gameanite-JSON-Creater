﻿using Gameanite_JSON_Creater.Views;
using Microsoft.Win32;
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

namespace Gameanite_JSON_Creater
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void CreateNew(int height,int width)
        {
            jsonCreator.NewFile(height, width);
        }

        private void CreateNewFile_Click(object sender, RoutedEventArgs e)
        {
            NewFile newFile = new NewFile(this);
            newFile.Show();
        }

        private void SaveJson_Click(object sender, RoutedEventArgs e)
        {
            jsonCreator.SaveFile();
        }
        private void exitProgram_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void changeGeneralSettings_Click(object sender, RoutedEventArgs e)
        {
            jsonCreator.ChangeGeneralSettings();
        }

        private void addRowsAndColumns_Click(object sender, RoutedEventArgs e)
        {
            jsonCreator.AddRowsAndColumns();
        }

        private void openFile_Click(object sender, RoutedEventArgs e)
        {
            jsonCreator.Readfile();
        }
    }
}
