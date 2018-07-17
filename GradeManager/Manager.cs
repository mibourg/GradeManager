using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeManager
{
    class Manager
    {
        private static Class _chosenClass;
        public static Class ChosenClass
        {
            get
            {
                return _chosenClass;
            }
            set
            {
                _chosenClass = value;
            }
        }

        private static Student _chosenStudent;
        public static Student ChosenStudent
        {
            get
            {
                return _chosenStudent;
            }
            set
            {
                _chosenStudent = value;
            }
        }

        private static List<Class> _classes = new List<Class>();
        public static List<Class> Classes
        {
            get
            {
                return _classes;
            }
            set
            {
                _classes = value;
            }
        }
    }
}
