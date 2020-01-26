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
    /// Логика взаимодействия для WatermarkMaskTextBoxControl.xaml
    /// </summary>
    public partial class WatermarkMaskTextBoxControl : UserControl
    {
        public WatermarkMaskTextBoxControl()
        {
            InitializeComponent();
        }

        #region Events

        #endregion



        

        #region Properties

        public string WatermarkText
        {
            get { return (string)GetValue(WatermarkTextProperty); }
            set { SetValue(WatermarkTextProperty, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public WatermarkMaskTextBoxMode ControlMode
        {
            get { return (WatermarkMaskTextBoxMode)GetValue(ControlModeProperty); }
            set { SetValue(ControlModeProperty, value); }
        }

        

        /// <summary>
        /// Маска ввода
        /// </summary>
        public string Mask
        {
            get { return (string)GetValue(MaskProperty); }
            set { SetValue(MaskProperty, value); }
        }
        #endregion

        #region Dependency Properties

        public static readonly DependencyProperty MaskProperty =
            DependencyProperty.Register("Mask", typeof(string), typeof(WatermarkMaskTextBoxControl), new PropertyMetadata("000,00"));
       
        public static readonly DependencyProperty ControlModeProperty =
            DependencyProperty.Register("ControlMode", typeof(WatermarkMaskTextBoxMode), typeof(WatermarkMaskTextBoxControl), new PropertyMetadata(WatermarkMaskTextBoxMode.WatermarkMode));
        
        public static readonly DependencyProperty WatermarkTextProperty =
            DependencyProperty.Register("WatermarkText", typeof(string), typeof(WatermarkMaskTextBoxControl), new PropertyMetadata("Watermark"));
        #endregion
    }

    public enum WatermarkMaskTextBoxMode
    {
          WatermarkMode = 0,
          MaskMode,
          InputMode,
    }
}
