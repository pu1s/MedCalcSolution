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
using MedCalc;

namespace MedCalc
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Limit l, l1;
        public MainWindow()
        {
            var s = Limit.Empty;
            string ss = string.Empty;

            l = new Limit();
            l1 = new Limit();
            
            l1.ToString();
            InitializeComponent();
            
            l = Limit.Empty;
            btn1.Content = ss;
        }
    }
}
