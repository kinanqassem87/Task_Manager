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
    public partial class FRM_SignIn : Form
    {
        string stateEnter = "";
        public FRM_SignIn()
        {
           
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            DataTable dt = ClassSign.selectAllEmp();
            if (txtUserName.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                MessageBox.Show("الرجاء تعبئة كل الحقول");
            }
            else
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i][1].Equals(txtUserName.Text))
                    {
                        if (dt.Rows[i][2].Equals(txtPassword.Text))
                        {
                            Close();
                            stateEnter = "1";
                            FRM_Main.Emp_id = int.Parse(dt.Rows[i][0].ToString());
                            FRM_Main.user_name = dt.Rows[i][1].ToString();
                            FRM_Main.U_Password = dt.Rows[i][2].ToString();
                            FRM_Main.PerMission = dt.Rows[i][3].ToString();
                            FRM_Main.Full_Name = dt.Rows[i][4].ToString();
                            FRM_Main.Department = dt.Rows[i][5].ToString();
                        }

                    }
                }
                if (!stateEnter.Equals("1"))
                {
                    MessageBox.Show("اسم المستخدم أو كلمة السر غير صحيحة");
                    txtUserName.Text = txtPassword.Text = "";
                }

            }
        }
    }
}
