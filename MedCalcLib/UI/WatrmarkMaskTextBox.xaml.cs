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

namespace MedCalc.UI
{
    /// <summary>
    /// Логика взаимодействия для WatrmarkMaskTextBox.xaml
    /// </summary>
    public partial class WatrmarkMaskTextBox : UserControl
    {
        public WatrmarkMaskTextBox()
        {
            InitializeComponent();
        }



        public string WatermarkText
        {
            get { return (string)GetValue(WatermarkTextProperty); }
            set { SetValue(WatermarkTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for WatermarkText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty WatermarkTextProperty =
            DependencyProperty.Register("WatermarkText", typeof(string), typeof(WatrmarkMaskTextBox), new PropertyMetadata("WatermarkText"));



    }
}
