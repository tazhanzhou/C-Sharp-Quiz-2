using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question4
{
    public class Student
    {
        int Id { get; set; }
        string Name { get; set; }

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
