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

namespace question4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Student st1 = new Student(1, "John");
            Student st2 = new Student(2, "Nash");
            Student st3 = new Student(3, "Coco");
            Student st4 = new Student(4, "Pix");
            Student st5 = new Student(5, "Kit");

            List<Student> students = new List<Student>();
            students.Add(st1);
            students.Add(st2);
            students.Add(st3);
            students.Add(st4);
            students.Add(st5);
        }

        private void checkBtn_Click(object sender, RoutedEventArgs e)
        {
            
            int inputIdValue = int.Parse(inputId.Text);
            bool inlist = false;
            
            

        }
    }
    
}
