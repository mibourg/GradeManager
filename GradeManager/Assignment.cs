using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeManager
{
    class Assignment
    {
        private string _name;
        private int _grade;

        public Assignment(string name, int grade)
        {
            _name = name;
            _grade = grade;
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

        public int Grade
        {
            get
            {
                return _grade;
            }
            set
            {
                _grade = value;
            }
        }
    }
}
