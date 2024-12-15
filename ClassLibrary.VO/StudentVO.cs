using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Interfaces;

namespace ClassLibrary.VO
{
    [Serializable]
    public class StudentVO : ValueBaseObject, IStudent
    {
        public StudentVO() { }
        public StudentVO(int? id) : base(id) { }

        private string _name = string.Empty;
        public string Name { get { return _name; } set { _name = value; } }

        private int _age = 0;
        public int Age { get { return _age; } set { _age = value; } }

        private string _email = string.Empty;
        public string Email { get { return _email; } set { _email = value; } }

        private string _RegNo= string.Empty;
        public string RegNo { get { return _RegNo; } set { _RegNo = value; } }

        private DateTime _dob = DateTime.Now;
        public DateTime DOB
        {
            get { return _dob; }
            set
            {
                _dob = value;

            }

        }
    }
}
