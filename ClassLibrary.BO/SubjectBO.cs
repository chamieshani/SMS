using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vo = ClassLibrary.VO;
using Ins = ClassLibrary.Interfaces;
using ADO = ClassLibrary.DAO;

namespace ClassLibrary.BO
{
    public class SubjectBO
    {
        public Ins.ISubject CreateSubject()
        {
            return ADO.SubjectDAO.Instance.CreateValueObject() as Ins.ISubject;
        }
        public Ins.ISubject CreateSubject(int id)
        {
            return ADO.SubjectDAO.Instance.CreateValueObject(id) as Ins.ISubject;
        }
        public Ins.ISubject Save(Ins.ISubject subject)
        {
            if (subject.ID == null)
                return ADO.SubjectDAO.Instance.Save(subject);
            else
                return ADO.SubjectDAO.Instance.Edit(subject);
        }
        public Ins.ISubject Delete(Ins.ISubject subject)
        {
            return ADO.SubjectDAO.Instance.Delete(subject);

        }

        public Ins.ISubject Get(Ins.ISubject subject)
        {
            return ADO.SubjectDAO.Instance.Get(subject);

        }
        public IList<Ins.ISubject> GetAll(Ins.ISubject subject)
        {
            return ADO.SubjectDAO.Instance.getAll();

        }

    }
}
