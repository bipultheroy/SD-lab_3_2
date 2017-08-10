using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAssistant
{
    public partial class MyExams : Form
    {
        public MyExams()
        {
            InitializeComponent();
        }


        bool isTopPanelDragged = false;
        bool isLeftPanelDragged = false;
        bool isRightPanelDragged = false;
        bool isBottomPanelDragged = false;
        bool isTopBorderPanelDragged = false;
        bool isWindowMaximized = false;
        Point offset;
        Size _normalWindowSize;
        Point _normalWindowLocation = Point.Empty;


        //**********************************************************************
        //top border panel
        private void TopBorderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isTopBorderPanelDragged = true;
            }
            else
            {
                isTopBorderPanelDragged = false;
            }
        }

        private void TopBorderPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Y < this.Location.Y)
            {
                if (isTopBorderPanelDragged)
                {
                    if (this.Height < 50)
                    {
                        this.Height = 50;
                        isTopBorderPanelDragged = false;
                    }
                    else
                    {
                        this.Location = new Point(this.Location.X, this.Location.Y + e.Y);
                        this.Height = this.Height - e.Y;
                    }
                }
            }
        }

        private void TopBorderPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isTopBorderPanelDragged = false;
        }




        //**********************************************************************
        //top panel
        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isTopPanelDragged = true;
                Point pointStartPosition = this.PointToScreen(new Point(e.X, e.Y));
                offset = new Point();
                offset.X = this.Location.X - pointStartPosition.X;
                offset.Y = this.Location.Y - pointStartPosition.Y;
            }
            else
            {
                isTopPanelDragged = false;
            }
            if (e.Clicks == 2)
            {
                isTopPanelDragged = false;
                _MaxButton_Click(sender, e);
            }
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isTopPanelDragged)
            {
                Point newPoint = TopPanel.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(offset);
                this.Location = newPoint;

                if (this.Location.X > 2 || this.Location.Y > 2)
                {
                    if (this.WindowState == FormWindowState.Maximized)
                    {
                        this.Location = _normalWindowLocation;
                        this.Size = _normalWindowSize;
                        //toolTip1.SetToolTip(_MaxButton, "Maximize");
                        //_MaxButton.CFormState = MinMaxButton.CustomFormState.Normal;
                        isWindowMaximized = false;
                    }
                }
            }
        }

        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isTopPanelDragged = false;
            if (this.Location.Y <= 5)
            {
                if (!isWindowMaximized)
                {
                    _normalWindowSize = this.Size;
                    _normalWindowLocation = this.Location;

                    Rectangle rect = Screen.PrimaryScreen.WorkingArea;
                    this.Location = new Point(0, 0);
                    this.Size = new System.Drawing.Size(rect.Width, rect.Height);
                    //toolTip1.SetToolTip(_MaxButton, "Restore Down");
                    //_MaxButton.CFormState = MinMaxButton.CustomFormState.Maximize;
                    isWindowMaximized = true;
                }
            }
        }



        //**********************************************************************
        //left panel
        private void LeftPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.Location.X <= 0 || e.X < 0)
            {
                isLeftPanelDragged = false;
                this.Location = new Point(10, this.Location.Y);
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    isLeftPanelDragged = true;
                }
                else
                {
                    isLeftPanelDragged = false;
                }
            }
        }

        private void LeftPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X < this.Location.X)
            {
                if (isLeftPanelDragged)
                {
                    if (this.Width < 100)
                    {
                        this.Width = 100;
                        isLeftPanelDragged = false;
                    }
                    else
                    {
                        this.Location = new Point(this.Location.X + e.X, this.Location.Y);
                        this.Width = this.Width - e.X;
                    }
                }
            }
        }

        private void LeftPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isLeftPanelDragged = false;
        }




        //**********************************************************************
        //right panel
        private void RightPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isRightPanelDragged = true;
            }
            else
            {
                isRightPanelDragged = false;
            }
        }

        private void RightPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isRightPanelDragged)
            {
                if (this.Width < 100)
                {
                    this.Width = 100;
                    isRightPanelDragged = false;
                }
                else
                {
                    this.Width = this.Width + e.X;
                }
            }
        }

        private void RightPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isRightPanelDragged = false;
        }




        //**********************************************************************
        //bottom panel
        private void BottomPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isBottomPanelDragged = true;
            }
            else
            {
                isBottomPanelDragged = false;
            }
        }

        private void BottomPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isBottomPanelDragged)
            {
                if (this.Height < 50)
                {
                    this.Height = 50;
                    isBottomPanelDragged = false;
                }
                else
                {
                    this.Height = this.Height + e.Y;
                }
            }
        }

        private void BottomPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isBottomPanelDragged = false;
        }




        //**********************************************************************
        //actions for close,min,max buttons
        private void _CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _MaxButton_Click(object sender, EventArgs e)
        {
            if (isWindowMaximized)
            {
                this.Location = _normalWindowLocation;
                this.Size = _normalWindowSize;
                // toolTip1.SetToolTip(_MaxButton, "Maximize");
                // _MaxButton.CFormState = MinMaxButton.CustomFormState.Normal;
                isWindowMaximized = false;
            }
            else
            {
                _normalWindowSize = this.Size;
                _normalWindowLocation = this.Location;

                Rectangle rect = Screen.PrimaryScreen.WorkingArea;
                this.Location = new Point(0, 0);
                this.Size = new System.Drawing.Size(rect.Width, rect.Height);
                //toolTip1.SetToolTip(_MaxButton, "Restore Down");
                //_MaxButton.CFormState = MinMaxButton.CustomFormState.Maximize;
                isWindowMaximized = true;
            }
        }

        private void _MinButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        /*New Exam and Update */



        private void refreshBtn_Click(object sender, EventArgs e)
        {
            int adid = MyVar.uid;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-LDSCKMJ;Initial Catalog=TAssistant;User ID=sa;Password=1234";
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM myexam WHERE adminId = '" + adid + "'";
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            dataGridViewMyExams.DataSource = data;
        }

        private void MyExams_Load(object sender, EventArgs e)
        {

            int adid = MyVar.uid;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-LDSCKMJ;Initial Catalog=TAssistant;User ID=sa;Password=1234";
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM myexam WHERE adminId = '" + adid + "'";
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            dataGridViewMyExams.DataSource = data;
        }

        private void SaveData_Click(object sender, EventArgs e)
        {
            string stuId = textBoxStudentId.Text;
            string dept = comboBoxDept.Text;
            string stuYear = comboBoxYear.Text;
            string stuSem = comboBoxSemester.Text;
            string qz1 = textBoxqz_1.Text;
            string qz2 = textBoxQz_2.Text;
            string qz3 = textBoxqz_3.Text;
            string qz4 = textBoxqz_4.Text;
            string finalxm = textBoxfinalmark.Text;
            string courseNo = textBoxCourseNo.Text;
            
            if (stuId =="" || dept == "" || stuYear == ""|| stuSem == ""||courseNo == "")
            {
                MessageBox.Show("You have to fill Student ID,Department,Student Year,Student Semester,Course No.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                AdminDAO savexmData = new AdminDAO();
                int adminId = MyVar.uid;
                savexmData.AddXmData(new MyInfoDTO(stuId, dept, stuYear, stuSem, qz1, qz2, qz3, qz4, finalxm, courseNo, adminId));


                textBoxStudentId.Text = "";
                comboBoxDept.Text = "";
                comboBoxYear.Text = "";
                comboBoxSemester.Text = "";
                textBoxqz_1.Text = "";
                textBoxQz_2.Text = "";
                textBoxqz_3.Text = "";
                textBoxqz_4.Text = "";
                textBoxfinalmark.Text = "";
                textBoxCourseNo.Text = "";
            }

        }

        private void UpdateDataBtn_Click_1(object sender, EventArgs e)
        {
            string stuId = textBoxStudentId.Text;
            string dept = comboBoxDept.Text;
            string stuYear = comboBoxYear.Text;
            string stuSem = comboBoxSemester.Text;
            string qz1 = textBoxqz_1.Text;
            string qz2 = textBoxQz_2.Text;
            string qz3 = textBoxqz_3.Text;
            string qz4 = textBoxqz_4.Text;
            string finalxm = textBoxfinalmark.Text;
            string courseNo = textBoxCourseNo.Text;

            if (stuId == "" || dept == "" || stuYear == "" || stuSem == "" || courseNo == "")
            {
                MessageBox.Show("You have to fill Student ID, Department, Student Year, Student Semester, Course No.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                AdminDAO updatexmdata = new AdminDAO();
                int adminId = MyVar.uid;//static value from my var class
                updatexmdata.UpdateXmData(new MyInfoDTO(stuId, dept, stuYear, stuSem, qz1, qz2, qz3, qz4, finalxm, courseNo, adminId));

                textBoxStudentId.Text = "";
                comboBoxDept.Text = "";
                comboBoxYear.Text = "";
                comboBoxSemester.Text = "";
                textBoxqz_1.Text = "";
                textBoxQz_2.Text = "";
                textBoxqz_3.Text = "";
                textBoxqz_4.Text = "";
                textBoxfinalmark.Text = "";
                textBoxCourseNo.Text = "";

            }

        }
    }
}