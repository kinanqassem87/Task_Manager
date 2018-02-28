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
    public partial class FRM_TaskDetailsReports : Form
    {
        public FRM_TaskDetailsReports(string s)
        {
            InitializeComponent();
            try
            {
                dgvDetails.DataSource = ClassTasks.selectReportByID(int.Parse(s));
            }
            catch (Exception) { }
        }

        private void dgvDetails_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtDate.Text = dgvDetails.CurrentRow.Cells[2].Value.ToString();
                rtxtReport.Text = dgvDetails.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception) { }
        }
    }
}
