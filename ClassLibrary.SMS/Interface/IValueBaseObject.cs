using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.SMS.Interface
{
    public interface IValueBaseObject
    {
        public int? ID { get; set; }
        public string User { get; set; }
        public object Timestamp { get; set; }
    }
}
