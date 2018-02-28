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
    public partial class FRM_AddLinkEmp : Form
    {
        DataTable allSlave = new DataTable();
        DataTable dt1 = ClassEmpDepart.DisplayAllEmp();
        DataTable dt2 = ClassEmpDepart.DisplayAllEmp();
        string Emp_ID = "";
        string Emp_FullName = "";
        string Department = "";

        public FRM_AddLinkEmp()
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbEmpManag.Enabled == true)
            {
                allSlave = ClassEmpDepart.selectallEmpSlave((int)cmbEmpManag.SelectedValue);
            }

            int found=0;
            cmbEmpManag.Enabled = false;
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
            //***********from database    ----2
           
                for (int slav = 0; slav < allSlave.Rows.Count; slav++)
                {
                    if (allSlave.Rows[slav][1].ToString().Equals(Emp_ID)) { found = 1; MessageBox.Show("هذا الموظف تمت اضافته بالفعل"); }
                }
            

            if (found != 1)
            {
                dgvEmp.Rows.Add(Emp_ID, Emp_FullName, Department);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmp.Rows.Count > 0)
            {
                dgvEmp.Rows.Remove(dgvEmp.CurrentRow);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
                if (dgvEmp.Rows.Count > 0)
                {
                    for (int i = 0; i < dgvEmp.Rows.Count; i++)
                    {
                        int addemp = ClassEmpDepart.addEmpSlave(int.Parse(dgvEmp.Rows[i].Cells[0].Value.ToString()), (int)cmbEmpManag.SelectedValue);
                    }
                    btnAdd.Enabled = btnCancel.Enabled = btnSave.Enabled = btnDelete.Enabled = cmbEmpUser.Enabled = false;
                    MessageBox.Show("تمت العملية بنجاح");
                }
                else
                {
                    MessageBox.Show("لم تتم اضافة اي عنصر ");
                }
            
        }
    }
}
