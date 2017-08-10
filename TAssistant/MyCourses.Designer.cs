namespace TAssistant
{
    partial class MyCourses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyCourses));
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
            this.DelCourseBtn = new System.Windows.Forms.Button();
            this.DeptLabel = new System.Windows.Forms.Label();
            this.comboBoxDept = new System.Windows.Forms.ComboBox();
            this.textBoxYearSem = new System.Windows.Forms.TextBox();
            this.YearSemLabel = new System.Windows.Forms.Label();
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.CousreNamelabel = new System.Windows.Forms.Label();
            this.AddCoursebtn = new System.Windows.Forms.Button();
            this.NewScheduleLabel = new System.Windows.Forms.Label();
            this.textBoxCourseNo = new System.Windows.Forms.TextBox();
            this.CourseNolabel = new System.Windows.Forms.Label();
            this.dataGridViewMyCourses = new System.Windows.Forms.DataGridView();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.TopPanel.SuspendLayout();
            this.MidPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMyCourses)).BeginInit();
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
            this.MidPanel.Controls.Add(this.DelCourseBtn);
            this.MidPanel.Controls.Add(this.DeptLabel);
            this.MidPanel.Controls.Add(this.comboBoxDept);
            this.MidPanel.Controls.Add(this.textBoxYearSem);
            this.MidPanel.Controls.Add(this.YearSemLabel);
            this.MidPanel.Controls.Add(this.textBoxCourseName);
            this.MidPanel.Controls.Add(this.CousreNamelabel);
            this.MidPanel.Controls.Add(this.AddCoursebtn);
            this.MidPanel.Controls.Add(this.NewScheduleLabel);
            this.MidPanel.Controls.Add(this.textBoxCourseNo);
            this.MidPanel.Controls.Add(this.CourseNolabel);
            this.MidPanel.ForeColor = System.Drawing.Color.White;
            this.MidPanel.Location = new System.Drawing.Point(4, 55);
            this.MidPanel.Name = "MidPanel";
            this.MidPanel.Size = new System.Drawing.Size(393, 541);
            this.MidPanel.TabIndex = 5;
            // 
            // DelCourseBtn
            // 
            this.DelCourseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(178)))), ((int)(((byte)(243)))));
            this.DelCourseBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(178)))), ((int)(((byte)(243)))));
            this.DelCourseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelCourseBtn.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelCourseBtn.ForeColor = System.Drawing.Color.White;
            this.DelCourseBtn.Location = new System.Drawing.Point(111, 337);
            this.DelCourseBtn.Name = "DelCourseBtn";
            this.DelCourseBtn.Size = new System.Drawing.Size(235, 35);
            this.DelCourseBtn.TabIndex = 21;
            this.DelCourseBtn.Text = "Delete Course";
            this.DelCourseBtn.UseVisualStyleBackColor = false;
            this.DelCourseBtn.Click += new System.EventHandler(this.DelCourseBtn_Click);
            // 
            // DeptLabel
            // 
            this.DeptLabel.AutoSize = true;
            this.DeptLabel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DeptLabel.Location = new System.Drawing.Point(18, 183);
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
            "Arch",
            "ME",
            "IPE",
            "TE"});
            this.comboBoxDept.Location = new System.Drawing.Point(111, 177);
            this.comboBoxDept.Name = "comboBoxDept";
            this.comboBoxDept.Size = new System.Drawing.Size(235, 28);
            this.comboBoxDept.TabIndex = 18;
            // 
            // textBoxYearSem
            // 
            this.textBoxYearSem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxYearSem.Location = new System.Drawing.Point(111, 211);
            this.textBoxYearSem.Name = "textBoxYearSem";
            this.textBoxYearSem.Size = new System.Drawing.Size(235, 26);
            this.textBoxYearSem.TabIndex = 11;
            // 
            // YearSemLabel
            // 
            this.YearSemLabel.AutoSize = true;
            this.YearSemLabel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearSemLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.YearSemLabel.Location = new System.Drawing.Point(18, 217);
            this.YearSemLabel.Name = "YearSemLabel";
            this.YearSemLabel.Size = new System.Drawing.Size(86, 16);
            this.YearSemLabel.TabIndex = 10;
            this.YearSemLabel.Text = "Year-Semester";
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCourseName.Location = new System.Drawing.Point(111, 145);
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.Size = new System.Drawing.Size(235, 26);
            this.textBoxCourseName.TabIndex = 7;
            // 
            // CousreNamelabel
            // 
            this.CousreNamelabel.AutoSize = true;
            this.CousreNamelabel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CousreNamelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CousreNamelabel.Location = new System.Drawing.Point(18, 151);
            this.CousreNamelabel.Name = "CousreNamelabel";
            this.CousreNamelabel.Size = new System.Drawing.Size(80, 16);
            this.CousreNamelabel.TabIndex = 6;
            this.CousreNamelabel.Text = "Course Name";
            // 
            // AddCoursebtn
            // 
            this.AddCoursebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(178)))), ((int)(((byte)(243)))));
            this.AddCoursebtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(178)))), ((int)(((byte)(243)))));
            this.AddCoursebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCoursebtn.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCoursebtn.ForeColor = System.Drawing.Color.White;
            this.AddCoursebtn.Location = new System.Drawing.Point(111, 287);
            this.AddCoursebtn.Name = "AddCoursebtn";
            this.AddCoursebtn.Size = new System.Drawing.Size(235, 35);
            this.AddCoursebtn.TabIndex = 4;
            this.AddCoursebtn.Text = "Add Course";
            this.AddCoursebtn.UseVisualStyleBackColor = false;
            this.AddCoursebtn.Click += new System.EventHandler(this.AddCoursebtn_Click);
            // 
            // NewScheduleLabel
            // 
            this.NewScheduleLabel.AutoSize = true;
            this.NewScheduleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewScheduleLabel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewScheduleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.NewScheduleLabel.Location = new System.Drawing.Point(106, 27);
            this.NewScheduleLabel.Name = "NewScheduleLabel";
            this.NewScheduleLabel.Size = new System.Drawing.Size(124, 28);
            this.NewScheduleLabel.TabIndex = 0;
            this.NewScheduleLabel.Text = "New Course";
            // 
            // textBoxCourseNo
            // 
            this.textBoxCourseNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCourseNo.Location = new System.Drawing.Point(111, 113);
            this.textBoxCourseNo.Name = "textBoxCourseNo";
            this.textBoxCourseNo.Size = new System.Drawing.Size(235, 26);
            this.textBoxCourseNo.TabIndex = 2;
            // 
            // CourseNolabel
            // 
            this.CourseNolabel.AutoSize = true;
            this.CourseNolabel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseNolabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CourseNolabel.Location = new System.Drawing.Point(18, 119);
            this.CourseNolabel.Name = "CourseNolabel";
            this.CourseNolabel.Size = new System.Drawing.Size(65, 16);
            this.CourseNolabel.TabIndex = 0;
            this.CourseNolabel.Text = "Course No";
            // 
            // dataGridViewMyCourses
            // 
            this.dataGridViewMyCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMyCourses.Location = new System.Drawing.Point(424, 103);
            this.dataGridViewMyCourses.Name = "dataGridViewMyCourses";
            this.dataGridViewMyCourses.Size = new System.Drawing.Size(538, 463);
            this.dataGridViewMyCourses.TabIndex = 6;
            // 
            // refreshBtn
            // 
            this.refreshBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(178)))), ((int)(((byte)(243)))));
            this.refreshBtn.Location = new System.Drawing.Point(424, 69);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(59, 28);
            this.refreshBtn.TabIndex = 7;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // MyCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.dataGridViewMyCourses);
            this.Controls.Add(this.MidPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.TopBorderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.MyCourses_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.MidPanel.ResumeLayout(false);
            this.MidPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMyCourses)).EndInit();
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
        private System.Windows.Forms.Label NewScheduleLabel;
        private System.Windows.Forms.TextBox textBoxCourseNo;
        private System.Windows.Forms.Label CourseNolabel;
        public ButtonZ CloseButton;
        public MinMaxButton MaxButton;
        public ButtonZ MinButton;
        private System.Windows.Forms.Button AddCoursebtn;
        private System.Windows.Forms.TextBox textBoxCourseName;
        private System.Windows.Forms.Label CousreNamelabel;
        private System.Windows.Forms.TextBox textBoxYearSem;
        private System.Windows.Forms.Label YearSemLabel;
        public System.Windows.Forms.ComboBox comboBoxDept;
        private System.Windows.Forms.DataGridView dataGridViewMyCourses;
        private System.Windows.Forms.Label DeptLabel;
        private System.Windows.Forms.Button DelCourseBtn;
        private System.Windows.Forms.Button refreshBtn;
    }
}

