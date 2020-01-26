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
    /// Логика взаимодействия для uc.xaml
    /// </summary>
    public partial class uc : UserControl
    {
        public uc()
        {
            InitializeComponent();
            conner = new Conner();
            conner.Control = this;
        }

        private Conner conner;
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            
            
            Canv.Children.Add(conner);
            
            
        }
        protected override void OnRender(DrawingContext drawingContext)
        {

            conner.ToDo();

        }
    }
}
