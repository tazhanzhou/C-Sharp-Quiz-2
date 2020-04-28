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

namespace question5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int counter;
        public MainWindow()
        {
            InitializeComponent();
            counter = 0;
        }

        private void addbtn_Click(object sender, RoutedEventArgs e)
        {

            addbtn.Background = (addbtn.Background == Brushes.Red) ? (Brushes.Blue) : (Brushes.Red);
            counter++;
            TreeViewItem treeViewItem = new TreeViewItem();
            treeViewItem.Header = counter;
            if (counter % 2 == 0)
            {
                even.Items.Add(treeViewItem);
            }
            else odd.Items.Add(treeViewItem);
        }
    }
}
