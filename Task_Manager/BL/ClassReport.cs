using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task_Manager.DAL;
using System.Data;

namespace Task_Manager.BL
{
    class ClassReport
    {
        public static DataTable selectAllTask() 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectAllTask", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable selectAllTaskEmp(string empName)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectAllTaskEmp", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@empNmae", SqlDbType.NVarChar, empName));
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable selectAllTaskStatus(string empstatus)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectAllTaskStatus", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@empStatus", SqlDbType.NVarChar, empstatus));
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable selectAllTaskDate(DateTime empDate)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectAllTaskDate", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@empDate", SqlDbType.Date, empDate));
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable selectAllTaskDateNmae(DateTime empDate,string empName)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectAllTaskDateNmae", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@empDate", SqlDbType.Date, empDate),
                DataAccessLayer.CreateParameter("@empNmae", SqlDbType.NVarChar, empName));
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable selectAllTaskDateNmaeState(DateTime empDate, string empName,string empstat)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectAllTaskDateNmaeState", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@empDate", SqlDbType.Date, empDate),
                DataAccessLayer.CreateParameter("@empNmae", SqlDbType.NVarChar, empName),
                DataAccessLayer.CreateParameter("@empSatate", SqlDbType.NVarChar, empstat));
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable selectAllTaskNmaeState(string empName, string empstat)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectAllTaskNmaeState", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@empNmae", SqlDbType.NVarChar, empName),
                DataAccessLayer.CreateParameter("@empSatate", SqlDbType.NVarChar, empstat));
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable selectAllTaskDateState(DateTime empDate,string empstat)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectAllTaskDateState", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@empDate", SqlDbType.Date, empDate),
                DataAccessLayer.CreateParameter("@empSatate", SqlDbType.NVarChar, empstat));
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable SearchPublicAllTask(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SearchPublicAllTask", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@search", SqlDbType.NVarChar, search));
            DataAccessLayer.Close();
            return dt;
        }

    }
}
