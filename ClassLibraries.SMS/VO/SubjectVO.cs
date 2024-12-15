using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraries.SMS.Interfaces;

namespace ClassLibraries.SMS.VO
{
    public class SubjectVO:ValueBaseObject,ISubject
    {
        public SubjectVO() { }
        public SubjectVO(int? id) : base(id) { }

        private string _subjectName=string.Empty;
        public string SubjectName { get { return _subjectName; } set { _subjectName = value; } }

    }
}
