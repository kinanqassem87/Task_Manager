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
using System.Net;

namespace Task_Manager.PL
{
    public partial class FRM_AddNewTask : Form
    {
        DataTable dt = ClassTasks.searchempinAssignWithName(FRM_Main.Emp_id);
        string Path = "";
        public FRM_AddNewTask()
        {
            InitializeComponent();
            fillEmp();
            lbName.Text = FRM_Main.Full_Name;
        }
        void fillEmp() 
        {
            
            cmbEmp.DataSource = dt;
            cmbEmp.DisplayMember = "الاسم الكامل";
            cmbEmp.ValueMember = "رقم المعرف";
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please Select File";
            ofd.Filter = "xlsx|*.xlsx|All File|*.*";
                DialogResult dr = ofd.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    Path = ofd.FileName;
                }
                lbTrake.Text = Path;

               
                
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            string sourcePath = "";
            string destinationPath = "";
            string destinationFileName = "";
            string destinationFile = "";
            if (txtTitle.Text.Equals("") || rtxtDiscription.Text.Equals(""))
            {
                MessageBox.Show("الرجاء ادخال التفاصيل");
            }
            else 
            {
                try
                {
                    if (dt.Rows.Count > 0)
                    {
                         sourcePath = @Path;

                         string input = Path;
                         input = input.Substring(input.LastIndexOf(@"."));

                         destinationPath = @"\\192.168.1.99\\AllFilesTasks";
                        // string sourceFileName = "startingStock.xml";
                         destinationFileName = DateTime.Now.ToString("yyyyMMddhhmmss") + input; // named files with date time .
                        // string sourceFile = System.IO.Path.Combine(sourcePath, sourceFileName);
                         destinationFile = System.IO.Path.Combine(destinationPath, destinationFileName, Environment.UserName,"User");

                
                        //if path not found 
                        if (!System.IO.Directory.Exists(destinationPath))
                        {
                            System.IO.Directory.CreateDirectory(destinationPath);
                        }
                      
                            System.IO.File.Copy(sourcePath, destinationFile, true);
                        
                    }
                }
                catch (Exception) {  }
                    //Save .. 
                if (lbTrake.Text.Equals("")) { destinationFile = ""; }
                try
                {
                    int i = ClassTasks.AddNewTask(txtTitle.Text, rtxtDiscription.Text, FRM_Main.notEXE, DateTime.Now, destinationFile, FRM_Main.Emp_id, (int)cmbEmp.SelectedValue, DateTime.Now);
                    txtTitle.Text = rtxtDiscription.Text = Path = lbTrake.Text =  "";
                    btnSave.Enabled = true; 
                    MessageBox.Show("تمت اضافة المهمة بنجاح");
                }
                catch (Exception) { MessageBox.Show("ليس لديك الصلاحية في اسناد هذه المهمة لاي موظف"); }
               
                
            }
        }

    }
}
