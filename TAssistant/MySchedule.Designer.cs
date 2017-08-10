namespace TAssistant
{
    partial class MySchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MySchedule));
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
            this.comboBoxDept = new System.Windows.Forms.ComboBox();
            this.updateScheduleBtn = new System.Windows.Forms.Button();
            this.Day = new System.Windows.Forms.Label();
            this.comboBoxDay = new System.Windows.Forms.ComboBox();
            this.DepartmentLabel = new System.Windows.Forms.Label();
            this.textBoxSection = new System.Windows.Forms.TextBox();
            this.SectionLabel = new System.Windows.Forms.Label();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.ClassTimelabel = new System.Windows.Forms.Label();
            this.textBoxRoomNo = new System.Windows.Forms.TextBox();
            this.RoomNolabel = new System.Windows.Forms.Label();
            this.AddSchedulebtn = new System.Windows.Forms.Button();
            this.NewScheduleLabel = new System.Windows.Forms.Label();
            this.textBoxCourseNo = new System.Windows.Forms.TextBox();
            this.CourseNolabel = new System.Windows.Forms.Label();
            this.dataGridViewMySchedule = new System.Windows.Forms.DataGridView();
            this.buttonTodayScd = new System.Windows.Forms.Button();
            this.buttonAllScd = new System.Windows.Forms.Button();
            this.TopPanel.SuspendLayout();
            this.MidPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMySchedule)).BeginInit();
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
            this.MidPanel.Controls.Add(this.comboBoxDept);
            this.MidPanel.Controls.Add(this.updateScheduleBtn);
            this.MidPanel.Controls.Add(this.Day);
            this.MidPanel.Controls.Add(this.comboBoxDay);
            this.MidPanel.Controls.Add(this.DepartmentLabel);
            this.MidPanel.Controls.Add(this.textBoxSection);
            this.MidPanel.Controls.Add(this.SectionLabel);
            this.MidPanel.Controls.Add(this.textBoxTime);
            this.MidPanel.Controls.Add(this.ClassTimelabel);
            this.MidPanel.Controls.Add(this.textBoxRoomNo);
            this.MidPanel.Controls.Add(this.RoomNolabel);
            this.MidPanel.Controls.Add(this.AddSchedulebtn);
            this.MidPanel.Controls.Add(this.NewScheduleLabel);
            this.MidPanel.Controls.Add(this.textBoxCourseNo);
            this.MidPanel.Controls.Add(this.CourseNolabel);
            this.MidPanel.ForeColor = System.Drawing.Color.White;
            this.MidPanel.Location = new System.Drawing.Point(4, 55);
            this.MidPanel.Name = "MidPanel";
            this.MidPanel.Size = new System.Drawing.Size(364, 541);
            this.MidPanel.TabIndex = 5;
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
            this.comboBoxDept.Location = new System.Drawing.Point(101, 144);
            this.comboBoxDept.Name = "comboBoxDept";
            this.comboBoxDept.Size = new System.Drawing.Size(235, 28);
            this.comboBoxDept.TabIndex = 21;
            // 
            // updateScheduleBtn
            // 
            this.updateScheduleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(178)))), ((int)(((byte)(243)))));
            this.updateScheduleBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(178)))), ((int)(((byte)(243)))));
            this.updateScheduleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateScheduleBtn.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateScheduleBtn.ForeColor = System.Drawing.Color.White;
            this.updateScheduleBtn.Location = new System.Drawing.Point(101, 374);
            this.updateScheduleBtn.Name = "updateScheduleBtn";
            this.updateScheduleBtn.Size = new System.Drawing.Size(235, 35);
            this.updateScheduleBtn.TabIndex = 20;
            this.updateScheduleBtn.Text = "Update schedule";
            this.updateScheduleBtn.UseVisualStyleBackColor = false;
            this.updateScheduleBtn.Click += new System.EventHandler(this.updateScheduleBtn_Click);
            // 
            // Day
            // 
            this.Day.AutoSize = true;
            this.Day.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Day.Location = new System.Drawing.Point(39, 253);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(28, 16);
            this.Day.TabIndex = 19;
            this.Day.Text = "Day";
            // 
            // comboBoxDay
            // 
            this.comboBoxDay.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDay.FormattingEnabled = true;
            this.comboBoxDay.Items.AddRange(new object[] {
            "Saturday",
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"});
            this.comboBoxDay.Location = new System.Drawing.Point(101, 241);
            this.comboBoxDay.Name = "comboBoxDay";
            this.comboBoxDay.Size = new System.Drawing.Size(235, 28);
            this.comboBoxDay.TabIndex = 18;
            // 
            // DepartmentLabel
            // 
            this.DepartmentLabel.AutoSize = true;
            this.DepartmentLabel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DepartmentLabel.Location = new System.Drawing.Point(29, 151);
            this.DepartmentLabel.Name = "DepartmentLabel";
            this.DepartmentLabel.Size = new System.Drawing.Size(70, 16);
            this.DepartmentLabel.TabIndex = 12;
            this.DepartmentLabel.Text = "Department";
            // 
            // textBoxSection
            // 
            this.textBoxSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSection.Location = new System.Drawing.Point(101, 275);
            this.textBoxSection.Name = "textBoxSection";
            this.textBoxSection.Size = new System.Drawing.Size(235, 26);
            this.textBoxSection.TabIndex = 11;
            // 
            // SectionLabel
            // 
            this.SectionLabel.AutoSize = true;
            this.SectionLabel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SectionLabel.Location = new System.Drawing.Point(29, 281);
            this.SectionLabel.Name = "SectionLabel";
            this.SectionLabel.Size = new System.Drawing.Size(49, 16);
            this.SectionLabel.TabIndex = 10;
            this.SectionLabel.Text = "Section";
            // 
            // textBoxTime
            // 
            this.textBoxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTime.Location = new System.Drawing.Point(101, 209);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(235, 26);
            this.textBoxTime.TabIndex = 9;
            // 
            // ClassTimelabel
            // 
            this.ClassTimelabel.AutoSize = true;
            this.ClassTimelabel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassTimelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClassTimelabel.Location = new System.Drawing.Point(29, 215);
            this.ClassTimelabel.Name = "ClassTimelabel";
            this.ClassTimelabel.Size = new System.Drawing.Size(66, 16);
            this.ClassTimelabel.TabIndex = 8;
            this.ClassTimelabel.Text = "Class Time";
            // 
            // textBoxRoomNo
            // 
            this.textBoxRoomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRoomNo.Location = new System.Drawing.Point(101, 177);
            this.textBoxRoomNo.Name = "textBoxRoomNo";
            this.textBoxRoomNo.Size = new System.Drawing.Size(235, 26);
            this.textBoxRoomNo.TabIndex = 7;
            // 
            // RoomNolabel
            // 
            this.RoomNolabel.AutoSize = true;
            this.RoomNolabel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNolabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RoomNolabel.Location = new System.Drawing.Point(29, 183);
            this.RoomNolabel.Name = "RoomNolabel";
            this.RoomNolabel.Size = new System.Drawing.Size(59, 16);
            this.RoomNolabel.TabIndex = 6;
            this.RoomNolabel.Text = "Room No";
            // 
            // AddSchedulebtn
            // 
            this.AddSchedulebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(178)))), ((int)(((byte)(243)))));
            this.AddSchedulebtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(178)))), ((int)(((byte)(243)))));
            this.AddSchedulebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSchedulebtn.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSchedulebtn.ForeColor = System.Drawing.Color.White;
            this.AddSchedulebtn.Location = new System.Drawing.Point(101, 320);
            this.AddSchedulebtn.Name = "AddSchedulebtn";
            this.AddSchedulebtn.Size = new System.Drawing.Size(235, 35);
            this.AddSchedulebtn.TabIndex = 4;
            this.AddSchedulebtn.Text = "Add to schedule";
            this.AddSchedulebtn.UseVisualStyleBackColor = false;
            this.AddSchedulebtn.Click += new System.EventHandler(this.AddSchedulebtn_Click);
            // 
            // NewScheduleLabel
            // 
            this.NewScheduleLabel.AutoSize = true;
            this.NewScheduleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewScheduleLabel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewScheduleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.NewScheduleLabel.Location = new System.Drawing.Point(96, 13);
            this.NewScheduleLabel.Name = "NewScheduleLabel";
            this.NewScheduleLabel.Size = new System.Drawing.Size(144, 28);
            this.NewScheduleLabel.TabIndex = 0;
            this.NewScheduleLabel.Text = "New schedule";
            // 
            // textBoxCourseNo
            // 
            this.textBoxCourseNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCourseNo.Location = new System.Drawing.Point(101, 113);
            this.textBoxCourseNo.Name = "textBoxCourseNo";
            this.textBoxCourseNo.Size = new System.Drawing.Size(235, 26);
            this.textBoxCourseNo.TabIndex = 2;
            // 
            // CourseNolabel
            // 
            this.CourseNolabel.AutoSize = true;
            this.CourseNolabel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseNolabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CourseNolabel.Location = new System.Drawing.Point(29, 119);
            this.CourseNolabel.Name = "CourseNolabel";
            this.CourseNolabel.Size = new System.Drawing.Size(65, 16);
            this.CourseNolabel.TabIndex = 0;
            this.CourseNolabel.Text = "Course No";
            // 
            // dataGridViewMySchedule
            // 
            this.dataGridViewMySchedule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMySchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMySchedule.Location = new System.Drawing.Point(374, 159);
            this.dataGridViewMySchedule.Name = "dataGridViewMySchedule";
            this.dataGridViewMySchedule.Size = new System.Drawing.Size(588, 432);
            this.dataGridViewMySchedule.TabIndex = 6;
            // 
            // buttonTodayScd
            // 
            this.buttonTodayScd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(178)))), ((int)(((byte)(243)))));
            this.buttonTodayScd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTodayScd.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTodayScd.ForeColor = System.Drawing.Color.White;
            this.buttonTodayScd.Location = new System.Drawing.Point(374, 119);
            this.buttonTodayScd.Name = "buttonTodayScd";
            this.buttonTodayScd.Size = new System.Drawing.Size(235, 35);
            this.buttonTodayScd.TabIndex = 7;
            this.buttonTodayScd.Text = "Today";
            this.buttonTodayScd.UseVisualStyleBackColor = false;
            this.buttonTodayScd.Click += new System.EventHandler(this.buttonTodayScd_Click);
            // 
            // buttonAllScd
            // 
            this.buttonAllScd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAllScd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(178)))), ((int)(((byte)(243)))));
            this.buttonAllScd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAllScd.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllScd.ForeColor = System.Drawing.Color.White;
            this.buttonAllScd.Location = new System.Drawing.Point(727, 119);
            this.buttonAllScd.Name = "buttonAllScd";
            this.buttonAllScd.Size = new System.Drawing.Size(235, 35);
            this.buttonAllScd.TabIndex = 8;
            this.buttonAllScd.Text = "All";
            this.buttonAllScd.UseVisualStyleBackColor = false;
            this.buttonAllScd.Click += new System.EventHandler(this.buttonAllScd_Click);
            // 
            // MySchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.buttonAllScd);
            this.Controls.Add(this.buttonTodayScd);
            this.Controls.Add(this.dataGridViewMySchedule);
            this.Controls.Add(this.MidPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.TopBorderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MySchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.MySchedule_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.MidPanel.ResumeLayout(false);
            this.MidPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMySchedule)).EndInit();
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
        private System.Windows.Forms.Button AddSchedulebtn;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Label ClassTimelabel;
        private System.Windows.Forms.TextBox textBoxRoomNo;
        private System.Windows.Forms.Label RoomNolabel;
        private System.Windows.Forms.TextBox textBoxSection;
        private System.Windows.Forms.Label SectionLabel;
        private System.Windows.Forms.Label DepartmentLabel;
        public System.Windows.Forms.ComboBox comboBoxDay;
        private System.Windows.Forms.DataGridView dataGridViewMySchedule;
        private System.Windows.Forms.Label Day;
        private System.Windows.Forms.Button buttonTodayScd;
        private System.Windows.Forms.Button buttonAllScd;
        private System.Windows.Forms.Button updateScheduleBtn;
        private System.Windows.Forms.ComboBox comboBoxDept;
    }
}

