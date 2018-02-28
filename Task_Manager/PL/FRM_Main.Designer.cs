namespace Task_Manager.PL
{
    partial class FRM_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsSign = new System.Windows.Forms.ToolStripMenuItem();
            this.TsSignIn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEmpDep = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAddNewDepart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDepartManag = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsAddEmp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEmpManagment = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsAddLink = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLinkManagment = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_task = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAddTask = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTaskTable = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTaskManagment = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_report = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tsViewReport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSign,
            this.tsEmpDep,
            this.ts_task,
            this.ts_report,
            this.tsAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1229, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsSign
            // 
            this.tsSign.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsSignIn,
            this.tsSignOut,
            this.toolStripSeparator1,
            this.tsChangePassword});
            this.tsSign.Name = "tsSign";
            this.tsSign.Size = new System.Drawing.Size(53, 20);
            this.tsSign.Text = "الدخول";
            // 
            // TsSignIn
            // 
            this.TsSignIn.Name = "TsSignIn";
            this.TsSignIn.Size = new System.Drawing.Size(151, 22);
            this.TsSignIn.Text = "تسجيل دخول";
            this.TsSignIn.Click += new System.EventHandler(this.TsSignIn_Click);
            // 
            // tsSignOut
            // 
            this.tsSignOut.Enabled = false;
            this.tsSignOut.Name = "tsSignOut";
            this.tsSignOut.Size = new System.Drawing.Size(151, 22);
            this.tsSignOut.Text = "تسجيل خروج";
            this.tsSignOut.Click += new System.EventHandler(this.tsSignOut_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(148, 6);
            // 
            // tsChangePassword
            // 
            this.tsChangePassword.Enabled = false;
            this.tsChangePassword.Name = "tsChangePassword";
            this.tsChangePassword.Size = new System.Drawing.Size(151, 22);
            this.tsChangePassword.Text = "تغيير كلمة السر ";
            this.tsChangePassword.Click += new System.EventHandler(this.tsChangePassword_Click);
            // 
            // tsEmpDep
            // 
            this.tsEmpDep.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAddNewDepart,
            this.tsDepartManag,
            this.toolStripSeparator2,
            this.tsAddEmp,
            this.tsEmpManagment,
            this.toolStripSeparator3,
            this.tsAddLink,
            this.tsLinkManagment});
            this.tsEmpDep.Enabled = false;
            this.tsEmpDep.Name = "tsEmpDep";
            this.tsEmpDep.Size = new System.Drawing.Size(115, 20);
            this.tsEmpDep.Text = "الموظفين و الاقسام";
            // 
            // tsAddNewDepart
            // 
            this.tsAddNewDepart.Name = "tsAddNewDepart";
            this.tsAddNewDepart.Size = new System.Drawing.Size(243, 22);
            this.tsAddNewDepart.Text = "اضافة قسم جديد";
            this.tsAddNewDepart.Click += new System.EventHandler(this.tsAddNewDepart_Click);
            // 
            // tsDepartManag
            // 
            this.tsDepartManag.Name = "tsDepartManag";
            this.tsDepartManag.Size = new System.Drawing.Size(243, 22);
            this.tsDepartManag.Text = "ادارة الاقسام";
            this.tsDepartManag.Click += new System.EventHandler(this.tsDepartManag_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(240, 6);
            // 
            // tsAddEmp
            // 
            this.tsAddEmp.Name = "tsAddEmp";
            this.tsAddEmp.Size = new System.Drawing.Size(243, 22);
            this.tsAddEmp.Text = "اضافة موظف جديد";
            this.tsAddEmp.Click += new System.EventHandler(this.tsAddEmp_Click);
            // 
            // tsEmpManagment
            // 
            this.tsEmpManagment.Name = "tsEmpManagment";
            this.tsEmpManagment.Size = new System.Drawing.Size(243, 22);
            this.tsEmpManagment.Text = "ادارة الموظفين";
            this.tsEmpManagment.Click += new System.EventHandler(this.tsEmpManagment_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(240, 6);
            // 
            // tsAddLink
            // 
            this.tsAddLink.Name = "tsAddLink";
            this.tsAddLink.Size = new System.Drawing.Size(243, 22);
            this.tsAddLink.Text = "اضافة روابط لموظف محدد";
            this.tsAddLink.Click += new System.EventHandler(this.tsAddLink_Click);
            // 
            // tsLinkManagment
            // 
            this.tsLinkManagment.Name = "tsLinkManagment";
            this.tsLinkManagment.Size = new System.Drawing.Size(243, 22);
            this.tsLinkManagment.Text = "حذف / تعديل  روابط لموظف محدد";
            this.tsLinkManagment.Click += new System.EventHandler(this.tsLinkManagment_Click);
            // 
            // ts_task
            // 
            this.ts_task.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAddTask,
            this.tsTaskTable,
            this.tsTaskManagment});
            this.ts_task.Enabled = false;
            this.ts_task.Name = "ts_task";
            this.ts_task.Size = new System.Drawing.Size(49, 20);
            this.ts_task.Text = "المهام";
            // 
            // tsAddTask
            // 
            this.tsAddTask.Name = "tsAddTask";
            this.tsAddTask.Size = new System.Drawing.Size(165, 22);
            this.tsAddTask.Text = "اضافة مهمة جديدة";
            this.tsAddTask.Click += new System.EventHandler(this.tsAddTask_Click);
            // 
            // tsTaskTable
            // 
            this.tsTaskTable.Name = "tsTaskTable";
            this.tsTaskTable.Size = new System.Drawing.Size(165, 22);
            this.tsTaskTable.Text = "جدول المهام";
            this.tsTaskTable.Click += new System.EventHandler(this.tsTaskTable_Click);
            // 
            // tsTaskManagment
            // 
            this.tsTaskManagment.Name = "tsTaskManagment";
            this.tsTaskManagment.Size = new System.Drawing.Size(165, 22);
            this.tsTaskManagment.Text = "ادارة المهام";
            this.tsTaskManagment.Click += new System.EventHandler(this.tsTaskManagment_Click);
            // 
            // ts_report
            // 
            this.ts_report.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsViewReport});
            this.ts_report.Enabled = false;
            this.ts_report.Name = "ts_report";
            this.ts_report.Size = new System.Drawing.Size(54, 20);
            this.ts_report.Text = "التقارير";
            // 
            // tsAbout
            // 
            this.tsAbout.Name = "tsAbout";
            this.tsAbout.Size = new System.Drawing.Size(79, 20);
            this.tsAbout.Text = "حول البرنامج";
            this.tsAbout.Click += new System.EventHandler(this.tsAbout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 566);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1229, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(49, 17);
            this.toolStripStatusLabel1.Text = "الاسم : ؟";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Task_Manager.Properties.Resources.task_management_tool;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1229, 564);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tsViewReport
            // 
            this.tsViewReport.Name = "tsViewReport";
            this.tsViewReport.Size = new System.Drawing.Size(162, 22);
            this.tsViewReport.Text = "عرض تقرير المهام";
            this.tsViewReport.Click += new System.EventHandler(this.tsViewReport_Click);
            // 
            // FRM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 588);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FRM_Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الواجهة الرئيسية";
            this.Activated += new System.EventHandler(this.FRM_Main_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsSign;
        private System.Windows.Forms.ToolStripMenuItem TsSignIn;
        private System.Windows.Forms.ToolStripMenuItem tsSignOut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsChangePassword;
        private System.Windows.Forms.ToolStripMenuItem tsEmpDep;
        private System.Windows.Forms.ToolStripMenuItem ts_task;
        private System.Windows.Forms.ToolStripMenuItem ts_report;
        private System.Windows.Forms.ToolStripMenuItem tsAbout;
        private System.Windows.Forms.ToolStripMenuItem tsAddNewDepart;
        private System.Windows.Forms.ToolStripMenuItem tsDepartManag;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem tsAddEmp;
        private System.Windows.Forms.ToolStripMenuItem tsEmpManagment;
        private System.Windows.Forms.ToolStripMenuItem tsAddTask;
        private System.Windows.Forms.ToolStripMenuItem tsTaskManagment;
        private System.Windows.Forms.ToolStripMenuItem tsTaskTable;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsAddLink;
        private System.Windows.Forms.ToolStripMenuItem tsLinkManagment;
        private System.Windows.Forms.ToolStripMenuItem tsViewReport;
    }
}