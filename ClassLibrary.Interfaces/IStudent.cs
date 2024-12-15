using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Interfaces
{
    public interface IStudent:IValueBaseObject
    {
        string Name { get; set; }
        int Age { get; set; } 
        string RegNo { get; set; }
        string Email { get; set; }
        DateTime DOB { get; set; }


    }
}
