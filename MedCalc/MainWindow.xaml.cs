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
using MedCalc;

namespace MedCalc
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Limit l, l1;

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            PageIndexBodyMass pageIndexBodyMass = new PageIndexBodyMass();
            this.Content = pageIndexBodyMass;
        }

        public MainWindow()
        {
            
            InitializeComponent();
           
        }
    }
}
