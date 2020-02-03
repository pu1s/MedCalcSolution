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
using GUI = MedCalc.UI;
using DATA = MedCalc;

namespace MedCalc
{
    /// <summary>
    /// Логика взаимодействия для IndexBodyMassPage.xaml
    /// </summary>
    public partial class IndexBodyMassPage : Page
    {
        
        public IndexBodyMassPage()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            Calculate();
        }

        private async void Calculate()
        {
            DATA.IndexBodyMassData indexBodyMassData = new IndexBodyMassData(float.Parse(Wieght.Text), new Limit(0, 200), float.Parse(Hieght.Text), new Limit(0, 200));
            float result = await DATA.Calculator.IndexBodyMassAsync(indexBodyMassData);
        }
    }

   
}
