namespace Project_1.Views
{
    partial class ManagementTask
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsbbtnExit = new System.Windows.Forms.ToolStripButton();
            this.tsbbtnMinimize = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_ManagementTask = new System.Windows.Forms.TabPage();
            this.pbReloadForm = new System.Windows.Forms.PictureBox();
            this.chartPercentTask = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnSearchTask = new System.Windows.Forms.Button();
            this.dgvManagementTask = new System.Windows.Forms.DataGridView();
            this.tp_ManagementTaskDetail = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRequest = new System.Windows.Forms.TextBox();
            this.dtpDateWork = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboBestTool = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNameTask = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNameProject = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cboDeveloper = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tp_ManagementTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReloadForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPercentTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagementTask)).BeginInit();
            this.tp_ManagementTaskDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(185)))), ((int)(((byte)(235)))));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tsbbtnExit,
            this.tsbbtnMinimize});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(963, 35);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Image = global::Project_1.Properties.Resources.Task;
            this.toolStripLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(171, 32);
            this.toolStripLabel1.Text = "Management Task ";
            // 
            // tsbbtnExit
            // 
            this.tsbbtnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbbtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbbtnExit.Image = global::Project_1.Properties.Resources.exit;
            this.tsbbtnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbbtnExit.Name = "tsbbtnExit";
            this.tsbbtnExit.Size = new System.Drawing.Size(28, 32);
            this.tsbbtnExit.Text = "toolStripButton1";
            // 
            // tsbbtnMinimize
            // 
            this.tsbbtnMinimize.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbbtnMinimize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbbtnMinimize.Image = global::Project_1.Properties.Resources.mini2;
            this.tsbbtnMinimize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbbtnMinimize.Name = "tsbbtnMinimize";
            this.tsbbtnMinimize.Size = new System.Drawing.Size(23, 32);
            this.tsbbtnMinimize.Text = "toolStripButton2";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_ManagementTask);
            this.tabControl1.Controls.Add(this.tp_ManagementTaskDetail);
            this.tabControl1.Location = new System.Drawing.Point(12, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(939, 497);
            this.tabControl1.TabIndex = 2;
            // 
            // tp_ManagementTask
            // 
            this.tp_ManagementTask.Controls.Add(this.pbReloadForm);
            this.tp_ManagementTask.Controls.Add(this.chartPercentTask);
            this.tp_ManagementTask.Controls.Add(this.btnEdit);
            this.tp_ManagementTask.Controls.Add(this.btnAdd);
            this.tp_ManagementTask.Controls.Add(this.btnDelete);
            this.tp_ManagementTask.Controls.Add(this.txtKeyword);
            this.tp_ManagementTask.Controls.Add(this.btnSearchTask);
            this.tp_ManagementTask.Controls.Add(this.dgvManagementTask);
            this.tp_ManagementTask.Location = new System.Drawing.Point(4, 22);
            this.tp_ManagementTask.Name = "tp_ManagementTask";
            this.tp_ManagementTask.Padding = new System.Windows.Forms.Padding(3);
            this.tp_ManagementTask.Size = new System.Drawing.Size(931, 471);
            this.tp_ManagementTask.TabIndex = 0;
            this.tp_ManagementTask.Text = "Management Task";
            this.tp_ManagementTask.UseVisualStyleBackColor = true;
            // 
            // pbReloadForm
            // 
            this.pbReloadForm.Image = global::Project_1.Properties.Resources.laod;
            this.pbReloadForm.Location = new System.Drawing.Point(466, 10);
            this.pbReloadForm.Name = "pbReloadForm";
            this.pbReloadForm.Size = new System.Drawing.Size(31, 24);
            this.pbReloadForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbReloadForm.TabIndex = 15;
            this.pbReloadForm.TabStop = false;
            this.pbReloadForm.Click += new System.EventHandler(this.pbReloadForm_Click);
            // 
            // chartPercentTask
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPercentTask.ChartAreas.Add(chartArea1);
            legend1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.chartPercentTask.Legends.Add(legend1);
            this.chartPercentTask.Location = new System.Drawing.Point(6, 229);
            this.chartPercentTask.Name = "chartPercentTask";
            this.chartPercentTask.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Percent ";
            this.chartPercentTask.Series.Add(series1);
            this.chartPercentTask.Size = new System.Drawing.Size(919, 236);
            this.chartPercentTask.TabIndex = 14;
            this.chartPercentTask.Text = "chart1";
            title1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            title1.Name = "Title1";
            this.chartPercentTask.Titles.Add(title1);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Cyan;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(739, 11);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 23);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Update";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LawnGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(643, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(835, 11);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // txtKeyword
            // 
            this.txtKeyword.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyword.Location = new System.Drawing.Point(9, 12);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(355, 22);
            this.txtKeyword.TabIndex = 10;
            // 
            // btnSearchTask
            // 
            this.btnSearchTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(185)))), ((int)(((byte)(235)))));
            this.btnSearchTask.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchTask.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTask.Location = new System.Drawing.Point(370, 11);
            this.btnSearchTask.Name = "btnSearchTask";
            this.btnSearchTask.Size = new System.Drawing.Size(90, 23);
            this.btnSearchTask.TabIndex = 9;
            this.btnSearchTask.Text = "Search ";
            this.btnSearchTask.UseVisualStyleBackColor = false;
            // 
            // dgvManagementTask
            // 
            this.dgvManagementTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManagementTask.Location = new System.Drawing.Point(7, 40);
            this.dgvManagementTask.Name = "dgvManagementTask";
            this.dgvManagementTask.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvManagementTask.Size = new System.Drawing.Size(918, 183);
            this.dgvManagementTask.TabIndex = 8;
            this.dgvManagementTask.Click += new System.EventHandler(this.dgvManagementTask_Click);
            // 
            // tp_ManagementTaskDetail
            // 
            this.tp_ManagementTaskDetail.Controls.Add(this.label6);
            this.tp_ManagementTaskDetail.Controls.Add(this.txtRequest);
            this.tp_ManagementTaskDetail.Controls.Add(this.dtpDateWork);
            this.tp_ManagementTaskDetail.Controls.Add(this.label5);
            this.tp_ManagementTaskDetail.Controls.Add(this.label2);
            this.tp_ManagementTaskDetail.Controls.Add(this.cboBestTool);
            this.tp_ManagementTaskDetail.Controls.Add(this.label3);
            this.tp_ManagementTaskDetail.Controls.Add(this.cboRole);
            this.tp_ManagementTaskDetail.Controls.Add(this.cboStatus);
            this.tp_ManagementTaskDetail.Controls.Add(this.label1);
            this.tp_ManagementTaskDetail.Controls.Add(this.dtpEnd);
            this.tp_ManagementTaskDetail.Controls.Add(this.dtpStart);
            this.tp_ManagementTaskDetail.Controls.Add(this.label4);
            this.tp_ManagementTaskDetail.Controls.Add(this.label8);
            this.tp_ManagementTaskDetail.Controls.Add(this.txtNameTask);
            this.tp_ManagementTaskDetail.Controls.Add(this.btnCancel);
            this.tp_ManagementTaskDetail.Controls.Add(this.btnSave);
            this.tp_ManagementTaskDetail.Controls.Add(this.label11);
            this.tp_ManagementTaskDetail.Controls.Add(this.label12);
            this.tp_ManagementTaskDetail.Controls.Add(this.label13);
            this.tp_ManagementTaskDetail.Controls.Add(this.label14);
            this.tp_ManagementTaskDetail.Controls.Add(this.txtNameProject);
            this.tp_ManagementTaskDetail.Controls.Add(this.txtDescription);
            this.tp_ManagementTaskDetail.Controls.Add(this.cboDeveloper);
            this.tp_ManagementTaskDetail.Location = new System.Drawing.Point(4, 22);
            this.tp_ManagementTaskDetail.Name = "tp_ManagementTaskDetail";
            this.tp_ManagementTaskDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tp_ManagementTaskDetail.Size = new System.Drawing.Size(931, 471);
            this.tp_ManagementTaskDetail.TabIndex = 1;
            this.tp_ManagementTaskDetail.Text = "Management Task Detail";
            this.tp_ManagementTaskDetail.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(489, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 107;
            this.label6.Text = "Request:";
            // 
            // txtRequest
            // 
            this.txtRequest.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequest.Location = new System.Drawing.Point(577, 275);
            this.txtRequest.Multiline = true;
            this.txtRequest.Name = "txtRequest";
            this.txtRequest.Size = new System.Drawing.Size(279, 67);
            this.txtRequest.TabIndex = 106;
            // 
            // dtpDateWork
            // 
            this.dtpDateWork.CalendarFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateWork.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateWork.Location = new System.Drawing.Point(577, 226);
            this.dtpDateWork.Name = "dtpDateWork";
            this.dtpDateWork.Size = new System.Drawing.Size(279, 20);
            this.dtpDateWork.TabIndex = 105;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(489, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 104;
            this.label5.Text = "Date work:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 103;
            this.label2.Text = "Best tool:";
            // 
            // cboBestTool
            // 
            this.cboBestTool.FormattingEnabled = true;
            this.cboBestTool.Location = new System.Drawing.Point(151, 223);
            this.cboBestTool.Name = "cboBestTool";
            this.cboBestTool.Size = new System.Drawing.Size(279, 21);
            this.cboBestTool.TabIndex = 102;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 101;
            this.label3.Text = "Role:";
            // 
            // cboRole
            // 
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Location = new System.Drawing.Point(151, 178);
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
            this.cboStatus.Location = new System.Drawing.Point(151, 276);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(279, 21);
            this.cboStatus.TabIndex = 99;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 98;
            this.label1.Text = "Developer:";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CalendarFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(577, 91);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(279, 20);
            this.dtpEnd.TabIndex = 97;
            // 
            // dtpStart
            // 
            this.dtpStart.CalendarFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(577, 39);
            this.dtpStart.MaxDate = new System.DateTime(2030, 12, 12, 0, 0, 0, 0);
            this.dtpStart.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(279, 20);
            this.dtpStart.TabIndex = 96;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 95;
            this.label4.Text = "Status:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 94;
            this.label8.Text = "Name Task:";
            // 
            // txtNameTask
            // 
            this.txtNameTask.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameTask.Location = new System.Drawing.Point(151, 41);
            this.txtNameTask.Name = "txtNameTask";
            this.txtNameTask.Size = new System.Drawing.Size(279, 22);
            this.txtNameTask.TabIndex = 93;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(491, 427);
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
            this.btnSave.Location = new System.Drawing.Point(330, 427);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 23);
            this.btnSave.TabIndex = 91;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(489, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 90;
            this.label11.Text = "Complete:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(489, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 89;
            this.label12.Text = "Start date:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(489, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 88;
            this.label13.Text = "Description:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(63, 93);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 13);
            this.label14.TabIndex = 87;
            this.label14.Text = "Name Project:";
            // 
            // txtNameProject
            // 
            this.txtNameProject.Enabled = false;
            this.txtNameProject.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameProject.Location = new System.Drawing.Point(151, 89);
            this.txtNameProject.Name = "txtNameProject";
            this.txtNameProject.Size = new System.Drawing.Size(279, 22);
            this.txtNameProject.TabIndex = 86;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(577, 135);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(279, 67);
            this.txtDescription.TabIndex = 85;
            // 
            // cboDeveloper
            // 
            this.cboDeveloper.FormattingEnabled = true;
            this.cboDeveloper.Location = new System.Drawing.Point(151, 135);
            this.cboDeveloper.Name = "cboDeveloper";
            this.cboDeveloper.Size = new System.Drawing.Size(279, 21);
            this.cboDeveloper.TabIndex = 84;
            // 
            // ManagementTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 537);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagementTask";
            this.Text = "ManagementTask";
            this.Load += new System.EventHandler(this.ManagementTask_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tp_ManagementTask.ResumeLayout(false);
            this.tp_ManagementTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReloadForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPercentTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagementTask)).EndInit();
            this.tp_ManagementTaskDetail.ResumeLayout(false);
            this.tp_ManagementTaskDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tsbbtnExit;
        private System.Windows.Forms.ToolStripButton tsbbtnMinimize;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_ManagementTask;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnSearchTask;
        private System.Windows.Forms.DataGridView dgvManagementTask;
        private System.Windows.Forms.TabPage tp_ManagementTaskDetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboBestTool;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNameTask;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNameProject;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cboDeveloper;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPercentTask;
        private System.Windows.Forms.DateTimePicker dtpDateWork;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbReloadForm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRequest;
    }
}