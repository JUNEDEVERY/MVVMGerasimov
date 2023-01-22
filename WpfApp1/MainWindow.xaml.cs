﻿using System;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel viewModel = new ViewModel();
        public MainWindow()
        {

            InitializeComponent();
            DataContext = viewModel; // объект учавствует в привязке данных для данной страницы
            CommandBindings.Add(viewModel.binding);

        }

        private void btnResult_Click(object sender, RoutedEventArgs e)
        {
        
        }

        private void cmbOperation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
