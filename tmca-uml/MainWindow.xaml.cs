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

namespace tmca_uml
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Data data { get; set; }

        private bool textBoxBeingDragged;

        public MainWindow()
        {
            data = new Data();
            DataContext = data;
            InitializeComponent();
            AddHandler(Mouse.MouseUpEvent, new MouseButtonEventHandler(OnMouseUp), true);
        }

        private void ToolBar_Loaded(object sender, RoutedEventArgs e)
        {
            ToolBar toolBar = sender as ToolBar;
            var overflowGrid = toolBar.Template.FindName("OverflowGrid", toolBar) as FrameworkElement;
            if (overflowGrid != null)
            {
                overflowGrid.Visibility = Visibility.Collapsed;
            }
            var mainPanelBorder = toolBar.Template.FindName("MainPanelBorder", toolBar) as FrameworkElement;
            if (mainPanelBorder != null)
            {
                mainPanelBorder.Margin = new Thickness();
            }
        }
        public void addTextBox()
        {
            TxtBox txt = new TxtBox();
            myCanvas.Children.Add(txt);
        }

        public void OnMouseDown(object sender, MouseEventArgs args)
        {
            if (!(args.OriginalSource is Canvas))
            {
                textBoxBeingDragged = true;
            }
        }

        public void OnMouseMove(object sender, MouseEventArgs args)
        {
            if (textBoxBeingDragged)
            {
                var elementBeingDragged = (FrameworkElement)args.OriginalSource;
                var position = args.GetPosition(myCanvas);
                Canvas.SetLeft(elementBeingDragged, position.X - elementBeingDragged.ActualWidth / 2);
                Canvas.SetTop(elementBeingDragged, position.Y - elementBeingDragged.ActualHeight / 2);
            }
        }

        public void OnMouseUp(object sender, MouseEventArgs args)
        {
            textBoxBeingDragged = false;
        }

        public void clearCanvas()
        {
            myCanvas.Children.Clear();
        }
    }
}
