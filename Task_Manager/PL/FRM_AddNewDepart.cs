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
    public partial class FRM_AddNewDepart : Form
    {
        public FRM_AddNewDepart()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int found = 0;
            if (txtName.Equals(""))
            {
                MessageBox.Show("الرجاء ادخال الاسم أولا");
            }
            else 
            {
                DataTable dt = ClassEmpDepart.selectAllDepartment();
                for (int i = 0; i < dt.Rows.Count; i++) 
                {
                    if (txtName.Text.Equals(dt.Rows[i][1].ToString())) { found = 1; }
                }
                if (found == 0)
                {
                    int AddDep = ClassEmpDepart.AddDepartment(txtName.Text);
                    txtName.Text = "";
                    MessageBox.Show("تمت العملية بنجاح");
                }
                else { MessageBox.Show("هذا الاسم موجود مسبقا !!!!"); }
            }
        }
    }
}
