using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TAssistant
{
    class AdminDAO
    {

        private String conString = "Data Source=DESKTOP-LDSCKMJ;Initial Catalog = TAssistant; User ID = sa; Password=1234";
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlAdapter;
        private DataSet dataSet;
        string userName = "";
        string userContact = "";
        string userPass = "";
        string conPass = "";
        string email = "";
        string userNote = "";
        string userNoteSub = "";

        public AdminDAO()
        {
            sqlConnection = new SqlConnection(conString);
        }

        public DataSet GetAdmin()
        {
            sqlConnection.Open();
            string sqlQuery = "select * from admin";
            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);


            sqlAdapter = new SqlDataAdapter(sqlCommand);
            dataSet = new DataSet();

            sqlAdapter.Fill(dataSet);

            sqlConnection.Close();

            return dataSet;

        }


        public void CheckAdmin(string logEmail,string logpass)
        {
            try
            {

                string sql = "SELECT * FROM admin WHERE email='" + logEmail + "'";
                SqlCommand exsql = new SqlCommand(sql, sqlConnection);
                SqlDataReader reader;
                sqlConnection.Open();
                
                reader = exsql.ExecuteReader();
                if (reader.Read())
                {
                    MyVar.uid = reader.GetInt32(0);
                    userName = reader.GetString(1);
                    MyVar.uname = userName;
                    email = reader.GetString(2);
                    MyVar.uemail = email;
                    userPass = reader.GetString(3);
                    userContact = reader.GetString(4);
                    MyVar.uContact = userContact;
                    MyVar.isLogIn = false;//if log in not successful

                    if (userPass.Equals(logpass))
                    {
                        //MessageBox.Show("Log in successful", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MyVar.isLogIn = true;
                       
                    }
                    else
                    {
                        MessageBox.Show("Email and Password dont match.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("The Email is not registerd. Please register first to continue.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong.Please try again", "Messsage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        


        public void CreateAdmin(AdminDTO AdminDTO)
        {
            
            sqlConnection.Close();
            try
            {
                sqlConnection.Open();
                string sqlQuery = "insert into admin values('" + AdminDTO.UNAME + "','" + AdminDTO.EMAIL + "','" + AdminDTO.PASS + "','" + AdminDTO.CONTACT + "')";
                sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            
                sqlCommand.ExecuteNonQuery();
               
                MessageBox.Show("Registered Succesfully. You may login now.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input! Try Again.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                sqlConnection.Close();

            }


        }


        public void DeleteAdmin(int id)
        {
            sqlConnection.Open();
            string sqlQuery = "delete from admin where id = '" + id + "' ";
            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);

            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        /*My schedule methods*/
        public void AddSchedule(AdminDTO AdminDTO)
        {

           
            try
            {
                sqlConnection.Open();
                string sqlQuery = "insert into myschedule values('" + AdminDTO.COURSENO + "','" + AdminDTO.DEPT + "','" + AdminDTO.ROOMNO + "','" + AdminDTO.CLASSTIME+ "','" + AdminDTO.CLASSDAY + "','" + AdminDTO.SECTION + "','" + AdminDTO.ADMINID + "')";
                sqlCommand = new SqlCommand(sqlQuery, sqlConnection);

                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Added Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input! Try Again.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                sqlConnection.Close();

            }


        }

        public void UpdateSchedule(AdminDTO AdminDTO)
        {


            try
            {
                sqlConnection.Open();
                string sqlQuery = "UPDATE myschedule SET dept='" + AdminDTO.DEPT + "',roomNo='" + AdminDTO.ROOMNO + "',classTime='" + AdminDTO.CLASSTIME + "',classDay='" + AdminDTO.CLASSDAY + "',section='" + AdminDTO.SECTION + "'WHERE adminId='" + AdminDTO.ADMINID + "'AND courseNo='" + AdminDTO.COURSENO + "'";
                sqlCommand = new SqlCommand(sqlQuery, sqlConnection);

                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Schedule Updated Succesfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong! Check your values.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                

            }
            finally
            {
                sqlConnection.Close();

            }


        }

        /*End of My schedule methods*/

        /*My courses Method */
        public void AddCourse(AdminDTO AdminDTO)
        {
            try
            {
                sqlConnection.Open();
                string sqlQuery = "insert into mycourse values('" + AdminDTO.ADMINID + "','" + AdminDTO.COURSENO + "','" + AdminDTO.COURSENAME + "','" + AdminDTO.DEPT + "','" + AdminDTO.YEARSEM + "')";
                sqlCommand = new SqlCommand(sqlQuery, sqlConnection);

                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Course added Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong! Try Again.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                sqlConnection.Close();

            }

        }

        public void DeleteCourse(AdminDTO AdminDTO)
        {
            try
            {
                sqlConnection.Open();
                string sqlQuery = "DELETE FROM mycourse WHERE adminId='" + AdminDTO.ADMINID + "'AND courseNo='" + AdminDTO.COURSENO + "'";
                sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Course Deleted Successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Something went wrong! Try Again.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
            }
            
        }
        /*End of My courses Method */

        /*my notes method8*/

        public void TodayNote(string today)
        {
            
            try
            {
                int adid = MyVar.uid;

                string sql = "SELECT * FROM mynote WHERE remindDate='" + today + "'AND adminId='" + adid +"'";
                SqlCommand exsql = new SqlCommand(sql, sqlConnection);
                SqlDataReader reader;
                sqlConnection.Open();

                reader = exsql.ExecuteReader();
                if (reader.Read())
                {
                    userNote = reader.GetString(2);
                    MyVar.noteToday = userNote; 
                   
                }
                else
                {
                    MyVar.noteToday = "No new note for Today.";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong.Please try again", "Messsage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        public void ReadNote(int noteId)
        {

            try
            {

                string sql = "SELECT * FROM mynote WHERE noteNo='" + noteId+ "'";
                SqlCommand exsql = new SqlCommand(sql, sqlConnection);
                SqlDataReader reader;
                sqlConnection.Open();

                reader = exsql.ExecuteReader();
                if (reader.Read())
                {
                    userNoteSub = reader.GetString(1);
                    MyVar.readNoteSub = userNoteSub;
                    userNote = reader.GetString(2);
                    MyVar.readNote = userNote;
                }
                else
                {
                    MessageBox.Show("Sorry Nothing found.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong.Please try again", "Messsage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        public void AddNotes(MyInfoDTO infoDTO)
        {
            try
            {
                sqlConnection.Open();
                string sqlQuery = "insert into mynote values('" + infoDTO.NOTESUB + "','" + infoDTO.NOTE+ "','" + infoDTO.ADMINID+ "','" + infoDTO.NOTETIME + "','" + infoDTO.REMINDDATE + "')";
                sqlCommand = new SqlCommand(sqlQuery, sqlConnection);

                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Note added Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong.Please try again", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                sqlConnection.Close();

            }

        }

        public void DeleteNote(MyInfoDTO infoDTO)
        {
            try
            {
                sqlConnection.Open();
                string sqlQuery = "DELETE FROM mynote WHERE adminId='" + infoDTO.ADMINID + "'AND noteNo='" + infoDTO.NOTEID + "'";
                sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Note Deleted Successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
            }

        }
        /*end of my  notes method*/
        /*My exam method*/

        public void AddXmData(MyInfoDTO infoDTO)
        {
            try
            {
                sqlConnection.Open();
                string sqlQuery = "insert into myexam values('" + infoDTO.STUDENTID + "','" + infoDTO.DEPT + "','" + infoDTO.STUYEAR + "','" + infoDTO.STUSEM + "','" + infoDTO.QZ_1 + "','" + infoDTO.QZ_2 + "','" + infoDTO.QZ_3 + "','" + infoDTO.QZ_4 + "','" + infoDTO.FINALMARK+ "','" + infoDTO.COURSENO + "','" + infoDTO.ADMINID + "')";
                sqlCommand = new SqlCommand(sqlQuery, sqlConnection);

                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Exam data added Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong.Please try again", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                sqlConnection.Close();

            }

        }

        public void UpdateXmData(MyInfoDTO MyXmDTO)
        {


            try
            {
                sqlConnection.Open();
                string sqlQuery = "UPDATE myexam SET dept='" + MyXmDTO.DEPT + "',studentyear='" + MyXmDTO.STUYEAR + "',studentsemester='" + MyXmDTO.STUSEM + "',quiz1='" + MyXmDTO.QZ_1 + "',quiz2='" + MyXmDTO.QZ_2 + "',quiz3='" + MyXmDTO.QZ_3 + "',quiz4='" + MyXmDTO.QZ_4 + "',finalexam='" + MyXmDTO.FINALMARK + "',courseId='" + MyXmDTO.COURSENO + "',adminId='" + MyXmDTO.ADMINID + "'WHERE studentId='" + MyXmDTO.STUDENTID + "'";
                sqlCommand = new SqlCommand(sqlQuery, sqlConnection);

                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Exam data Updated Succesfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong! Check your values.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            finally
            {
                sqlConnection.Close();

            }


        }
        /*End of My exam method*/

        /*my attendance* methods*/
        public void AddAttendanceData(MyInfoDTO infoDTO)
        {
            try
            {
                sqlConnection.Open();
                string sqlQuery = "insert into myattendance values('" + infoDTO.STUDENTID + "','" + infoDTO.DEPT + "','" + infoDTO.STUYEAR + "','" + infoDTO.STUSEM + "','" + infoDTO.CLASSDATE + "','" + infoDTO.PRESENT + "','" + infoDTO.COURSENO + "','" + infoDTO.ADMINID + "')";
                sqlCommand = new SqlCommand(sqlQuery, sqlConnection);

                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Attendance added Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                sqlConnection.Close();

            }

        }
        public void UpdateAttendanceData(MyInfoDTO MyXmDTO)
        {


            try
            {
                sqlConnection.Open();
                string sqlQuery = "UPDATE myattendance SET dept='" + MyXmDTO.DEPT + "',year='" + MyXmDTO.STUYEAR + "',semester='" + MyXmDTO.STUSEM + "',present='" + MyXmDTO.PRESENT + "',adminId='" + MyXmDTO.ADMINID + "'WHERE studentId='" + MyXmDTO.STUDENTID + "'AND classdate='"+MyXmDTO.CLASSDATE+ "'AND courseNo='" + MyXmDTO.COURSENO + "'";
                sqlCommand = new SqlCommand(sqlQuery, sqlConnection);

                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Attendance data Updated Succesfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            finally
            {
                sqlConnection.Close();

            }


        }

        /*End of my attendance methods*/


        

    }

}
