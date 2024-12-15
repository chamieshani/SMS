using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Ins = ClassLibraries.SMS.Interfaces;
using vo = ClassLibraries.SMS.VO;
using ClassLibraries.SMS.Common;

namespace ClassLibraries.SMS.DAO
{
    public class SubjectDAO
    {
        private SubjectDAO() { }

        private static SubjectDAO _instance = new SubjectDAO();
        public static SubjectDAO Instance
        {
            get { return _instance; }
            set { _instance = value; }
        }

        public Ins.ISubject CreateValueObject()
        {
            return new vo.SubjectVO();
        }
        public Ins.ISubject CreateValueObject(int id)
        {
            return new vo.SubjectVO(id);
        }

        #region Save
        public Ins.ISubject Save(Ins.ISubject vo)
        {

            DataHandler handler = new DataHandler();

            List<object[]> mPara = new List<object[]>();

            mPara.Add(new object[] { "@ID", vo.ID });
            mPara.Add(new object[] { "@SubjectName", vo.SubjectName });
            mPara.Add(new object[] { "@User", vo.User });

            handler.executeSQL("sp_CreateSubject", mPara);

            return vo as Ins.ISubject;
        }
        #endregion

        #region Edit
        public Ins.ISubject Edit(Ins.ISubject vo)
        {

            DataHandler handler = new DataHandler();

            List<object[]> mPara = new List<object[]>();

            mPara.Add(new object[] { "@ID", vo.ID });
            mPara.Add(new object[] { "@SubjectName", vo.SubjectName });
            mPara.Add(new object[] { "@User", vo.User });

            handler.executeSQL("sp_EditSubject", mPara);

            return vo as Ins.ISubject;
        }
        #endregion

        #region Edit
        public Ins.ISubject Delete(Ins.ISubject vo)
        {

            DataHandler handler = new DataHandler();

            List<object[]> mPara = new List<object[]>();

            mPara.Add(new object[] { "@ID", vo.ID });
            mPara.Add(new object[] { "@User", vo.User });

            handler.executeSQL("sp_DeleteSubject", mPara);

            return vo as Ins.ISubject;
        }
        #endregion

        #region Get
        public Ins.ISubject Get(Ins.ISubject subject)
        {
            DataHandler handler = new DataHandler();
            List<object[]> mPara = new List<object[]>();
            SqlDataReader dr;
            VO.SubjectVO? vo = null;

            mPara.Add(new object[] { "@ID", subject.ID });
            try
            {
                dr = handler.readData("sp_GetSubject", mPara);
                if (dr.RecordsAffected != 0)
                {

                    int idOrdinal = dr.GetOrdinal("ID");
                    int timeStampOrdinal = dr.GetOrdinal("Timestamp");
                    int userOrdinal = dr.GetOrdinal("User");
                    int subjectNameOrdinal = dr.GetOrdinal("SubjectName");
                    if (dr.Read())
                    {
                        vo = CreateValueObject(dr.GetInt32(idOrdinal)) as VO.SubjectVO;
                        if (!dr.IsDBNull(timeStampOrdinal)) vo.Timestamp = dr.GetValue(timeStampOrdinal);
                        if (!dr.IsDBNull(userOrdinal)) vo.User = dr.GetString(userOrdinal);
                        if (!dr.IsDBNull(subjectNameOrdinal)) vo.SubjectName = dr.GetString(subjectNameOrdinal);

                    }

                }
                return vo;
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region Getall
        public IList<Ins.ISubject> getAll()
        {
            IList<Ins.ISubject> list = new List<Ins.ISubject>();
            DataHandler handler = new DataHandler();
            SqlDataReader dr;
            List<object[]> mParam = null;

            try
            {
                dr = handler.readData("sp_GetAllSubjects", mParam);
                if (dr.RecordsAffected != 0)
                {
                    int idOrdinal = dr.GetOrdinal("ID");
                    int userOrdinal = dr.GetOrdinal("User");
                    int timeStampOrdinal = dr.GetOrdinal("Timestamp");
                    int subjectNameOrdinal = dr.GetOrdinal("SubjectName");
                    while (dr.Read())
                    {

                    }
                }

            }
            catch
            {

            }
            return list;
        }

        #endregion

    }
}
