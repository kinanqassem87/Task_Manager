namespace Task_Manager.PL
{
    partial class FRM_Task_Table
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTaskDone = new System.Windows.Forms.Button();
            this.btnTaskToDo = new System.Windows.Forms.Button();
            this.btnTaskNotExecute = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTaskID = new System.Windows.Forms.TextBox();
            this.btnClickHere = new System.Windows.Forms.Button();
            this.lbAttach = new System.Windows.Forms.Label();
            this.txtNameCreated = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDateCreated = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtxtDiscreption = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rtxtDailyReport = new System.Windows.Forms.RichTextBox();
            this.btnAddReport = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnUpdateReport = new System.Windows.Forms.Button();
            this.rtxtReportDiscreption = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtReportDate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtReportID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvNotes = new System.Windows.Forms.DataGridView();
            this.btnConfirmAndExe = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTaskDone);
            this.groupBox1.Controls.Add(this.btnTaskToDo);
            this.groupBox1.Controls.Add(this.btnTaskNotExecute);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "العمليات : ";
            // 
            // btnTaskDone
            // 
            this.btnTaskDone.Location = new System.Drawing.Point(6, 19);
            this.btnTaskDone.Name = "btnTaskDone";
            this.btnTaskDone.Size = new System.Drawing.Size(211, 23);
            this.btnTaskDone.TabIndex = 2;
            this.btnTaskDone.Text = "عرض المهام المنجزة";
            this.btnTaskDone.UseVisualStyleBackColor = true;
            this.btnTaskDone.Click += new System.EventHandler(this.btnTaskDone_Click);
            // 
            // btnTaskToDo
            // 
            this.btnTaskToDo.Location = new System.Drawing.Point(223, 19);
            this.btnTaskToDo.Name = "btnTaskToDo";
            this.btnTaskToDo.Size = new System.Drawing.Size(211, 23);
            this.btnTaskToDo.TabIndex = 1;
            this.btnTaskToDo.Text = "عرض المهام التي هي قيد الانجاز";
            this.btnTaskToDo.UseVisualStyleBackColor = true;
            this.btnTaskToDo.Click += new System.EventHandler(this.btnTaskToDo_Click);
            // 
            // btnTaskNotExecute
            // 
            this.btnTaskNotExecute.Location = new System.Drawing.Point(440, 19);
            this.btnTaskNotExecute.Name = "btnTaskNotExecute";
            this.btnTaskNotExecute.Size = new System.Drawing.Size(211, 23);
            this.btnTaskNotExecute.TabIndex = 0;
            this.btnTaskNotExecute.Text = "استيراد المهام الواجب تنفيذها   ";
            this.btnTaskNotExecute.UseVisualStyleBackColor = true;
            this.btnTaskNotExecute.Click += new System.EventHandler(this.btnTaskNotExecute_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTasks);
            this.groupBox2.Location = new System.Drawing.Point(12, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(656, 225);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dgvTasks
            // 
            this.dgvTasks.AllowUserToAddRows = false;
            this.dgvTasks.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvTasks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTasks.Location = new System.Drawing.Point(3, 17);
            this.dgvTasks.MultiSelect = false;
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.ReadOnly = true;
            this.dgvTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTasks.Size = new System.Drawing.Size(650, 205);
            this.dgvTasks.TabIndex = 0;
            this.dgvTasks.DoubleClick += new System.EventHandler(this.dgvTasks_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "عنوان المهمة : ";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(6, 54);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(415, 26);
            this.txtTitle.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtTaskID);
            this.groupBox3.Controls.Add(this.btnClickHere);
            this.groupBox3.Controls.Add(this.lbAttach);
            this.groupBox3.Controls.Add(this.txtNameCreated);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtDateCreated);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.rtxtDiscreption);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtTitle);
            this.groupBox3.Location = new System.Drawing.Point(725, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(564, 374);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "التفاصيل : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(427, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "رقم المعرف : ";
            // 
            // txtTaskID
            // 
            this.txtTaskID.Location = new System.Drawing.Point(6, 22);
            this.txtTaskID.Name = "txtTaskID";
            this.txtTaskID.ReadOnly = true;
            this.txtTaskID.Size = new System.Drawing.Size(415, 21);
            this.txtTaskID.TabIndex = 13;
            // 
            // btnClickHere
            // 
            this.btnClickHere.Enabled = false;
            this.btnClickHere.Location = new System.Drawing.Point(75, 334);
            this.btnClickHere.Name = "btnClickHere";
            this.btnClickHere.Size = new System.Drawing.Size(75, 23);
            this.btnClickHere.TabIndex = 11;
            this.btnClickHere.Text = "اضغط هنا";
            this.btnClickHere.UseVisualStyleBackColor = true;
            this.btnClickHere.Click += new System.EventHandler(this.btnClickHere_Click);
            // 
            // lbAttach
            // 
            this.lbAttach.AutoSize = true;
            this.lbAttach.Location = new System.Drawing.Point(156, 339);
            this.lbAttach.Name = "lbAttach";
            this.lbAttach.Size = new System.Drawing.Size(200, 13);
            this.lbAttach.TabIndex = 10;
            this.lbAttach.Text = "يوجد ملف مرفق مع هذه المهمة لتحميله : ";
            // 
            // txtNameCreated
            // 
            this.txtNameCreated.Location = new System.Drawing.Point(7, 308);
            this.txtNameCreated.Name = "txtNameCreated";
            this.txtNameCreated.ReadOnly = true;
            this.txtNameCreated.Size = new System.Drawing.Size(415, 21);
            this.txtNameCreated.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "اسم منشئ المهمة : ";
            // 
            // txtDateCreated
            // 
            this.txtDateCreated.Location = new System.Drawing.Point(7, 282);
            this.txtDateCreated.Name = "txtDateCreated";
            this.txtDateCreated.ReadOnly = true;
            this.txtDateCreated.Size = new System.Drawing.Size(415, 21);
            this.txtDateCreated.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "تاريخ انشاء المهمة : ";
            // 
            // rtxtDiscreption
            // 
            this.rtxtDiscreption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDiscreption.Location = new System.Drawing.Point(6, 86);
            this.rtxtDiscreption.Name = "rtxtDiscreption";
            this.rtxtDiscreption.ReadOnly = true;
            this.rtxtDiscreption.Size = new System.Drawing.Size(415, 190);
            this.rtxtDiscreption.TabIndex = 5;
            this.rtxtDiscreption.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "شرح المهمة : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(433, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "التقرير اليومي : ";
            // 
            // rtxtDailyReport
            // 
            this.rtxtDailyReport.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDailyReport.Location = new System.Drawing.Point(6, 24);
            this.rtxtDailyReport.Name = "rtxtDailyReport";
            this.rtxtDailyReport.Size = new System.Drawing.Size(421, 210);
            this.rtxtDailyReport.TabIndex = 7;
            this.rtxtDailyReport.Text = "";
            // 
            // btnAddReport
            // 
            this.btnAddReport.Enabled = false;
            this.btnAddReport.Location = new System.Drawing.Point(242, 240);
            this.btnAddReport.Name = "btnAddReport";
            this.btnAddReport.Size = new System.Drawing.Size(185, 23);
            this.btnAddReport.TabIndex = 8;
            this.btnAddReport.Text = "اضافة";
            this.btnAddReport.UseVisualStyleBackColor = true;
            this.btnAddReport.Click += new System.EventHandler(this.btnAddReport_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(6, 240);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "الغاء";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rtxtDailyReport);
            this.groupBox4.Controls.Add(this.btnCancel);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.btnAddReport);
            this.groupBox4.Location = new System.Drawing.Point(725, 392);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(564, 271);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "التقرير اليومي بهذه المهمة المحددة في الاعلى : ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnUpdateReport);
            this.groupBox5.Controls.Add(this.rtxtReportDiscreption);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.txtReportDate);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.txtReportID);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(14, 306);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(703, 80);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "التقارير : ";
            // 
            // btnUpdateReport
            // 
            this.btnUpdateReport.Enabled = false;
            this.btnUpdateReport.Location = new System.Drawing.Point(6, 31);
            this.btnUpdateReport.Name = "btnUpdateReport";
            this.btnUpdateReport.Size = new System.Drawing.Size(50, 26);
            this.btnUpdateReport.TabIndex = 0;
            this.btnUpdateReport.Text = "تعديل";
            this.btnUpdateReport.UseVisualStyleBackColor = true;
            this.btnUpdateReport.Click += new System.EventHandler(this.btnUpdateReport_Click);
            // 
            // rtxtReportDiscreption
            // 
            this.rtxtReportDiscreption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtReportDiscreption.Location = new System.Drawing.Point(62, 24);
            this.rtxtReportDiscreption.Name = "rtxtReportDiscreption";
            this.rtxtReportDiscreption.Size = new System.Drawing.Size(332, 46);
            this.rtxtReportDiscreption.TabIndex = 5;
            this.rtxtReportDiscreption.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(400, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "التقرير : ";
            // 
            // txtReportDate
            // 
            this.txtReportDate.Location = new System.Drawing.Point(464, 50);
            this.txtReportDate.Name = "txtReportDate";
            this.txtReportDate.ReadOnly = true;
            this.txtReportDate.Size = new System.Drawing.Size(136, 21);
            this.txtReportDate.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(606, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "تاريخ التقرير : ";
            // 
            // txtReportID
            // 
            this.txtReportID.Location = new System.Drawing.Point(464, 24);
            this.txtReportID.Name = "txtReportID";
            this.txtReportID.ReadOnly = true;
            this.txtReportID.Size = new System.Drawing.Size(136, 21);
            this.txtReportID.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(605, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "رقم معرف التقرير : ";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgvNotes);
            this.groupBox6.Location = new System.Drawing.Point(12, 401);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(656, 315);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "التقارير الخاصة بالمهمة المحددة : ";
            // 
            // dgvNotes
            // 
            this.dgvNotes.AllowUserToAddRows = false;
            this.dgvNotes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvNotes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNotes.Location = new System.Drawing.Point(3, 17);
            this.dgvNotes.MultiSelect = false;
            this.dgvNotes.Name = "dgvNotes";
            this.dgvNotes.ReadOnly = true;
            this.dgvNotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotes.Size = new System.Drawing.Size(650, 295);
            this.dgvNotes.TabIndex = 0;
            this.dgvNotes.DoubleClick += new System.EventHandler(this.dgvNotes_DoubleClick);
            // 
            // btnConfirmAndExe
            // 
            this.btnConfirmAndExe.Enabled = false;
            this.btnConfirmAndExe.Location = new System.Drawing.Point(907, 669);
            this.btnConfirmAndExe.Name = "btnConfirmAndExe";
            this.btnConfirmAndExe.Size = new System.Drawing.Size(297, 40);
            this.btnConfirmAndExe.TabIndex = 13;
            this.btnConfirmAndExe.Text = "تأكيد انتهاء هذه المهمة بشكل كامل و ترحيلها";
            this.btnConfirmAndExe.UseVisualStyleBackColor = true;
            this.btnConfirmAndExe.Click += new System.EventHandler(this.btnConfirmAndExe_Click);
            // 
            // FRM_Task_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 721);
            this.Controls.Add(this.btnConfirmAndExe);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Task_Table";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "جدول المهام";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTaskDone;
        private System.Windows.Forms.Button btnTaskToDo;
        private System.Windows.Forms.Button btnTaskNotExecute;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTaskID;
        private System.Windows.Forms.Button btnClickHere;
        private System.Windows.Forms.Label lbAttach;
        private System.Windows.Forms.TextBox txtNameCreated;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDateCreated;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtxtDiscreption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtxtDailyReport;
        private System.Windows.Forms.Button btnAddReport;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnUpdateReport;
        private System.Windows.Forms.RichTextBox rtxtReportDiscreption;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtReportDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtReportID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnConfirmAndExe;
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.DataGridView dgvNotes;
    }
}