using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Task_Manager.BL;
using System.IO;

namespace Task_Manager.PL
{
    public partial class FRM_Task_Table : Form
    {
        string btnClicked = "";
        string TaskFilePass = "";
        string sourcePath = "";
        string destinationPath = "";
        string destinationFileName = "";
        string destinationFile = "";
        string noAttach ="لا يوجد ملف مرفق مع هذه المهمة";
        public FRM_Task_Table()
        {
            InitializeComponent();
            try
            {
                dgvTasks.DataSource = ClassTasks.selectTaskNotExecute(FRM_Main.Emp_id);
            }
            catch (Exception) { }
        }

        private void btnTaskNotExecute_Click(object sender, EventArgs e)
        {
            txtReportID.Text = txtReportDate.Text = rtxtReportDiscreption.Text = "";
            dgvNotes.DataSource = null;
            txtTaskID.Text = txtTitle.Text = rtxtDiscreption.Text = txtDateCreated.Text = txtNameCreated.Text = TaskFilePass = "";
            btnAddReport.Enabled = btnConfirmAndExe.Enabled=btnClickHere.Enabled = false;
            btnClicked = FRM_Main.notEXE;
            dgvTasks.DataSource = ClassTasks.selectTaskNotExecute(FRM_Main.Emp_id);
            btnUpdateReport.Enabled = false;

        }

        private void btnTaskToDo_Click(object sender, EventArgs e)
        {
            txtReportID.Text = txtReportDate.Text = rtxtReportDiscreption.Text = "";
            dgvNotes.DataSource = null;
            txtTaskID.Text = txtTitle.Text = rtxtDiscreption.Text = txtDateCreated.Text = txtNameCreated.Text = TaskFilePass = "";
            btnAddReport.Enabled = btnConfirmAndExe.Enabled = btnClickHere.Enabled = false;
            btnClicked = FRM_Main.ToDoEXE;
            dgvTasks.DataSource = ClassTasks.selectTaskToDoNowExecute(FRM_Main.Emp_id);
            btnUpdateReport.Enabled = false;
        }

        private void btnTaskDone_Click(object sender, EventArgs e)
        {
            txtReportID.Text = txtReportDate.Text = rtxtReportDiscreption.Text = "";
            dgvNotes.DataSource = null;
            txtTaskID.Text = txtTitle.Text = rtxtDiscreption.Text = txtDateCreated.Text = txtNameCreated.Text = TaskFilePass = "";
            btnAddReport.Enabled = btnConfirmAndExe.Enabled = btnClickHere.Enabled = false;
            btnClicked = FRM_Main.DoneEXE; 
            dgvTasks.DataSource = ClassTasks.selectTaskDoneNowExecute(FRM_Main.Emp_id);
            btnUpdateReport.Enabled = false;
        }

        private void dgvTasks_DoubleClick(object sender, EventArgs e)
        {
            
            txtReportID.Text = txtReportDate.Text = rtxtReportDiscreption.Text = "";
            try
            {
                DataTable dt = ClassTasks.selectTaskWithPath(int.Parse(dgvTasks.CurrentRow.Cells[0].Value.ToString()));
                if (dt.Rows[0][0].ToString().Equals(""))
                {
                    lbAttach.Text = noAttach;
                    btnClickHere.Enabled = false;
                }
                else
                {
                    lbAttach.Text = "يوجد ملف مرفق مع هذه المهمة لتحميله : ";
                    btnClickHere.Enabled = true;
                    TaskFilePass = dt.Rows[0][0].ToString();
                }

                txtTaskID.Text = dgvTasks.CurrentRow.Cells[0].Value.ToString();
                txtTitle.Text = dgvTasks.CurrentRow.Cells[1].Value.ToString();
                rtxtDiscreption.Text = dgvTasks.CurrentRow.Cells[2].Value.ToString();
                txtDateCreated.Text = dgvTasks.CurrentRow.Cells[3].Value.ToString();
                txtNameCreated.Text = dgvTasks.CurrentRow.Cells[4].Value.ToString();
                dgvNotes.DataSource = ClassTasks.selectReportByID(int.Parse(txtTaskID.Text));
                if (btnClicked.Equals(FRM_Main.DoneEXE))
                {
                    btnUpdateReport.Enabled=btnAddReport.Enabled = btnConfirmAndExe.Enabled = false;

                }
                else 
                {
                    btnAddReport.Enabled = btnConfirmAndExe.Enabled = true;
                }
                
            }
            catch (Exception) { }
            
        }

        private void btnClickHere_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.ShowDialog();
                destinationPath = savefile.InitialDirectory;
                sourcePath = @TaskFilePass;

                string input = sourcePath;
                input = input.Substring(input.LastIndexOf(@"."));
                
                //".xlsx"

                destinationFileName = savefile.FileName+input ;
                
                destinationFile = System.IO.Path.Combine(destinationPath, destinationFileName);
                System.IO.File.Copy(sourcePath, destinationFile, false);

                MessageBox.Show("تم تحميل الملف بنجاح");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddReport_Click(object sender, EventArgs e)
        {
            if (rtxtDailyReport.Text.Equals(""))
            {
                MessageBox.Show("لا يمكن اضافة تقرير فارغ");
            }
            else 
            {
                int i = ClassTasks.AddReportToTask(rtxtDailyReport.Text, DateTime.Now, int.Parse(txtTaskID.Text));
                dgvNotes.DataSource = ClassTasks.selectReportByID(int.Parse(txtTaskID.Text));
                int Upd_status = ClassTasks.update_Status(int.Parse(txtTaskID.Text), FRM_Main.ToDoEXE, DateTime.Now);

                rtxtDailyReport.Text = "";
                MessageBox.Show("تم حفظ التقرير بنجاح");
                dgvTasks.DataSource = ClassTasks.selectTaskNotExecute(FRM_Main.Emp_id);
            }
        }

        private void dgvNotes_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtReportID.Text = dgvNotes.CurrentRow.Cells[0].Value.ToString();
                txtReportDate.Text = dgvNotes.CurrentRow.Cells[2].Value.ToString();
                rtxtReportDiscreption.Text = dgvNotes.CurrentRow.Cells[1].Value.ToString();
                if (btnClicked.Equals(FRM_Main.ToDoEXE))
                {
                    btnUpdateReport.Enabled = true;
                }
            }
            catch (Exception) { }
        }

        private void btnUpdateReport_Click(object sender, EventArgs e)
        {
            if (rtxtReportDiscreption.Text.Equals("")||txtReportID.Text.Equals(""))
            {
                MessageBox.Show("لا يوجد بيانات لاضافتها");
            }
            else 
            {
                int i = ClassTasks.updateNote(int.Parse(txtReportID.Text), rtxtReportDiscreption.Text);
                txtReportID.Text = txtReportDate.Text = rtxtReportDiscreption.Text = "";
                dgvNotes.DataSource = ClassTasks.selectReportByID(int.Parse(txtTaskID.Text));
                MessageBox.Show("تمت عملية التعديل بنجاح");
            }
        }

        private void btnConfirmAndExe_Click(object sender, EventArgs e)
        {
            int i = ClassTasks.update_Status(int.Parse(txtTaskID.Text), FRM_Main.DoneEXE, DateTime.Now);
            txtReportID.Text = txtReportDate.Text = rtxtReportDiscreption.Text = "";
            dgvNotes.DataSource = null;
            txtTaskID.Text = txtTitle.Text = rtxtDiscreption.Text = txtDateCreated.Text = txtNameCreated.Text = TaskFilePass = "";
            btnAddReport.Enabled = btnConfirmAndExe.Enabled = btnClickHere.Enabled = false;
            dgvTasks.DataSource = ClassTasks.selectTaskToDoNowExecute(FRM_Main.Emp_id);
            MessageBox.Show("تم الانتهاء من هذه المهمة و ترحيلها الى قائمة المهام المنجزة");
            
        }
    }
}
