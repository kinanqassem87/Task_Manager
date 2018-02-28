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
    public partial class FRM_DeleteUpdateLinkEmp : Form
    {
        DataTable allSlave = new DataTable();
        DataTable dt1 = ClassEmpDepart.DisplayAllEmp();
        DataTable dt2 = ClassEmpDepart.DisplayAllEmp();
        string Emp_ID = "";
        string Emp_FullName = "";
        string Department = "";
        public FRM_DeleteUpdateLinkEmp()
        {
            InitializeComponent();
            fillEmpManag();
            fillEmpUser();
        }
        void fillEmpManag()
        {
            cmbEmpManag.DataSource = dt1;
            cmbEmpManag.DisplayMember = "الاسم الكامل";
            cmbEmpManag.ValueMember = "رقم المعرف";
        }
        void fillEmpUser()
        {
            cmbEmpUser.DataSource = dt2;
            cmbEmpUser.DisplayMember = "الاسم الكامل";
            cmbEmpUser.ValueMember = "رقم المعرف";
        }

        private void btnSelected_Click(object sender, EventArgs e)
        {
            cmbEmpUser.Enabled = btnAdd.Enabled = btnDelete.Enabled = btnSave.Enabled = true;
            cmbEmpManag.Enabled = btnSelected.Enabled = false;
            DataTable AssignEmpID = ClassEmpDepart.searchempinAssign((int)cmbEmpManag.SelectedValue);

            for (int i = 0; i < AssignEmpID.Rows.Count; i++) 
            {
                DataTable empFromID = ClassEmpDepart.searchempByID(int.Parse(AssignEmpID.Rows[i][0].ToString()));

                dgvEmp.Rows.Add(empFromID.Rows[0][0].ToString(), empFromID.Rows[0][1].ToString(), empFromID.Rows[0][2].ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmp.Rows.Count > 0)
            {
                dgvEmp.Rows.Remove(dgvEmp.CurrentRow);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int found = 0;
            int ID = (int)cmbEmpUser.SelectedValue;
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                if (dt2.Rows[i][0].ToString().Equals(ID.ToString()))
                {
                    Emp_ID = dt2.Rows[i][0].ToString();
                    Emp_FullName = dt2.Rows[i][1].ToString();
                    Department = dt2.Rows[i][2].ToString();
                }

            }
            //************ from dataGridView ---1
            for (int x = 0; x < dgvEmp.Rows.Count; x++)
            {
                if (dgvEmp.Rows[x].Cells[0].Value.ToString().Equals(Emp_ID)) { found = 1; MessageBox.Show("هذا الموظف تمت اضافته بالفعل"); }
            }


            if (found != 1)
            {
                dgvEmp.Rows.Add(Emp_ID, Emp_FullName, Department);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
                int del = ClassEmpDepart.DeleteSlaveByEmpID((int)cmbEmpManag.SelectedValue);

                for (int i = 0; i < dgvEmp.Rows.Count; i++)
                {
                    int addemp = ClassEmpDepart.addEmpSlave(int.Parse(dgvEmp.Rows[i].Cells[0].Value.ToString()), (int)cmbEmpManag.SelectedValue);
                }
                btnAdd.Enabled = btnCancel.Enabled = btnSave.Enabled = btnDelete.Enabled = cmbEmpUser.Enabled = false;
                MessageBox.Show("تمت العملية بنجاح");
            
        }
    }
}
