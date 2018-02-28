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
    public partial class FRM_DepartManagment : Form
    {
        public FRM_DepartManagment()
        {
            InitializeComponent();
            display();
        }
        void display() 
        {
            DataTable dt = ClassEmpDepart.selectAllDepartment();
            dgvDepartment.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = ClassEmpDepart.SearchDepartment(txtSearch.Text);
            dgvDepartment.DataSource = dt;
        }

        private void dgvDepartment_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtID.Text = dgvDepartment.SelectedRows[0].Cells[0].Value.ToString();
                txtName.Text = dgvDepartment.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch (Exception) { }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FRM_AddNewDepart a = new FRM_AddNewDepart();
            a.ShowDialog();
        }

        private void FRM_DepartManagment_Activated(object sender, EventArgs e)
        {
            display();
            txtID.Text = txtName.Text = txtSearch.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals("") || txtName.Text.Equals(""))
            {
                MessageBox.Show("الرجاء تحديد عنصر");
            }
            else 
            {
                DataTable dtsearch = ClassEmpDepart.SearchONEDepartment(txtName.Text);
                if (dtsearch.Rows.Count > 0) 
                { 
                    MessageBox.Show("الاسم موجود لم يطرأ اي تعديل"); 
                    txtID.Text = txtName.Text = ""; 
                }
                else 
                {
                    DataTable dt = ClassEmpDepart.updateDepartment(int.Parse(txtID.Text), txtName.Text);
                    txtID.Text = txtName.Text = "";
                    display();
                    MessageBox.Show("تمت عملية التعديل بنجاح");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals(""))
            {
                MessageBox.Show("الرجاء تحديد عنصر");
            }
            else 
            {
                int i = ClassEmpDepart.deleteDepart(int.Parse(txtID.Text));
                txtID.Text = txtName.Text = "";
                display();
                MessageBox.Show("تمت العملية بنجاح");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
