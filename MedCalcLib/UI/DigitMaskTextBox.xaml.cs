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
using System.Text.RegularExpressions;

namespace MedCalc.UI
{
    /// <summary>
    /// Логика взаимодействия для DigitMaskTextBox.xaml
    /// </summary>
    public partial class DigitMaskTextBox : TextBox
    {
        //static DigitMaskTextBox()
        //{
            
        //}

        static DigitMaskTextBox()
        {

            //InitializeComponent();
            DigitMaskTextBox.UpdateMaskEvent = EventManager.RegisterRoutedEvent("UpdateMask", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(DigitMaskTextBox));

        }
        public static RoutedEvent UpdateMaskEvent;

        public event RoutedEventHandler UpdateMask
        {
            add
            {
                base.AddHandler(UpdateMaskEvent, value);
            }
            remove
            {
                base.RemoveHandler(UpdateMaskEvent, value);
            }
        }


        public string Mask
        {
            get { return (string)GetValue(MaskProperty); }
            set {
                if (value != (string)GetValue(MaskProperty)) OnUpdateMask();
                SetValue(MaskProperty, value); 
            }
        }

        private void OnUpdateMask()
        {
            RoutedEventArgs args = new RoutedEventArgs(DigitMaskTextBox.UpdateMaskEvent, this);
            RaiseEvent(args);
        }
        // Using a DependencyProperty as the backing store for Mask.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MaskProperty =
            DependencyProperty.Register("Mask", typeof(string), typeof(DigitMaskTextBox), new PropertyMetadata("0000-00"));



        public bool IsMaskVisible
        {
            get { return (bool)GetValue(IsMaskVisibleProperty); }
            set { SetValue(IsMaskVisibleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsMaskVisible.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsMaskVisibleProperty =
            DependencyProperty.Register("IsMaskVisible", typeof(bool), typeof(DigitMaskTextBox), new PropertyMetadata(true));

        
        protected override void OnRender(DrawingContext drawingContext)
            
        {
           
            OnRenderMask(ref drawingContext, Mask);
            base.OnRender(drawingContext);
        }
        

        private void OnRenderMask(ref DrawingContext drawingContext, string mask)
        {
            // Parse string
            //
            if (string.IsNullOrWhiteSpace(mask)) return;
            //
            // Init str
            //
            string tmpMask = string.Empty;
            tmpMask = mask;
            Regex regex = new Regex(@"[^a-z]", RegexOptions.IgnoreCase);
            if (!regex.IsMatch(tmpMask)) return;
            this.Text = Mask;
            
        }
    }
}
