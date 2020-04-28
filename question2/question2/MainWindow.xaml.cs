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

namespace question2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public delegate void delPassDate(string date);
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 displyWindow = new Window1();
            delPassDate delPassDate = new delPassDate(displyWindow.passData);
            delPassDate(this.cl.SelectedDate.ToString());
            displyWindow.Show();

        }
        public string _date
        {
            get { return cl.SelectedDate.ToString(); }
        }
    }
}
