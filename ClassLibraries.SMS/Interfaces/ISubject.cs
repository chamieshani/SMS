using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraries.SMS.Interfaces
{
    public interface ISubject:IValueBaseObject
    {
        string SubjectName { get; set; }

    }
}
