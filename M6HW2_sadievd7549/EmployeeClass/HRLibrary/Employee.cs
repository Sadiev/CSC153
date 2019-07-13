using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class Employee
    {
        private string _name;
        private int _idNumber;
        private string _department;
        private string _position;

        public string Name
        {
            get { return _name; }
            set { _name = value; }

        }

        public int IdNumber
        {
            get { return _idNumber; }
            set { _idNumber = value; }

        }

        public string Department
        {
            get { return _department; }
            set { _department = value; }

        }

        public string Position
        {
            get { return _position; }
            set { _position = value; }

        }
    }
}
