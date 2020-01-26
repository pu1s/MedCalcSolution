using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace MedCalc.UI
{
    public class Conner : FrameworkElement
    {
        public Conner()
        {
            _childs = new VisualCollection(this);
        }

        public void ToDo()
        {
#pragma warning disable CS0612 // Тип или член устарел
            _childs.Add(DrawingRect());
#pragma warning restore CS0612 // Тип или член устарел
        }
        private readonly VisualCollection _childs;
        public UserControl Control;

        [Obsolete]
        private DrawingVisual DrawingRect()
        {
            DrawingVisual drawingVisual = new DrawingVisual();
            DrawingContext drawingContext = drawingVisual.RenderOpen();
            Rect rect = new Rect(Control.RenderSize);
            drawingContext.DrawRectangle(Brushes.Black, null, rect);
            drawingContext.DrawText(new FormattedText("AAAAAAA", System.Globalization.CultureInfo.CurrentCulture, FlowDirection.LeftToRight, new Typeface("Verdana"), 16, Brushes.Black), new Point(0, 0));
            drawingContext.Close();
            return drawingVisual;
        }
    }
}
