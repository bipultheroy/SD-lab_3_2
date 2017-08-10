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
    public partial class MySchedule : Form
    {
        public MySchedule()
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


        /*New schedule and update*/

      
      

        private void MySchedule_Load(object sender, EventArgs e)
        {
            int adid = MyVar.uid;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-LDSCKMJ;Initial Catalog=TAssistant;User ID=sa;Password=1234";
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM myschedule WHERE adminId = '" + adid + "'";
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            dataGridViewMySchedule.DataSource = data;
        }

        private void buttonAllScd_Click(object sender, EventArgs e)
        {
            int adid = MyVar.uid;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-LDSCKMJ;Initial Catalog=TAssistant;User ID=sa;Password=1234";
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM myschedule WHERE adminId = '" + adid + "'";
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            dataGridViewMySchedule.DataSource = data;
        }

        private void buttonTodayScd_Click(object sender, EventArgs e)
        {

            string today = DateTime.Now.DayOfWeek.ToString();
            int adid = MyVar.uid;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-LDSCKMJ;Initial Catalog=TAssistant;User ID=sa;Password=1234";
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM myschedule WHERE classDay = '"+today+ "'AND adminId = '" + adid+ "'";
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            dataGridViewMySchedule.DataSource = data;
        }

        private void AddSchedulebtn_Click(object sender, EventArgs e)
        {
           
            string courseNo = textBoxCourseNo.Text;
            string dept = comboBoxDept.Text;
            string roomNo = textBoxRoomNo.Text;
            string classTime = textBoxTime.Text;
            string day = comboBoxDay.Text;
            string section = textBoxSection.Text;
            if(courseNo == "" || dept == "" || roomNo == "" || classTime == "" || day == "" || section == "")
            {
                MessageBox.Show("You cannot put blank values.Please fill all fields.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                AdminDAO newSchedule = new AdminDAO();
                int adminId = MyVar.uid;
                newSchedule.AddSchedule(new AdminDTO(courseNo, dept, roomNo, classTime, day, section, adminId));

                textBoxCourseNo.Text = "";
                comboBoxDept.Text = "";
                textBoxRoomNo.Text = "";
                textBoxTime.Text = "";
                comboBoxDay.Text = "";
                textBoxSection.Text = "";
            }
           
        }

        private void updateScheduleBtn_Click(object sender, EventArgs e)
        {
            string courseNo = textBoxCourseNo.Text;
            string dept = comboBoxDept.Text;
            string roomNo = textBoxRoomNo.Text;
            string classTime = textBoxTime.Text;
            string day = comboBoxDay.Text;
            string section = textBoxSection.Text;
            if (courseNo == "" || dept == "" || roomNo == "" || classTime == "" || day == "" || section == "")
            {
                MessageBox.Show("You cannot put blank values.Please fill all fields.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                AdminDAO newSchedule = new AdminDAO();
                int adminId = MyVar.uid;//static value from my var class
                newSchedule.UpdateSchedule(new AdminDTO(courseNo, dept, roomNo, classTime, day, section, adminId));

                textBoxCourseNo.Text = "";
                comboBoxDept.Text = "";
                textBoxRoomNo.Text = "";
                textBoxTime.Text = "";
                comboBoxDay.Text = "";
                textBoxSection.Text = "";

            }
            
        }
    }
}