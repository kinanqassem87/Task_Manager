using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Task_Manager.DAL;

namespace Task_Manager.BL
{
    class ClassEmpDepart
    {
        public static int AddDepartment(string name) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("AddDepartment", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@DepName", SqlDbType.NVarChar, name));
            DataAccessLayer.Close();
            return i;
        }
        public static DataTable selectAllDepartment() 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectAllDepartment", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable SearchDepartment(string search) 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SearchDepartment", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@search", SqlDbType.NVarChar, search));
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable SearchONEDepartment(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SearchONEDepartment", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@search", SqlDbType.NVarChar, search));
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable updateDepartment(int id, string name) 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("updateDepartment", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id),
                DataAccessLayer.CreateParameter("@name", SqlDbType.NVarChar, name));
            DataAccessLayer.Close();
            return dt;
        }
        public static int deleteDepart(int id) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("deleteDepart", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return i;
        }
        public static int AddNewEmp(string emp_userN, string emp_password, string emp_Permission, int depart_id, string emp_fullName, string phoneNmum, string addressEmp) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("AddNewEmp", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@emp_userN", SqlDbType.NVarChar, emp_userN),
                DataAccessLayer.CreateParameter("@emp_password", SqlDbType.NVarChar, emp_password),
                DataAccessLayer.CreateParameter("@emp_Permission", SqlDbType.NVarChar, emp_Permission),
                DataAccessLayer.CreateParameter("@depart_id", SqlDbType.Int, depart_id),
                DataAccessLayer.CreateParameter("@emp_fullName", SqlDbType.NVarChar, emp_fullName),
                DataAccessLayer.CreateParameter("@phoneNmum", SqlDbType.NVarChar, phoneNmum),
                DataAccessLayer.CreateParameter("@addressEmp", SqlDbType.NVarChar, addressEmp));
            DataAccessLayer.Close();
            return i;
        }
        public static DataTable DisplayAllEmp() 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("DisplayAllEmp", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable SearchEmp(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SearchEmp", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@search", SqlDbType.NVarChar, search));
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable SearchOneEmp(string Emp_User)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SearchOneEmp", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@emp_userN", SqlDbType.NVarChar, Emp_User));
            DataAccessLayer.Close();
            return dt;
        }
        public static int UpdateEmp(int emp_id, string empU, string empP, string per, int departID, string fullname, string phoneNum, string AddressEmp) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("UpdateEmp", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Emp_id", SqlDbType.Int, emp_id),
                DataAccessLayer.CreateParameter("@Emp_UserN", SqlDbType.NVarChar, empU),
                DataAccessLayer.CreateParameter("@Emp_Password", SqlDbType.NVarChar, empP),
                DataAccessLayer.CreateParameter("@Emp_Permission", SqlDbType.NVarChar, per),
                DataAccessLayer.CreateParameter("@Depart_id", SqlDbType.Int, departID),
                DataAccessLayer.CreateParameter("@Emp_FullName", SqlDbType.NVarChar, fullname),
                DataAccessLayer.CreateParameter("@PhoneNum", SqlDbType.NVarChar, phoneNum),
                DataAccessLayer.CreateParameter("@AddressEmp", SqlDbType.NVarChar, AddressEmp));
            DataAccessLayer.Close();
            return i;
        }
        public static int DeleteEmp(int id) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("DeleteEmp", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Emp_id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return i;
        }
        public static int addEmpSlave(int emp_id_slave, int emp_id) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("addEmpSlave", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Emp_ID_Slave", SqlDbType.Int, emp_id_slave),
                DataAccessLayer.CreateParameter("@Emp_id", SqlDbType.Int, emp_id));
            DataAccessLayer.Close();
            return i;
        }
        public static DataTable selectallEmpSlave(int id) 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectallEmpSlave", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return dt;
        }
        public static int delfromSlavWMasterEmp(int id) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("delfromSlavWMasterEmp", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return i;
        }
        public static DataTable searchempinAssign(int id) 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("searchempinAssign", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable searchempByID(int id)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("searchempByID", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return dt;
        }
        public static int DeleteSlaveByEmpID(int id) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("DeleteSlaveByEmpID", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return i;
        }
        public static DataTable selectTaskIDToDel(int id) 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectTaskIDToDel", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@empID", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return dt;
        }
        public static int deleteTaskEmpID(int empid) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("deleteTaskEmpID", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Assigned_To_Emp_id", SqlDbType.Int, empid));
            DataAccessLayer.Close();
            return i;
        }
    }
}
