using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Interfaces;

namespace ClassLibrary.VO
{
    [Serializable]
    public class ValueBaseObject :IValueBaseObject
    {
        public ValueBaseObject() { }
        public ValueBaseObject(int? id) { ID = id; }

        private int? _id = null;
        public int? ID { get { return _id; } set { _id = value; } }
       
        private object _timestamp = null;
        public object Timestamp { get { return _timestamp; } set { _timestamp = value; } }

        private string _user = string.Empty;
        public string User { get { return _user; } set { _user = value; } }
    }
}
