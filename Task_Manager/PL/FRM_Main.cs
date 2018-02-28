using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Task_Manager.PL
{
    public partial class FRM_Main : Form
    {
        public static int Emp_id;
        public static string user_name = "";
        public static string U_Password = "";
        public static string Full_Name = "";
        public static string PerMission = "";
        public static string Department = "";
        public static string notEXE = "غير منجز";
        public static string ToDoEXE = "قيد الانجاز";
        public static string DoneEXE = "منجزة";

        public FRM_Main()
        {
            InitializeComponent();
            
        }

        private void TsSignIn_Click(object sender, EventArgs e)
        {
            FRM_SignIn s = new FRM_SignIn();
            s.ShowDialog();
        }

        private void FRM_Main_Activated(object sender, EventArgs e)
        {
            if (PerMission.Equals("Admin"))
            {
                TsSignIn.Enabled = false;
                tsSignOut.Enabled = tsChangePassword.Enabled= true;
                ts_report.Enabled = ts_task.Enabled = tsEmpDep.Enabled = true;
                tsTaskManagment.Enabled = true;
                toolStripStatusLabel1.Text = "الاسم : "+Full_Name;
            }
            else if (PerMission.Equals("User")) 
            {
                TsSignIn.Enabled = false;
                tsSignOut.Enabled = tsChangePassword.Enabled = true;
                ts_task.Enabled = true;
                tsTaskManagment.Enabled = false;
                toolStripStatusLabel1.Text = "الاسم : " + Full_Name;
            }
        }

        private void tsSignOut_Click(object sender, EventArgs e)
        {
            PerMission = "";
            tsSignOut.Enabled = tsChangePassword.Enabled = false;
            ts_report.Enabled = ts_task.Enabled = tsEmpDep.Enabled = false;
            TsSignIn.Enabled = true;
            FRM_SignIn s = new FRM_SignIn();
            s.ShowDialog();
            PerMission = "Out";
            
        }

        private void tsChangePassword_Click(object sender, EventArgs e)
        {
            FRM_ChangePassword c = new FRM_ChangePassword();
            c.ShowDialog();
        }

        private void tsAbout_Click(object sender, EventArgs e)
        {
            FRM_About a = new FRM_About();
            a.ShowDialog();
        }

        private void tsAddNewDepart_Click(object sender, EventArgs e)
        {
            FRM_AddNewDepart a = new FRM_AddNewDepart();
            a.ShowDialog();
        }

        private void tsDepartManag_Click(object sender, EventArgs e)
        {
            FRM_DepartManagment a = new FRM_DepartManagment();
            a.ShowDialog();
        }

        private void tsAddEmp_Click(object sender, EventArgs e)
        {
            FRM_AddNewEmp a = new FRM_AddNewEmp();
            a.ShowDialog();
        }

        private void tsEmpManagment_Click(object sender, EventArgs e)
        {
            FRM_EmpManagment a = new FRM_EmpManagment();
            a.ShowDialog();
        }

        private void tsAddLink_Click(object sender, EventArgs e)
        {
            FRM_AddLinkEmp a = new FRM_AddLinkEmp();
            a.ShowDialog();
        }

        private void tsLinkManagment_Click(object sender, EventArgs e)
        {
            FRM_DeleteUpdateLinkEmp a = new FRM_DeleteUpdateLinkEmp();
            a.ShowDialog();
        }

        private void tsAddTask_Click(object sender, EventArgs e)
        {
            FRM_AddNewTask a = new FRM_AddNewTask();
            a.ShowDialog();
        }

        private void tsTaskTable_Click(object sender, EventArgs e)
        {
            FRM_Task_Table a = new FRM_Task_Table();
            a.ShowDialog();
        }

        private void tsTaskManagment_Click(object sender, EventArgs e)
        {
            FRM_TaskManager a = new FRM_TaskManager();
            a.ShowDialog();
        }

        private void tsViewReport_Click(object sender, EventArgs e)
        {
            FRM_Report a = new FRM_Report();
            a.ShowDialog();
        }
    }
}
