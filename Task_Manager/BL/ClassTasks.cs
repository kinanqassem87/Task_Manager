using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Task_Manager.DAL;

namespace Task_Manager.BL
{
    class ClassTasks
    {
        public static int AddNewTask(string T_title, string descrp, string t_status, DateTime creatDate, string taskPath, int CreatedEmp, int AssignEmp, DateTime Task_LastUpdate) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("AddNewTask", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Task_Titel", SqlDbType.NVarChar, T_title),
                DataAccessLayer.CreateParameter("@Discreption", SqlDbType.NVarChar, descrp),
                DataAccessLayer.CreateParameter("@Task_Status", SqlDbType.NVarChar, t_status),
                DataAccessLayer.CreateParameter("@Create_Date", SqlDbType.Date, creatDate),
                DataAccessLayer.CreateParameter("@TaskPath", SqlDbType.NVarChar, taskPath),
                DataAccessLayer.CreateParameter("@Creater_Emp_id", SqlDbType.Int, CreatedEmp),
                DataAccessLayer.CreateParameter("@Assigned_To_Emp_id", SqlDbType.Int, AssignEmp),
                DataAccessLayer.CreateParameter("@Task_LastUpdate", SqlDbType.Date, Task_LastUpdate));
            DataAccessLayer.Close();
            return i;
        }
        public static DataTable searchempinAssignWithName(int id) 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("searchempinAssignWithName", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable selectTaskNotExecute(int id) 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectTaskNotExecute", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Assigned_To_Emp_id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable selectTaskToDoNowExecute(int id)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectTaskToDoNowExecute", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Assigned_To_Emp_id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable selectTaskDoneNowExecute(int id)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectTaskDoneNowExecute", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Assigned_To_Emp_id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable selectTaskWithPath(int id)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectTaskWithPath", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable selectReportByID(int id)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectReportByID", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return dt;
        }
        public static int AddReportToTask(string Task_note, DateTime Task_note_Date, int Task_id) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("AddReportToTask", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Task_note", SqlDbType.NVarChar, Task_note),
                DataAccessLayer.CreateParameter("@Task_note_Date", SqlDbType.Date, Task_note_Date),
                DataAccessLayer.CreateParameter("@Task_id", SqlDbType.Int, Task_id));
            DataAccessLayer.Close();
            return i;
        }
        public static int update_Status(int id, string Task_Status, DateTime Task_LastUpdate) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("update_Status", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id),
                DataAccessLayer.CreateParameter("@Task_Status", SqlDbType.NVarChar, Task_Status),
                DataAccessLayer.CreateParameter("@Task_LastUpdate", SqlDbType.Date, Task_LastUpdate));
            DataAccessLayer.Close();
            return i;
        }
        public static int updateNote(int id, string task_note) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("updateNote", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id),
                DataAccessLayer.CreateParameter("@Task_note", SqlDbType.NVarChar, task_note));
            DataAccessLayer.Close();
            return i;
        }
        public static DataTable searchforTask(int id) 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("searchforTask", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@AssignId", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return dt;
        }
        public static int updateTask(int task_id, string title, string discreption, string t_status) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("updateTask", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Task_id", SqlDbType.Int, task_id),
                DataAccessLayer.CreateParameter("@Task_Titel", SqlDbType.NVarChar, title),
                DataAccessLayer.CreateParameter("@Discreption", SqlDbType.NVarChar, discreption),
                DataAccessLayer.CreateParameter("@Task_Status", SqlDbType.NVarChar, t_status));
            DataAccessLayer.Close();
            return i;
        }
        public static int deleteTaskDet(int id) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("deleteTaskDet", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Task_id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return i;
        }

        public static int deleteTask(int id)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("deleteTask", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Task_id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return i;
        }

    }
}
