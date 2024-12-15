using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.SMS;

namespace ClassLibrary.SMS.VO
{
    [Serializable]
    public class StudentVO:VO.ValueBaseObject,Interface.IStudent
    {
        private string _name = String.Empty;
        public string Name { get { return _name; } set { _name = value; } }
        private int _age=0;
        public int Age { get { return _age; } set { _age = value; } }

        private string _regNo=String.Empty;
        public  string RegNo { get { return _regNo; } set { _regNo = value; } }


        private string _email = String.Empty;
        public string Email { get { return _email; } set { _email = value; } }

        private DateTime _dob=DateTime.Now;
        public DateTime DOB { get { return _dob; } set { _dob = value;

    }
}
