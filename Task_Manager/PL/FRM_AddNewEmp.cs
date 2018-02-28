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
    public partial class FRM_AddNewEmp : Form
    {
        public FRM_AddNewEmp()
        {
            InitializeComponent();
            fillPermission();
            fillDepartment();
        }
        void fillPermission() 
        {
            cmbPermission.Items.Add("Admin");
            cmbPermission.Items.Add("User");
            cmbPermission.Text = "User";
        }
        void fillDepartment() 
        {
            DataTable dt = ClassEmpDepart.selectAllDepartment();
            cmbDepartment.DataSource = dt;
            cmbDepartment.DisplayMember = "اسم القسم";
            cmbDepartment.ValueMember = "رقم المعرف";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int found = 0;
            if (txtFullName.Text.Equals("") || txtUserName.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                MessageBox.Show("البيانات المدخلة غير كافية ");
            }
            else 
            {
                DataTable dt = ClassEmpDepart.SearchOneEmp(txtUserName.Text);
                if (dt.Rows.Count > 0) { found = 1; }

                if (found != 1)
                {
                    int addEmp = ClassEmpDepart.AddNewEmp(txtUserName.Text, txtPassword.Text, cmbPermission.Text, (int)cmbDepartment.SelectedValue, txtFullName.Text, txtPhone.Text, txtAddress.Text);
                    MessageBox.Show("تمت عملية الحفظ بنجاح");
                    txtAddress.Text = txtFullName.Text = txtPassword.Text = txtPhone.Text = txtUserName.Text = "";
                }
                else { MessageBox.Show("الاسم الكامل او اسم المستخدم موجود بالفعل "); }
            }
        }
    }
}
