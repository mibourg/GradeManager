using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeManager
{
    class Class
    {
        private string _name;
        private List<Student> _students = new List<Student>();

        public Class(string name, List<Student> students)
        {
            _name = name;
            _students = students;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public List<Student> Students
        {
            get
            {
                return _students;
            }
            set
            {
                _students = value;
            }
        }
    }
}
