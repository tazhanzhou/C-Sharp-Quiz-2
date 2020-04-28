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

namespace question1
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

        private void reset_Click(object sender, RoutedEventArgs e)
        {
            firstName.Text = "";
            lastName.Text = "";
            phoneNo.Text = "";
            Show();

        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            var fname = firstName.Text;
            var lname = lastName.Text;
            var pNo = phoneNo.Text;
            string message = fname + " " + lname + " " + pNo;
            MessageBox.Show(message);

        }
    }
}
