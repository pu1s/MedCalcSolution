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
    /// Логика взаимодействия для DigitTextBox.xaml
    /// </summary>
    public partial class DigitTextBox : UserControl
    {
        public DigitTextBox()
        {
            InitializeComponent();
        }


        private Brush tmpBrush;

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(DigitTextBox), new PropertyMetadata(""));



        public string Mask
        {
            get { return (string)GetValue(MaskProperty); }
            set { SetValue(MaskProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Mask.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MaskProperty =
            DependencyProperty.Register("Mask", typeof(string), typeof(DigitTextBox), new PropertyMetadata("000,00"));

        private void LAYER_Text_TextChanged(object sender, TextChangedEventArgs e)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("[0-9][,.]");
               
               if(regex.IsMatch(Text))
                {
                    //throw new ArgumentException(@"Ошибка ввода!");
                }
           
        }

        private void LAYER_Text_GotFocus(object sender, RoutedEventArgs e)
        {
            tmpBrush  = LAYER_Mask.Foreground;
            LAYER_Mask.Foreground = SystemColors.ControlLightBrush;
        }

        private void LAYER_Text_LostFocus(object sender, RoutedEventArgs e)
        {
            if (LAYER_Text.Text.Length == 0) LAYER_Mask.Foreground = tmpBrush;
        }

        private void LAYER_Mask_Error(object sender, ValidationErrorEventArgs e)
        {
            
        }
    }
}
