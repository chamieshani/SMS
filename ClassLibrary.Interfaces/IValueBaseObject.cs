﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Interfaces
{
    public interface IValueBaseObject
    {
        int? ID { get; set; }
        object Timestamp { get; set; }
        string User { get; set; }
        
    }
}
