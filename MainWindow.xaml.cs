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

namespace rokopoko
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (pocz.IsChecked == true)
            {
                cenaBloczek.Text = "Cena: 1 zł";
            }
            else if (list.IsChecked == true)
            {
                cenaBloczek.Text = "Cena: 1,5 zł";
            }
            else if (pacz.IsChecked == true)
            {
                cenaBloczek.Text = "Cena: 10 zł";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int kodpocztowy;
            

            if (int.TryParse(kod.Text, out kodpocztowy))
            {
                if (kod.Text.Length == 5)
                {
                    MessageBox.Show("Dane przesyłki zostały wprowadzone");
                }
                else
                {
                    MessageBox.Show("Nieprawidłowa liczba cyfr w kodzie pocztowym");
                }
            }
            
        }
    }
}
