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
    public partial class FRM_EmpManagment : Form
    {
        public FRM_EmpManagment()
        {
            InitializeComponent();
            display();
            fillDepartment();
            fillPermission();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void display() 
        {
            DataTable dt = ClassEmpDepart.DisplayAllEmp();
            dgvEmp.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = ClassEmpDepart.SearchEmp(txtSearch.Text);
            dgvEmp.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_AddNewEmp a = new FRM_AddNewEmp();
            a.ShowDialog();
            display();
        }
        void fillDepartment() 
        {
            DataTable dt = ClassEmpDepart.selectAllDepartment();
            cmbDepartment.DataSource = dt;
            cmbDepartment.DisplayMember = "اسم القسم";
            cmbDepartment.ValueMember = "رقم المعرف";
        }
        void fillPermission()
        {
            cmbPermission.Items.Add("Admin");
            cmbPermission.Items.Add("User");
        }

        private void dgvEmp_DoubleClick(object sender, EventArgs e)
        {
            txtID.Text = dgvEmp.SelectedRows[0].Cells[0].Value.ToString();
            txtFullName.Text = dgvEmp.SelectedRows[0].Cells[1].Value.ToString();
            txtUserName.Text = dgvEmp.SelectedRows[0].Cells[3].Value.ToString();
            txtPassword.Text = dgvEmp.SelectedRows[0].Cells[4].Value.ToString();
            cmbPermission.Text = dgvEmp.SelectedRows[0].Cells[5].Value.ToString();
            cmbDepartment.Text = dgvEmp.SelectedRows[0].Cells[2].Value.ToString();
            txtPhone.Text = dgvEmp.SelectedRows[0].Cells[6].Value.ToString();
            txtAddress.Text = dgvEmp.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int found = 0;
            if (txtID.Text.Equals("") || txtFullName.Text.Equals("") || txtUserName.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                MessageBox.Show("البيانات المدخلة غير كافية للتعديل");
            }
            else 
            {
                DataTable emp = ClassEmpDepart.SearchOneEmp(txtUserName.Text);
                if (emp.Rows.Count > 0)
                {
                    found = 1;
                    if (emp.Rows[0][0].ToString().Equals(txtID.Text)) { found = 0; } else { found = 1; }

                }
                if (found != 1)
                {
                    int i = ClassEmpDepart.UpdateEmp(int.Parse(txtID.Text), txtUserName.Text, txtPassword.Text, cmbPermission.Text, (int)cmbDepartment.SelectedValue, txtFullName.Text, txtPhone.Text, txtAddress.Text);
                    txtID.Text = txtAddress.Text = txtFullName.Text = txtPassword.Text = txtPhone.Text = txtUserName.Text = "";
                    display();
                    MessageBox.Show("تمت عملية التعديل بنجاح");
                }
                else 
                {
                    MessageBox.Show("اسم المستخدم موجود بالفعل لم يطرأ أي تعديل");
                    txtID.Text = txtAddress.Text = txtFullName.Text = txtPassword.Text = txtPhone.Text = txtUserName.Text = "";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals("") || txtFullName.Text.Equals(""))
            {
                MessageBox.Show("الرجاء تحديد عنصر");
            }
            else 
            {
                try
                {
                    DataTable dt = ClassEmpDepart.selectTaskIDToDel(int.Parse(txtID.Text));
                    if (dt.Rows.Count > 0) 
                    {
                        for (int i = 0; i < dt.Rows.Count; i++) 
                        {
                            int delTaskDet = ClassTasks.deleteTaskDet(int.Parse(dt.Rows[i][0].ToString()));
                        }
                        int delTaskEmp = ClassEmpDepart.deleteTaskEmpID(int.Parse(txtID.Text));
                    }

                    int Assigndel = ClassEmpDepart.delfromSlavWMasterEmp(int.Parse(txtID.Text));
                    int empDel = ClassEmpDepart.DeleteEmp(int.Parse(txtID.Text));
                txtID.Text = txtAddress.Text = txtFullName.Text = txtPassword.Text = txtPhone.Text = txtUserName.Text = "";
                display();
                MessageBox.Show("تمت عملية الحذف بنجاح");
                }
                catch (Exception) { }
            }
        }
    }
}
