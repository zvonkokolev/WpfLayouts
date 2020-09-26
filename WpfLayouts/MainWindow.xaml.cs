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

namespace WpfLayouts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnClicked(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;

            switch (button.Name)
            {
                case "btnStackPanel": OpenStackPanel(); break;
                case "btnDock": OpenDock(); break;
                case "btnGrid": OpenGrid(); break;
                case "btnGridSplitter": OpenGridSplitter(); break;
            }

        }
        private void OpenStackPanel()
        {
            StackPanel stackPanel = new StackPanel();
            stackPanel.Show();
        }
        private void OpenDock()
        {
            Dock dock = new Dock();
            dock.Show();
        }
        private void OpenGrid()
        {
            Grid grid = new Grid();
            grid.Show();
        }
        private void OpenGridSplitter()
        {
            GridSplitter gridSplitter = new GridSplitter();
            gridSplitter.Show();
        }
    }
}
