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
using System.Windows.Shapes;

namespace hepsiburada.com
{
    /// <summary>
    /// MusteriHizmetleri.xaml etkileşim mantığı
    /// </summary>
    public partial class MusteriHizmetleri : Window
    {
        public MusteriHizmetleri()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("0(850)252 40 00");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Uyegiris uyegiris = new Uyegiris();
            uyegiris.Show();
            this.Hide();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Uyegiris uyegiris = new Uyegiris();
            uyegiris.Show();
            this.Hide();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Uyegiris uyegiris = new Uyegiris();
            uyegiris.Show();
            this.Hide();
        }
    }
}
