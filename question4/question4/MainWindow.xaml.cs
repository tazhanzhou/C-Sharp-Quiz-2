using System;
using System.Collections;
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
        List<Student> students = new List<Student>();
        ArrayList shownStdIdList = new ArrayList();
        public MainWindow()
        {
            InitializeComponent();

            students.Add(new Student(1, "John"));
            students.Add(new Student(2, "Nash"));
            students.Add(new Student(3, "Coco"));
            students.Add(new Student(4, "Pix"));
            students.Add(new Student(5, "Kit"));

        }

        private void checkBtn_Click(object sender, RoutedEventArgs e)
        {

            int inputIdValue = int.Parse(inputId.Text);
            bool inlist = false;
            bool isExist = false;
            foreach (Student stud in students)
            {
                if (stud.Id == inputIdValue)
                {
                    isExist = true;
                    break;
                }
            }
            if (isExist == false)
            {
                MessageBox.Show("This student id not exist");
            }
            else
            {
                foreach (int i in shownStdIdList)
                {
                    if (i == inputIdValue)
                    {
                        inlist = true;
                        MessageBox.Show("This student is already in the list");
                        break;
                    }
                }

                if (inlist == false)
                {
                    foreach (Student st in students)
                    {
                        if (st.Id == inputIdValue)
                        {
                            studListBox.Items.Add(st.Name);
                            shownStdIdList.Add(inputIdValue);
                            break;
                        }
                    }
                }
            }
        }
    }
}
