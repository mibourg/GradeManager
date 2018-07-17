using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeManager
{
    class Student
    {
        private List<Assignment> _assignments = new List<Assignment>();
        private string _name;

        public Student(string name)
        {
            _name = name;
        }

        public List<Assignment> Assignments
        {
            get
            {
                return _assignments;
            }
            set
            {
                _assignments = value;
            }
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

        public float CalculateAverage()
        {
            int sum = 0;
            foreach (Assignment assignment in _assignments)
            {
                sum += assignment.Grade;
            }

            if (_assignments.Count > 0)
            {
                return sum / _assignments.Count;
            }
            else
            {
                return 0;
            }
        }
    }
}
