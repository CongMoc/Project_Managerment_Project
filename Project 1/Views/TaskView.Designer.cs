namespace Project_1.Views
{
    partial class TaskView
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageTask = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbPercent = new System.Windows.Forms.Label();
            this.chartPercentTask = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pbReloadForm = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvTaskList = new System.Windows.Forms.DataGridView();
            this.tabPageTaskDetail = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRequest = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboBestTool = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateWork = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNameTask = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNameProject = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cboDeveloper = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPageTask.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPercentTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReloadForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskList)).BeginInit();
            this.tabPageTaskDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageTask);
            this.tabControl1.Controls.Add(this.tabPageTaskDetail);
            this.tabControl1.Location = new System.Drawing.Point(7, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(850, 537);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPageTask
            // 
            this.tabPageTask.Controls.Add(this.panel1);
            this.tabPageTask.Controls.Add(this.pbReloadForm);
            this.tabPageTask.Controls.Add(this.btnEdit);
            this.tabPageTask.Controls.Add(this.btnDelete);
            this.tabPageTask.Controls.Add(this.txtKeyword);
            this.tabPageTask.Controls.Add(this.btnSearch);
            this.tabPageTask.Controls.Add(this.dgvTaskList);
            this.tabPageTask.Location = new System.Drawing.Point(4, 22);
            this.tabPageTask.Name = "tabPageTask";
            this.tabPageTask.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTask.Size = new System.Drawing.Size(842, 511);
            this.tabPageTask.TabIndex = 1;
            this.tabPageTask.Text = "Task";
            this.tabPageTask.UseVisualStyleBackColor = true;
            this.tabPageTask.Click += new System.EventHandler(this.tabPageTask_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbPercent);
            this.panel1.Controls.Add(this.chartPercentTask);
            this.panel1.Location = new System.Drawing.Point(13, 272);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 233);
            this.panel1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(151)))), ((int)(((byte)(226)))));
            this.label5.Location = new System.Drawing.Point(766, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 32);
            this.label5.TabIndex = 54;
            this.label5.Text = "%";
            // 
            // lbPercent
            // 
            this.lbPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPercent.AutoSize = true;
            this.lbPercent.Enabled = false;
            this.lbPercent.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(151)))), ((int)(((byte)(226)))));
            this.lbPercent.Location = new System.Drawing.Point(682, 85);
            this.lbPercent.Name = "lbPercent";
            this.lbPercent.Size = new System.Drawing.Size(51, 40);
            this.lbPercent.TabIndex = 53;
            this.lbPercent.Text = "%";
            // 
            // chartPercentTask
            // 
            this.chartPercentTask.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartPercentTask.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.chartPercentTask.Legends.Add(legend1);
            this.chartPercentTask.Location = new System.Drawing.Point(3, 3);
            this.chartPercentTask.Name = "chartPercentTask";
            this.chartPercentTask.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Percent";
            this.chartPercentTask.Series.Add(series1);
            this.chartPercentTask.Size = new System.Drawing.Size(676, 224);
            this.chartPercentTask.TabIndex = 52;
            this.chartPercentTask.Text = "chart1";
            // 
            // pbReloadForm
            // 
            this.pbReloadForm.Image = global::Project_1.Properties.Resources.laod;
            this.pbReloadForm.Location = new System.Drawing.Point(470, 6);
            this.pbReloadForm.Name = "pbReloadForm";
            this.pbReloadForm.Size = new System.Drawing.Size(31, 24);
            this.pbReloadForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbReloadForm.TabIndex = 14;
            this.pbReloadForm.TabStop = false;
            this.pbReloadForm.Click += new System.EventHandler(this.pbReloadForm_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.Cyan;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(641, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 23);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Update";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(737, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // txtKeyword
            // 
            this.txtKeyword.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyword.Location = new System.Drawing.Point(13, 8);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(355, 22);
            this.txtKeyword.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(185)))), ((int)(((byte)(235)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(374, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search ";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // dgvTaskList
            // 
            this.dgvTaskList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTaskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaskList.Location = new System.Drawing.Point(13, 36);
            this.dgvTaskList.Name = "dgvTaskList";
            this.dgvTaskList.Size = new System.Drawing.Size(814, 230);
            this.dgvTaskList.TabIndex = 8;
            this.dgvTaskList.Click += new System.EventHandler(this.dgvTaskList_Click);
            // 
            // tabPageTaskDetail
            // 
            this.tabPageTaskDetail.Controls.Add(this.label6);
            this.tabPageTaskDetail.Controls.Add(this.txtRequest);
            this.tabPageTaskDetail.Controls.Add(this.label2);
            this.tabPageTaskDetail.Controls.Add(this.cboBestTool);
            this.tabPageTaskDetail.Controls.Add(this.label3);
            this.tabPageTaskDetail.Controls.Add(this.cboRole);
            this.tabPageTaskDetail.Controls.Add(this.cboStatus);
            this.tabPageTaskDetail.Controls.Add(this.label1);
            this.tabPageTaskDetail.Controls.Add(this.dtpDateWork);
            this.tabPageTaskDetail.Controls.Add(this.label4);
            this.tabPageTaskDetail.Controls.Add(this.label8);
            this.tabPageTaskDetail.Controls.Add(this.txtNameTask);
            this.tabPageTaskDetail.Controls.Add(this.btnCancel);
            this.tabPageTaskDetail.Controls.Add(this.btnSave);
            this.tabPageTaskDetail.Controls.Add(this.label12);
            this.tabPageTaskDetail.Controls.Add(this.label13);
            this.tabPageTaskDetail.Controls.Add(this.label14);
            this.tabPageTaskDetail.Controls.Add(this.txtNameProject);
            this.tabPageTaskDetail.Controls.Add(this.txtDescription);
            this.tabPageTaskDetail.Controls.Add(this.cboDeveloper);
            this.tabPageTaskDetail.Location = new System.Drawing.Point(4, 22);
            this.tabPageTaskDetail.Name = "tabPageTaskDetail";
            this.tabPageTaskDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTaskDetail.Size = new System.Drawing.Size(842, 511);
            this.tabPageTaskDetail.TabIndex = 3;
            this.tabPageTaskDetail.Text = "TaskDetail";
            this.tabPageTaskDetail.UseVisualStyleBackColor = true;
            this.tabPageTaskDetail.Click += new System.EventHandler(this.tabPageTaskDetail_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(456, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 105;
            this.label6.Text = "Request:";
            // 
            // txtRequest
            // 
            this.txtRequest.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequest.Location = new System.Drawing.Point(544, 267);
            this.txtRequest.Multiline = true;
            this.txtRequest.Name = "txtRequest";
            this.txtRequest.Size = new System.Drawing.Size(279, 67);
            this.txtRequest.TabIndex = 104;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 103;
            this.label2.Text = "Best tool:";
            // 
            // cboBestTool
            // 
            this.cboBestTool.FormattingEnabled = true;
            this.cboBestTool.Location = new System.Drawing.Point(544, 19);
            this.cboBestTool.Name = "cboBestTool";
            this.cboBestTool.Size = new System.Drawing.Size(279, 21);
            this.cboBestTool.TabIndex = 102;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 101;
            this.label3.Text = "Role:";
            // 
            // cboRole
            // 
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Location = new System.Drawing.Point(544, 159);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(279, 21);
            this.cboRole.TabIndex = 100;
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "On Hold",
            "Working ",
            "Complete"});
            this.cboStatus.Location = new System.Drawing.Point(544, 91);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(279, 21);
            this.cboStatus.TabIndex = 99;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 98;
            this.label1.Text = "Developer:";
            // 
            // dtpDateWork
            // 
            this.dtpDateWork.CalendarFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateWork.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateWork.Location = new System.Drawing.Point(130, 212);
            this.dtpDateWork.MaxDate = new System.DateTime(2030, 12, 12, 0, 0, 0, 0);
            this.dtpDateWork.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtpDateWork.Name = "dtpDateWork";
            this.dtpDateWork.Size = new System.Drawing.Size(119, 20);
            this.dtpDateWork.TabIndex = 96;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 95;
            this.label4.Text = "Status:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 94;
            this.label8.Text = "Name Task:";
            // 
            // txtNameTask
            // 
            this.txtNameTask.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameTask.Location = new System.Drawing.Point(130, 22);
            this.txtNameTask.Name = "txtNameTask";
            this.txtNameTask.Size = new System.Drawing.Size(279, 22);
            this.txtNameTask.TabIndex = 93;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(459, 471);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 23);
            this.btnCancel.TabIndex = 92;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(185)))), ((int)(((byte)(235)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(289, 471);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 23);
            this.btnSave.TabIndex = 91;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 216);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 89;
            this.label12.Text = "Date working:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(42, 271);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 88;
            this.label13.Text = "Description:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(42, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 13);
            this.label14.TabIndex = 87;
            this.label14.Text = "Name Project:";
            // 
            // txtNameProject
            // 
            this.txtNameProject.Enabled = false;
            this.txtNameProject.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameProject.Location = new System.Drawing.Point(130, 90);
            this.txtNameProject.Name = "txtNameProject";
            this.txtNameProject.Size = new System.Drawing.Size(279, 22);
            this.txtNameProject.TabIndex = 86;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(130, 267);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(279, 67);
            this.txtDescription.TabIndex = 85;
            // 
            // cboDeveloper
            // 
            this.cboDeveloper.FormattingEnabled = true;
            this.cboDeveloper.Location = new System.Drawing.Point(130, 159);
            this.cboDeveloper.Name = "cboDeveloper";
            this.cboDeveloper.Size = new System.Drawing.Size(279, 21);
            this.cboDeveloper.TabIndex = 84;
            // 
            // TaskView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 561);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaskView";
            this.Text = "TaskView";
            this.tabControl1.ResumeLayout(false);
            this.tabPageTask.ResumeLayout(false);
            this.tabPageTask.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPercentTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReloadForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskList)).EndInit();
            this.tabPageTaskDetail.ResumeLayout(false);
            this.tabPageTaskDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageTask;
        private System.Windows.Forms.DataGridView dgvTaskList;
        private System.Windows.Forms.TabPage tabPageTaskDetail;
        private System.Windows.Forms.PictureBox pbReloadForm;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboBestTool;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateWork;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNameTask;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNameProject;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cboDeveloper;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbPercent;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPercentTask;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRequest;
    }
}