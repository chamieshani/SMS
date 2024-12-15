using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Common;
using Ins = ClassLibrary.Interfaces;
using vo = ClassLibrary.VO;

using System.Data.SqlClient;

namespace ClassLibrary.DAO
{
    public class StudentDAO
    {
        private StudentDAO() { }

        private static StudentDAO _instance = new StudentDAO();
        public static StudentDAO Instance
        {
            get { return _instance; }
            set { _instance = value; }
        }

        public Ins.IStudent CreateValueObject()
        {
            return new VO.StudentVO();
        }
        public Ins.IStudent CreateValueObject(int id)
        {
            return new VO.StudentVO(id);
        }

        #region Save Method
        public Ins.IStudent Save(Ins.IStudent vo)
        {
            DataHandler handler = new DataHandler();
           
            List<object[]> mPara = new List<object[]>();

           
            mPara.Add(new object[] { "@ID", vo.ID });
            mPara.Add(new object[] { "@Name", vo.Name });           
            mPara.Add(new object[] { "@Age", vo.Age });
            mPara.Add(new object[] { "@Email", vo.Email });
            mPara.Add(new object[] { "@RegNo", vo.RegNo });
            mPara.Add(new object[] { "@DOB", vo.DOB });
            return vo;

        }
        #endregion

        #region Save Method
        public Ins.IStudent Edit(Ins.IStudent vo)
        {
            DataHandler handler = new DataHandler();

            List<object[]> mPara = new List<object[]>();

            mPara.Add(new object[] { "@ID", vo.ID});
            mPara.Add(new object[] { "@Name", vo.Name });
            mPara.Add(new object[] { "@Age", vo.Age });
            mPara.Add(new object[] { "@Email", vo.Email });
            mPara.Add(new object[] { "@RegNo", vo.RegNo });
            mPara.Add(new object[] { "@DOB", vo.DOB });
            mPara.Add(new object[] { "@User", vo.User });
           
           
                handler.executeSQL("sp_EditStudent", mPara);
          
            return vo;

        }
        #endregion

  

        #region GetAll
        public IList<Ins.IStudent> GetAllStudents()
        {
            IList<Ins.IStudent> list = new List<Ins.IStudent>();
            DataHandler handler = new DataHandler();
            SqlDataReader dr;

            List<object[]> mPara = null;
            try
            {
                dr = handler.readData("sp_GetAllStudents", mPara);
                if (dr.RecordsAffected != 0)
                {
                    int idOrdinal = dr.GetOrdinal("ID");
                    int timestampOrdinal = dr.GetOrdinal("TimeStamp");
                    int nameOrdinal = dr.GetOrdinal("Name");
                    int regNoOrdinal = dr.GetOrdinal("RegNo");
                    int UserModifiedOrdinal = dr.GetOrdinal("User");


                    while (dr.Read())
                    {
                        VO.StudentVO vo = CreateValueObject(dr.GetInt32(idOrdinal)) as VO.StudentVO;

                        if (!dr.IsDBNull(timestampOrdinal)) vo.Timestamp = dr.GetValue(timestampOrdinal);
                        if (!dr.IsDBNull(nameOrdinal)) vo.Name = dr.GetString(nameOrdinal);
                        if (!dr.IsDBNull(UserModifiedOrdinal)) vo.User = dr.GetString(UserModifiedOrdinal);
                        if (!dr.IsDBNull(regNoOrdinal)) vo.RegNo = dr.GetString(regNoOrdinal);

                        list.Add(vo as Ins.IStudent);
                    }
                    return list;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region GetByID
        public Ins.IStudent GetByID(Ins.IStudent student)
        {
            DataHandler handler = new DataHandler();
            List<object[]> mPara = new List<object[]>();
            SqlDataReader dr;
            VO.StudentVO vo = null;

            mPara.Add(new object[] { "@ID", student.ID });
            try
            {
                dr = handler.readData("sp_GetStudent", mPara);



                if (dr.RecordsAffected != 0)
                {
                    int idOrdinal = dr.GetOrdinal("ID");
                    int timestampOrdinal = dr.GetOrdinal("TimeStamp");
                    int nameOrdinal = dr.GetOrdinal("Name");
                    int regNoOrdinal = dr.GetOrdinal("RegNo");
                    int UserModifiedOrdinal = dr.GetOrdinal("User");


                    if (dr.Read())
                    {
                        vo = CreateValueObject(dr.GetInt32(idOrdinal)) as VO.StudentVO;

                        if (!dr.IsDBNull(timestampOrdinal)) vo.Timestamp = dr.GetValue(timestampOrdinal);
                        if (!dr.IsDBNull(nameOrdinal)) vo.Name = dr.GetString(nameOrdinal);
                        if (!dr.IsDBNull(UserModifiedOrdinal)) vo.User = dr.GetString(UserModifiedOrdinal);
                        if (!dr.IsDBNull(regNoOrdinal)) vo.RegNo = dr.GetString(regNoOrdinal);

                    }
                }

                return vo;
            }
            catch
            {
                return vo;
            }
        }
        #endregion
    }
}
    