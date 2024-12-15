using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ins = ClassLibrary.Interfaces;
using DAO = ClassLibrary.DAO;

namespace ClassLibrary.BO
{
    public class StudentBO
    {
        public Ins.IStudent CreateStudent()
        {
            return DAO.StudentDAO.Instance.CreateValueObject() as Ins.IStudent;
        }
        public Ins.IStudent CreateStudent(int id)
        {
            return DAO.StudentDAO.Instance.CreateValueObject(id) as Ins.IStudent;

        }
        public Ins.IStudent SaveStudent(Ins.IStudent student)
        {
            if(student.ID ==null)
                return DAO.StudentDAO.Instance.Save(student);
            else
                return DAO.StudentDAO.Instance.Edit(student);


        }
    }
}
