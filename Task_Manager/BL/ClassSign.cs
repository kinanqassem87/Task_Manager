using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task_Manager.DAL;
using System.Data;


namespace Task_Manager.BL
{
    class ClassSign
    {
        public static DataTable selectAllEmp() 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectAllEmp", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static int ChangePassword(int id, string newPass) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("ChangePassword", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Emp_id", SqlDbType.Int, id),
                DataAccessLayer.CreateParameter("@NewPass_Emp", SqlDbType.NVarChar, newPass));
            DataAccessLayer.Close();
            return i;
        }
    }
}
