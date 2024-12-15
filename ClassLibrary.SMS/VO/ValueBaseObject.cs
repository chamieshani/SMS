using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.SMS;

namespace ClassLibrary.SMS.VO
{
    [Serializable]
    public class ValueBaseObject:Interface.IValueBaseObject
    {
        private int?_id=null;
        public int? ID { get { return _id; } set { _id = value; } }

        private string _user = string.Empty;
        public string User { get { return _user; } set { _user = value; } }

        private object _timestamp=null;
        public object Timestamp { get { return _timestamp; } set { _timestamp = value; } }

    }
}
