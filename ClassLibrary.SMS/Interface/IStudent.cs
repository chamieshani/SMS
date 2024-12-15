using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.SMS.Interface
{
    public interface IStudent : IValueBaseObject
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string RegNo { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
    }
}
