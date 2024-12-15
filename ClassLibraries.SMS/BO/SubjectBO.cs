using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vo = ClassLibraries.SMS.VO;
using Ins = ClassLibraries.SMS.Interfaces;
using ADO = ClassLibraries.SMS.DAO;

namespace ClassLibraries.SMS.BO
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
