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
    public partial class FRM_Report : Form
    {
        public FRM_Report()
        {
            InitializeComponent();
            cmbStatus.Items.Add(FRM_Main.notEXE);
            cmbStatus.Items.Add(FRM_Main.ToDoEXE);
            cmbStatus.Items.Add(FRM_Main.DoneEXE);
            cmbStatus.Text = FRM_Main.ToDoEXE;
            fillEmp();
            dgvTasks.DataSource = ClassReport.selectAllTask();
        }
        void fillEmp() 
        {
            try
            {
                DataTable dt = ClassEmpDepart.DisplayAllEmp();
                cmbEmp.DataSource = dt;
                cmbEmp.DisplayMember = "الاسم الكامل";
                cmbEmp.ValueMember = "رقم المعرف";
            }
            catch (Exception) { }
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            dgvTasks.DataSource = ClassReport.selectAllTask();
            cmbEmp.Enabled = cmbStatus.Enabled = dtpDate.Enabled = false;
             chkEmp.Checked = chkStatus.Checked =chkDate1.Checked= false;
        }

        private void chkEmp_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEmp.Checked==true)
            {
                cmbEmp.Enabled = true;
            }
            else { cmbEmp.Enabled = false; }
        }

        private void chkStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStatus.Checked==true)
            {
                cmbStatus.Enabled = true;
            }
            else { cmbStatus.Enabled = false; }
        }

        private void chkDate1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDate1.Checked == true)
            {
                dtpDate.Enabled = true;
            }
            else { dtpDate.Enabled = false; }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (dtpDate.Enabled == false && cmbStatus.Enabled == false && cmbEmp.Enabled == false)
            {
                MessageBox.Show("لم تحدد اي خيار للبحث");
            }
            else 
            {
                if (cmbEmp.Enabled == true && cmbStatus.Enabled == false && dtpDate.Enabled == false)
                {
                    dgvTasks.DataSource = ClassReport.selectAllTaskEmp(cmbEmp.Text);
                }
                if (dtpDate.Enabled == true && cmbEmp.Enabled == true && cmbStatus.Enabled == true)
                {
                    dgvTasks.DataSource = ClassReport.selectAllTaskDateNmaeState(dtpDate.Value, cmbEmp.Text, cmbStatus.Text);
                }
                if (cmbStatus.Enabled == true && cmbEmp.Enabled == false && dtpDate.Enabled == false)
                {
                    dgvTasks.DataSource = ClassReport.selectAllTaskStatus(cmbStatus.Text);
                }
                if (cmbEmp.Enabled == true && cmbStatus.Enabled == true && dtpDate.Enabled == false)
                {
                    dgvTasks.DataSource = ClassReport.selectAllTaskNmaeState(cmbEmp.Text, cmbStatus.Text);
                }
                if (dtpDate.Enabled == true && cmbEmp.Enabled == true && cmbStatus.Enabled == false)
                {
                    dgvTasks.DataSource = ClassReport.selectAllTaskDateNmae(dtpDate.Value, cmbEmp.Text);
                }
                if (dtpDate.Enabled == true && cmbStatus.Enabled == true && cmbEmp.Enabled == false)
                {
                    dgvTasks.DataSource = ClassReport.selectAllTaskDateState(dtpDate.Value, cmbStatus.Text);
                }
                if (dtpDate.Enabled == true && cmbStatus.Enabled == false && cmbEmp.Enabled == false)
                {
                    dgvTasks.DataSource = ClassReport.selectAllTaskDate(dtpDate.Value);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvTasks.DataSource = ClassReport.SearchPublicAllTask(txtSearch.Text);
            chkDate1.Checked = chkEmp.Checked = chkStatus.Checked = false;
        }

        private void dgvTasks_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvTasks.CurrentRow.Cells[4].Value.ToString().Equals(FRM_Main.notEXE))
                {
                    MessageBox.Show("هذه المهمة لم تدخل قيد الانجاز بعد .. لا توجد اي تقارير تخصها");
                }
                else
                {
                    FRM_TaskDetailsReports a = new FRM_TaskDetailsReports(dgvTasks.CurrentRow.Cells[0].Value.ToString());
                    a.ShowDialog();
                }
            }
            catch (Exception) { }
        }
    }
}
