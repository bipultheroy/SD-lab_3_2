namespace TAssistant
{
    partial class MyNotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyNotes));
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
            this.dataGridViewMyNotes = new System.Windows.Forms.DataGridView();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.NoteSublabel = new System.Windows.Forms.Label();
            this.textBoxNoteSub = new System.Windows.Forms.TextBox();
            this.NewNoteLabel = new System.Windows.Forms.Label();
            this.SaveNotebtn = new System.Windows.Forms.Button();
            this.NoteLabel = new System.Windows.Forms.Label();
            this.textBoxMyNote = new System.Windows.Forms.TextBox();
            this.DelNoteBtn = new System.Windows.Forms.Button();
            this.MidPanel = new System.Windows.Forms.Panel();
            this.textBoxRemind = new System.Windows.Forms.TextBox();
            this.labelremind = new System.Windows.Forms.Label();
            this.ReadNotebutton = new System.Windows.Forms.Button();
            this.textBoxNoteId = new System.Windows.Forms.TextBox();
            this.labelNoteId = new System.Windows.Forms.Label();
            this.richTextBoxMynote = new System.Windows.Forms.RichTextBox();
            this.labelnoteSub = new System.Windows.Forms.Label();
            this.MynotesubLabel = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMyNotes)).BeginInit();
            this.MidPanel.SuspendLayout();
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
            // dataGridViewMyNotes
            // 
            this.dataGridViewMyNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMyNotes.Location = new System.Drawing.Point(424, 312);
            this.dataGridViewMyNotes.Name = "dataGridViewMyNotes";
            this.dataGridViewMyNotes.Size = new System.Drawing.Size(552, 254);
            this.dataGridViewMyNotes.TabIndex = 6;
            // 
            // refreshBtn
            // 
            this.refreshBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(178)))), ((int)(((byte)(243)))));
            this.refreshBtn.Location = new System.Drawing.Point(424, 278);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(59, 28);
            this.refreshBtn.TabIndex = 7;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // NoteSublabel
            // 
            this.NoteSublabel.AutoSize = true;
            this.NoteSublabel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteSublabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NoteSublabel.Location = new System.Drawing.Point(13, 79);
            this.NoteSublabel.Name = "NoteSublabel";
            this.NoteSublabel.Size = new System.Drawing.Size(78, 16);
            this.NoteSublabel.TabIndex = 0;
            this.NoteSublabel.Text = "Note Subject";
            // 
            // textBoxNoteSub
            // 
            this.textBoxNoteSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNoteSub.Location = new System.Drawing.Point(126, 73);
            this.textBoxNoteSub.Name = "textBoxNoteSub";
            this.textBoxNoteSub.Size = new System.Drawing.Size(235, 26);
            this.textBoxNoteSub.TabIndex = 2;
            // 
            // NewNoteLabel
            // 
            this.NewNoteLabel.AutoSize = true;
            this.NewNoteLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewNoteLabel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewNoteLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.NewNoteLabel.Location = new System.Drawing.Point(121, 27);
            this.NewNoteLabel.Name = "NewNoteLabel";
            this.NewNoteLabel.Size = new System.Drawing.Size(103, 28);
            this.NewNoteLabel.TabIndex = 0;
            this.NewNoteLabel.Text = "New Note";
            // 
            // SaveNotebtn
            // 
            this.SaveNotebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(178)))), ((int)(((byte)(243)))));
            this.SaveNotebtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(178)))), ((int)(((byte)(243)))));
            this.SaveNotebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveNotebtn.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveNotebtn.ForeColor = System.Drawing.Color.White;
            this.SaveNotebtn.Location = new System.Drawing.Point(126, 277);
            this.SaveNotebtn.Name = "SaveNotebtn";
            this.SaveNotebtn.Size = new System.Drawing.Size(235, 35);
            this.SaveNotebtn.TabIndex = 4;
            this.SaveNotebtn.Text = "Save Note";
            this.SaveNotebtn.UseVisualStyleBackColor = false;
            this.SaveNotebtn.Click += new System.EventHandler(this.SaveNotebtn_Click);
            // 
            // NoteLabel
            // 
            this.NoteLabel.AutoSize = true;
            this.NoteLabel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NoteLabel.Location = new System.Drawing.Point(13, 151);
            this.NoteLabel.Name = "NoteLabel";
            this.NoteLabel.Size = new System.Drawing.Size(34, 16);
            this.NoteLabel.TabIndex = 6;
            this.NoteLabel.Text = "Note";
            // 
            // textBoxMyNote
            // 
            this.textBoxMyNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMyNote.Location = new System.Drawing.Point(126, 145);
            this.textBoxMyNote.Multiline = true;
            this.textBoxMyNote.Name = "textBoxMyNote";
            this.textBoxMyNote.Size = new System.Drawing.Size(235, 100);
            this.textBoxMyNote.TabIndex = 7;
            // 
            // DelNoteBtn
            // 
            this.DelNoteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(178)))), ((int)(((byte)(243)))));
            this.DelNoteBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(178)))), ((int)(((byte)(243)))));
            this.DelNoteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelNoteBtn.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelNoteBtn.ForeColor = System.Drawing.Color.White;
            this.DelNoteBtn.Location = new System.Drawing.Point(249, 441);
            this.DelNoteBtn.Name = "DelNoteBtn";
            this.DelNoteBtn.Size = new System.Drawing.Size(112, 35);
            this.DelNoteBtn.TabIndex = 21;
            this.DelNoteBtn.Text = "Delete Note";
            this.DelNoteBtn.UseVisualStyleBackColor = false;
            this.DelNoteBtn.Click += new System.EventHandler(this.DelNoteBtn_Click_1);
            // 
            // MidPanel
            // 
            this.MidPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MidPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.MidPanel.Controls.Add(this.textBoxRemind);
            this.MidPanel.Controls.Add(this.labelremind);
            this.MidPanel.Controls.Add(this.ReadNotebutton);
            this.MidPanel.Controls.Add(this.textBoxNoteId);
            this.MidPanel.Controls.Add(this.labelNoteId);
            this.MidPanel.Controls.Add(this.DelNoteBtn);
            this.MidPanel.Controls.Add(this.textBoxMyNote);
            this.MidPanel.Controls.Add(this.NoteLabel);
            this.MidPanel.Controls.Add(this.SaveNotebtn);
            this.MidPanel.Controls.Add(this.NewNoteLabel);
            this.MidPanel.Controls.Add(this.textBoxNoteSub);
            this.MidPanel.Controls.Add(this.NoteSublabel);
            this.MidPanel.ForeColor = System.Drawing.Color.White;
            this.MidPanel.Location = new System.Drawing.Point(4, 55);
            this.MidPanel.Name = "MidPanel";
            this.MidPanel.Size = new System.Drawing.Size(393, 541);
            this.MidPanel.TabIndex = 5;
            // 
            // textBoxRemind
            // 
            this.textBoxRemind.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRemind.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxRemind.Location = new System.Drawing.Point(126, 105);
            this.textBoxRemind.Name = "textBoxRemind";
            this.textBoxRemind.Size = new System.Drawing.Size(235, 29);
            this.textBoxRemind.TabIndex = 26;
            // 
            // labelremind
            // 
            this.labelremind.AutoSize = true;
            this.labelremind.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelremind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelremind.Location = new System.Drawing.Point(13, 111);
            this.labelremind.Name = "labelremind";
            this.labelremind.Size = new System.Drawing.Size(102, 16);
            this.labelremind.TabIndex = 25;
            this.labelremind.Text = "Reminder(Y-M-D)";
            // 
            // ReadNotebutton
            // 
            this.ReadNotebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(178)))), ((int)(((byte)(243)))));
            this.ReadNotebutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(178)))), ((int)(((byte)(243)))));
            this.ReadNotebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReadNotebutton.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadNotebutton.ForeColor = System.Drawing.Color.White;
            this.ReadNotebutton.Location = new System.Drawing.Point(126, 441);
            this.ReadNotebutton.Name = "ReadNotebutton";
            this.ReadNotebutton.Size = new System.Drawing.Size(112, 35);
            this.ReadNotebutton.TabIndex = 24;
            this.ReadNotebutton.Text = "Read Note";
            this.ReadNotebutton.UseVisualStyleBackColor = false;
            this.ReadNotebutton.Click += new System.EventHandler(this.ReadNotebutton_Click);
            // 
            // textBoxNoteId
            // 
            this.textBoxNoteId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNoteId.Location = new System.Drawing.Point(126, 387);
            this.textBoxNoteId.Name = "textBoxNoteId";
            this.textBoxNoteId.Size = new System.Drawing.Size(235, 26);
            this.textBoxNoteId.TabIndex = 23;
            // 
            // labelNoteId
            // 
            this.labelNoteId.AutoSize = true;
            this.labelNoteId.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoteId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelNoteId.Location = new System.Drawing.Point(18, 393);
            this.labelNoteId.Name = "labelNoteId";
            this.labelNoteId.Size = new System.Drawing.Size(48, 16);
            this.labelNoteId.TabIndex = 22;
            this.labelNoteId.Text = "Note Id";
            // 
            // richTextBoxMynote
            // 
            this.richTextBoxMynote.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBoxMynote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxMynote.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxMynote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBoxMynote.Location = new System.Drawing.Point(424, 128);
            this.richTextBoxMynote.Name = "richTextBoxMynote";
            this.richTextBoxMynote.Size = new System.Drawing.Size(552, 119);
            this.richTextBoxMynote.TabIndex = 8;
            this.richTextBoxMynote.Text = "";
            // 
            // labelnoteSub
            // 
            this.labelnoteSub.AutoSize = true;
            this.labelnoteSub.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnoteSub.Location = new System.Drawing.Point(421, 90);
            this.labelnoteSub.Name = "labelnoteSub";
            this.labelnoteSub.Size = new System.Drawing.Size(67, 18);
            this.labelnoteSub.TabIndex = 9;
            this.labelnoteSub.Text = "Subject :";
            // 
            // MynotesubLabel
            // 
            this.MynotesubLabel.AutoSize = true;
            this.MynotesubLabel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MynotesubLabel.Location = new System.Drawing.Point(494, 90);
            this.MynotesubLabel.Name = "MynotesubLabel";
            this.MynotesubLabel.Size = new System.Drawing.Size(70, 18);
            this.MynotesubLabel.TabIndex = 10;
            this.MynotesubLabel.Text = "No subject";
            // 
            // MyNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.MynotesubLabel);
            this.Controls.Add(this.labelnoteSub);
            this.Controls.Add(this.richTextBoxMynote);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.dataGridViewMyNotes);
            this.Controls.Add(this.MidPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.TopBorderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyNotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.MyNotes_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMyNotes)).EndInit();
            this.MidPanel.ResumeLayout(false);
            this.MidPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopBorderPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label LogoAssintant;
        private System.Windows.Forms.Label LogoTA;
        public ButtonZ CloseButton;
        public MinMaxButton MaxButton;
        public ButtonZ MinButton;
        private System.Windows.Forms.DataGridView dataGridViewMyNotes;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Label NoteSublabel;
        private System.Windows.Forms.TextBox textBoxNoteSub;
        private System.Windows.Forms.Label NewNoteLabel;
        private System.Windows.Forms.Button SaveNotebtn;
        private System.Windows.Forms.Label NoteLabel;
        private System.Windows.Forms.TextBox textBoxMyNote;
        private System.Windows.Forms.Button DelNoteBtn;
        private System.Windows.Forms.Panel MidPanel;
        private System.Windows.Forms.TextBox textBoxNoteId;
        private System.Windows.Forms.Label labelNoteId;
        private System.Windows.Forms.Button ReadNotebutton;
        private System.Windows.Forms.RichTextBox richTextBoxMynote;
        private System.Windows.Forms.Label labelnoteSub;
        private System.Windows.Forms.Label MynotesubLabel;
        private System.Windows.Forms.TextBox textBoxRemind;
        private System.Windows.Forms.Label labelremind;
    }
}

