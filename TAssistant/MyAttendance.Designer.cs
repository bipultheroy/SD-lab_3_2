namespace TAssistant
{
    partial class MyAttendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyAttendance));
            this.TopBorderPanel = new System.Windows.Forms.Panel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.MinButton = new TAssistant.ButtonZ();
            this.MaxButton = new TAssistant.MinMaxButton();
            this.CloseButton = new TAssistant.ButtonZ();
            this.LogoAssintant = new System.Windows.Forms.Label();
            this.LogoTA = new System.Windows.Forms.Label();
            this.MidPanel = new System.Windows.Forms.Panel();
            this.Presentlabel = new System.Windows.Forms.Label();
            this.comboBoxPresent = new System.Windows.Forms.ComboBox();
            this.textBoxCourseNo = new System.Windows.Forms.TextBox();
            this.CourseNolabel = new System.Windows.Forms.Label();
            this.stuSemlabel = new System.Windows.Forms.Label();
            this.comboBoxSemester = new System.Windows.Forms.ComboBox();
            this.stuYearlabel = new System.Windows.Forms.Label();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.UpdateDataBtn = new System.Windows.Forms.Button();
            this.DeptLabel = new System.Windows.Forms.Label();
            this.comboBoxDept = new System.Windows.Forms.ComboBox();
            this.SaveData = new System.Windows.Forms.Button();
            this.AttendanceLabel = new System.Windows.Forms.Label();
            this.textBoxStudentId = new System.Windows.Forms.TextBox();
            this.StudentIdlabel = new System.Windows.Forms.Label();
            this.dataGridViewMyAttendance = new System.Windows.Forms.DataGridView();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.TopPanel.SuspendLayout();
            this.MidPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMyAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // TopBorderPanel
            // 
            this.TopBorderPanel.BackColor = System.Drawing.Color.White;
            this.TopBorderPanel.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.TopBorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.TopBorderPanel.Name = "TopBorderPanel";
            this.TopBorderPanel.Size = new System.Drawing.Size(1000, 3);
            this.TopBorderPanel.TabIndex = 0;
            this.TopBorderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBorderPanel_MouseDown);
            this.TopBorderPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBorderPanel_MouseMove);
            this.TopBorderPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBorderPanel_MouseUp);
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.White;
            this.LeftPanel.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 3);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(3, 597);
            this.LeftPanel.TabIndex = 1;
            this.LeftPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftPanel_MouseDown);
            this.LeftPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftPanel_MouseMove);
            this.LeftPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LeftPanel_MouseUp);
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.Color.White;
            this.RightPanel.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(997, 3);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(3, 597);
            this.RightPanel.TabIndex = 2;
            this.RightPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightPanel_MouseDown);
            this.RightPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RightPanel_MouseMove);
            this.RightPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RightPanel_MouseUp);
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.White;
            this.BottomPanel.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(3, 597);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(994, 3);
            this.BottomPanel.TabIndex = 3;
            this.BottomPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BottomPanel_MouseDown);
            this.BottomPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BottomPanel_MouseMove);
            this.BottomPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BottomPanel_MouseUp);
            // 
            // TopPanel
            // 
            this.TopPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(178)))), ((int)(((byte)(243)))));
            this.TopPanel.Controls.Add(this.MinButton);
            this.TopPanel.Controls.Add(this.MaxButton);
            this.TopPanel.Controls.Add(this.CloseButton);
            this.TopPanel.Controls.Add(this.LogoAssintant);
            this.TopPanel.Controls.Add(this.LogoTA);
            this.TopPanel.Location = new System.Drawing.Point(4, 4);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(993, 49);
            this.TopPanel.TabIndex = 4;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // MinButton
            // 
            this.MinButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(178)))), ((int)(((byte)(243)))));
            this.MinButton.DisplayText = "-";
            this.MinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinButton.ForeColor = System.Drawing.Color.White;
            this.MinButton.Location = new System.Drawing.Point(899, 4);
            this.MinButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(216)))));
            this.MinButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(216)))));
            this.MinButton.Name = "MinButton";
            this.MinButton.Size = new System.Drawing.Size(31, 24);
            this.MinButton.TabIndex = 4;
            this.MinButton.Text = "-";
            this.MinButton.TextLocation_X = 6;
            this.MinButton.TextLocation_Y = -9;
            this.MinButton.UseVisualStyleBackColor = true;
            this.MinButton.Click += new System.EventHandler(this._MinButton_Click);
            // 
            // MaxButton
            // 
            this.MaxButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(178)))), ((int)(((byte)(243)))));
            this.MaxButton.CFormState = TAssistant.MinMaxButton.CustomFormState.Normal;
            this.MaxButton.DisplayText = "_";
            this.MaxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxButton.ForeColor = System.Drawing.Color.White;
            this.MaxButton.Location = new System.Drawing.Point(927, 4);
            this.MaxButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(216)))));
            this.MaxButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(216)))));
            this.MaxButton.Name = "MaxButton";
            this.MaxButton.Size = new System.Drawing.Size(31, 24);
            this.MaxButton.TabIndex = 3;
            this.MaxButton.Text = "MaxButton";
            this.MaxButton.TextLocation_X = 10;
            this.MaxButton.TextLocation_Y = 6;
            this.MaxButton.UseVisualStyleBackColor = true;
            this.MaxButton.Click += new System.EventHandler(this._MaxButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(178)))), ((int)(((byte)(243)))));
            this.CloseButton.DisplayText = "×";
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.Window;
            this.CloseButton.Location = new System.Drawing.Point(957, 4);
            this.CloseButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(216)))));
            this.CloseButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(216)))));
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(31, 24);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "×";
            this.CloseButton.TextLocation_X = 2;
            this.CloseButton.TextLocation_Y = -9;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this._CloseButton_Click);
            // 
            // LogoAssintant
            // 
            this.LogoAssintant.AutoSize = true;
            this.LogoAssintant.BackColor = System.Drawing.Color.Transparent;
            this.LogoAssintant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoAssintant.Font = new System.Drawing.Font("Roboto Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoAssintant.ForeColor = System.Drawing.Color.White;
            this.LogoAssintant.Location = new System.Drawing.Point(28, 15);
            this.LogoAssintant.Margin = new System.Windows.Forms.Padding(0);
            this.LogoAssintant.Name = "LogoAssintant";
            this.LogoAssintant.Size = new System.Drawing.Size(74, 18);
            this.LogoAssintant.TabIndex = 1;
            this.LogoAssintant.Text = "ASSISTANT";
            // 
            // LogoTA
            // 
            this.LogoTA.AutoSize = true;
            this.LogoTA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoTA.Font = new System.Drawing.Font("Roboto Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoTA.ForeColor = System.Drawing.Color.White;
            this.LogoTA.Location = new System.Drawing.Point(9, 9);
            this.LogoTA.Margin = new System.Windows.Forms.Padding(0);
            this.LogoTA.Name = "LogoTA";
            this.LogoTA.Size = new System.Drawing.Size(24, 28);
            this.LogoTA.TabIndex = 0;
            this.LogoTA.Text = "T";
            // 
            // MidPanel
            // 
            this.MidPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MidPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.MidPanel.Controls.Add(this.Presentlabel);
            this.MidPanel.Controls.Add(this.comboBoxPresent);
            this.MidPanel.Controls.Add(this.textBoxCourseNo);
            this.MidPanel.Controls.Add(this.CourseNolabel);
            this.MidPanel.Controls.Add(this.stuSemlabel);
            this.MidPanel.Controls.Add(this.comboBoxSemester);
            this.MidPanel.Controls.Add(this.stuYearlabel);
            this.MidPanel.Controls.Add(this.comboBoxYear);
            this.MidPanel.Controls.Add(this.UpdateDataBtn);
            this.MidPanel.Controls.Add(this.DeptLabel);
            this.MidPanel.Controls.Add(this.comboBoxDept);
            this.MidPanel.Controls.Add(this.SaveData);
            this.MidPanel.Controls.Add(this.AttendanceLabel);
            this.MidPanel.Controls.Add(this.textBoxStudentId);
            this.MidPanel.Controls.Add(this.StudentIdlabel);
            this.MidPanel.ForeColor = System.Drawing.Color.White;
            this.MidPanel.Location = new System.Drawing.Point(4, 55);
            this.MidPanel.Name = "MidPanel";
            this.MidPanel.Size = new System.Drawing.Size(393, 541);
            this.MidPanel.TabIndex = 5;
            // 
            // Presentlabel
            // 
            this.Presentlabel.AutoSize = true;
            this.Presentlabel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Presentlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Presentlabel.Location = new System.Drawing.Point(18, 263);
            this.Presentlabel.Name = "Presentlabel";
            this.Presentlabel.Size = new System.Drawing.Size(64, 16);
            this.Presentlabel.TabIndex = 37;
            this.Presentlabel.Text = "Present(1)";
            // 
            // comboBoxPresent
            // 
            this.comboBoxPresent.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPresent.FormattingEnabled = true;
            this.comboBoxPresent.Items.AddRange(new object[] {
            "1",
            "0"});
            this.comboBoxPresent.Location = new System.Drawing.Point(131, 257);
            this.comboBoxPresent.Name = "comboBoxPresent";
            this.comboBoxPresent.Size = new System.Drawing.Size(235, 28);
            this.comboBoxPresent.TabIndex = 36;
            // 
            // textBoxCourseNo
            // 
            this.textBoxCourseNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCourseNo.Location = new System.Drawing.Point(131, 291);
            this.textBoxCourseNo.Name = "textBoxCourseNo";
            this.textBoxCourseNo.Size = new System.Drawing.Size(235, 26);
            this.textBoxCourseNo.TabIndex = 35;
            // 
            // CourseNolabel
            // 
            this.CourseNolabel.AutoSize = true;
            this.CourseNolabel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseNolabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CourseNolabel.Location = new System.Drawing.Point(18, 297);
            this.CourseNolabel.Name = "CourseNolabel";
            this.CourseNolabel.Size = new System.Drawing.Size(65, 16);
            this.CourseNolabel.TabIndex = 34;
            this.CourseNolabel.Text = "Course No";
            // 
            // stuSemlabel
            // 
            this.stuSemlabel.AutoSize = true;
            this.stuSemlabel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stuSemlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stuSemlabel.Location = new System.Drawing.Point(18, 229);
            this.stuSemlabel.Name = "stuSemlabel";
            this.stuSemlabel.Size = new System.Drawing.Size(104, 16);
            this.stuSemlabel.TabIndex = 25;
            this.stuSemlabel.Text = "Student Semester";
            // 
            // comboBoxSemester
            // 
            this.comboBoxSemester.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSemester.FormattingEnabled = true;
            this.comboBoxSemester.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBoxSemester.Location = new System.Drawing.Point(131, 223);
            this.comboBoxSemester.Name = "comboBoxSemester";
            this.comboBoxSemester.Size = new System.Drawing.Size(235, 28);
            this.comboBoxSemester.TabIndex = 24;
            // 
            // stuYearlabel
            // 
            this.stuYearlabel.AutoSize = true;
            this.stuYearlabel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stuYearlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stuYearlabel.Location = new System.Drawing.Point(18, 195);
            this.stuYearlabel.Name = "stuYearlabel";
            this.stuYearlabel.Size = new System.Drawing.Size(77, 16);
            this.stuYearlabel.TabIndex = 23;
            this.stuYearlabel.Text = "Student Year";
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxYear.Location = new System.Drawing.Point(131, 189);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(235, 28);
            this.comboBoxYear.TabIndex = 22;
            // 
            // UpdateDataBtn
            // 
            this.UpdateDataBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(178)))), ((int)(((byte)(243)))));
            this.UpdateDataBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(178)))), ((int)(((byte)(243)))));
            this.UpdateDataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateDataBtn.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateDataBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateDataBtn.Location = new System.Drawing.Point(131, 412);
            this.UpdateDataBtn.Name = "UpdateDataBtn";
            this.UpdateDataBtn.Size = new System.Drawing.Size(235, 35);
            this.UpdateDataBtn.TabIndex = 21;
            this.UpdateDataBtn.Text = "Update Data";
            this.UpdateDataBtn.UseVisualStyleBackColor = false;
            this.UpdateDataBtn.Click += new System.EventHandler(this.UpdateDataBtn_Click_1);
            // 
            // DeptLabel
            // 
            this.DeptLabel.AutoSize = true;
            this.DeptLabel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DeptLabel.Location = new System.Drawing.Point(18, 161);
            this.DeptLabel.Name = "DeptLabel";
            this.DeptLabel.Size = new System.Drawing.Size(70, 16);
            this.DeptLabel.TabIndex = 19;
            this.DeptLabel.Text = "Department";
            // 
            // comboBoxDept
            // 
            this.comboBoxDept.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDept.FormattingEnabled = true;
            this.comboBoxDept.Items.AddRange(new object[] {
            "CSE",
            "EEE",
            "CE",
            "BBA",
            "Arch",
            "ME",
            "IPE",
            "TE"});
            this.comboBoxDept.Location = new System.Drawing.Point(131, 155);
            this.comboBoxDept.Name = "comboBoxDept";
            this.comboBoxDept.Size = new System.Drawing.Size(235, 28);
            this.comboBoxDept.TabIndex = 18;
            // 
            // SaveData
            // 
            this.SaveData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(178)))), ((int)(((byte)(243)))));
            this.SaveData.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(178)))), ((int)(((byte)(243)))));
            this.SaveData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveData.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveData.ForeColor = System.Drawing.Color.White;
            this.SaveData.Location = new System.Drawing.Point(131, 362);
            this.SaveData.Name = "SaveData";
            this.SaveData.Size = new System.Drawing.Size(235, 35);
            this.SaveData.TabIndex = 4;
            this.SaveData.Text = "Save Data";
            this.SaveData.UseVisualStyleBackColor = false;
            this.SaveData.Click += new System.EventHandler(this.SaveData_Click);
            // 
            // AttendanceLabel
            // 
            this.AttendanceLabel.AutoSize = true;
            this.AttendanceLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AttendanceLabel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendanceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.AttendanceLabel.Location = new System.Drawing.Point(126, 24);
            this.AttendanceLabel.Name = "AttendanceLabel";
            this.AttendanceLabel.Size = new System.Drawing.Size(194, 28);
            this.AttendanceLabel.TabIndex = 0;
            this.AttendanceLabel.Text = "Today\'s Attendance";
            // 
            // textBoxStudentId
            // 
            this.textBoxStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStudentId.Location = new System.Drawing.Point(131, 123);
            this.textBoxStudentId.Name = "textBoxStudentId";
            this.textBoxStudentId.Size = new System.Drawing.Size(235, 26);
            this.textBoxStudentId.TabIndex = 2;
            // 
            // StudentIdlabel
            // 
            this.StudentIdlabel.AutoSize = true;
            this.StudentIdlabel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentIdlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StudentIdlabel.Location = new System.Drawing.Point(18, 129);
            this.StudentIdlabel.Name = "StudentIdlabel";
            this.StudentIdlabel.Size = new System.Drawing.Size(66, 16);
            this.StudentIdlabel.TabIndex = 0;
            this.StudentIdlabel.Text = "Student ID";
            // 
            // dataGridViewMyAttendance
            // 
            this.dataGridViewMyAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMyAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMyAttendance.Location = new System.Drawing.Point(403, 103);
            this.dataGridViewMyAttendance.Name = "dataGridViewMyAttendance";
            this.dataGridViewMyAttendance.Size = new System.Drawing.Size(585, 459);
            this.dataGridViewMyAttendance.TabIndex = 6;
            // 
            // refreshBtn
            // 
            this.refreshBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(178)))), ((int)(((byte)(243)))));
            this.refreshBtn.Location = new System.Drawing.Point(403, 69);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(59, 28);
            this.refreshBtn.TabIndex = 7;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // MyAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.dataGridViewMyAttendance);
            this.Controls.Add(this.MidPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.TopBorderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.MyAttendance_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.MidPanel.ResumeLayout(false);
            this.MidPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMyAttendance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBorderPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label LogoAssintant;
        private System.Windows.Forms.Label LogoTA;
        private System.Windows.Forms.Panel MidPanel;
        private System.Windows.Forms.Label AttendanceLabel;
        private System.Windows.Forms.TextBox textBoxStudentId;
        private System.Windows.Forms.Label StudentIdlabel;
        public ButtonZ CloseButton;
        public MinMaxButton MaxButton;
        public ButtonZ MinButton;
        private System.Windows.Forms.Button SaveData;
        public System.Windows.Forms.ComboBox comboBoxDept;
        private System.Windows.Forms.DataGridView dataGridViewMyAttendance;
        private System.Windows.Forms.Label DeptLabel;
        private System.Windows.Forms.Button UpdateDataBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Label stuYearlabel;
        public System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.Label stuSemlabel;
        public System.Windows.Forms.ComboBox comboBoxSemester;
        private System.Windows.Forms.TextBox textBoxCourseNo;
        private System.Windows.Forms.Label CourseNolabel;
        private System.Windows.Forms.Label Presentlabel;
        public System.Windows.Forms.ComboBox comboBoxPresent;
    }
}

