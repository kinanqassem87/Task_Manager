using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Task_Manager.BL;

namespace Task_Manager.PL
{
    public partial class FRM_TaskManager : Form
    {
        public FRM_TaskManager()
        {
            InitializeComponent();
            fillState();
            fillEmp();
        }
        void fillState() 
        {
            cmbStatusMode.Items.Add(FRM_Main.notEXE);
            cmbStatusMode.Items.Add(FRM_Main.ToDoEXE);
            cmbStatusMode.Items.Add(FRM_Main.DoneEXE);
        }
        void fillEmp() 
        {
            DataTable dt = ClassEmpDepart.DisplayAllEmp();
            cmbEmpName.DataSource = dt;
            cmbEmpName.DisplayMember = "الاسم الكامل";
            cmbEmpName.ValueMember = "رقم المعرف";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvTasks.DataSource = ClassTasks.searchforTask((int)cmbEmpName.SelectedValue);
            txtName.Text = txtTaskID.Text = rtxtDiscreption.Text = "";
        }

        private void dgvTasks_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtTaskID.Text = dgvTasks.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = dgvTasks.CurrentRow.Cells[1].Value.ToString();
                rtxtDiscreption.Text = dgvTasks.CurrentRow.Cells[2].Value.ToString();
                cmbStatusMode.Text = dgvTasks.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception) { }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtTaskID.Text.Equals("") || txtName.Text.Equals("") || rtxtDiscreption.Text.Equals("") || cmbStatusMode.Text.Equals(""))
            {
                MessageBox.Show("هناك بيانات ناقصة ! . .  لا يمكن اتمام عملية التعديل");
            }
            else 
            {
                int i = ClassTasks.updateTask(int.Parse(txtTaskID.Text), txtName.Text, rtxtDiscreption.Text, cmbStatusMode.Text);
                dgvTasks.DataSource = ClassTasks.searchforTask((int)cmbEmpName.SelectedValue);
                txtName.Text = txtTaskID.Text = rtxtDiscreption.Text = "";
                MessageBox.Show("تمت عملية التعديل بنجاح");

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtTaskID.Text.Equals(""))
            {
                MessageBox.Show("لم يتم تحديد اي مهمة");
            }
            else 
            {
                int delDetTask = ClassTasks.deleteTaskDet(int.Parse(txtTaskID.Text));
                int delTask = ClassTasks.deleteTask(int.Parse(txtTaskID.Text));
                txtTaskID.Text = txtName.Text = rtxtDiscreption.Text = "";
                dgvTasks.DataSource = ClassTasks.searchforTask((int)cmbEmpName.SelectedValue);
                MessageBox.Show("تمت عملية الحذف بنجاح");
            }
        }
    }
}
