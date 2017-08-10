using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TAssistant
{
    class AdminDTO
    {
        private int adminId;
        private string uname, email,pass,contact,courseNo,dept,roomNo,classTime,classDay,section,courseName,yearSem;

        public AdminDTO(string uname,string email,string pass, string contact)
        {
            this.uname = uname;
            this.email = email;
            this.pass = pass;
            this.contact = contact;
        }
        public AdminDTO(string courseNo, string dept, string roomNo,string classTime,string classDay,string section,int adId)
        {
            this.courseNo = courseNo;
            this.dept = dept;
            this.roomNo = roomNo;
            this.classTime = classTime;
            this.classDay = classDay;
            this.section = section;
            this.adminId = adId;
        }
        /*for add course*/
        public AdminDTO(string courseNo,string courseName, string dept,string yearSem,int adminId)
        {
            this.courseNo = courseNo;
            this.courseName = courseName;
            this.dept = dept;
            this.yearSem = yearSem;
            this.adminId = adminId;
        }

        public string UNAME
        {
            get { return uname; }
            set { uname = value; }
        }
        public string EMAIL
        {
            get { return email; }
            set { email = value; }
        }
        public string PASS
        {
            get { return pass; }
            set { pass = value; }
        }
       
        public string CONTACT
        {
            get { return contact; }
            set { contact = value; }
        }
        /*for my schedule*/
        public string COURSENO
        {
            get { return courseNo; }
            set { courseNo = value; }
        }

        public string DEPT
        {
            get { return dept; }
            set { dept = value; }
        }
        public string ROOMNO
        {
            get { return roomNo; }
            set { roomNo = value; }
        }
        public string CLASSTIME
        {
            get { return classTime; }
            set { classTime = value; }
        }
        public string CLASSDAY
        {
            get { return classDay; }
            set { classDay = value; }
        }
        public string SECTION
        {
            get { return section; }
            set { section = value; }
        }
        public int ADMINID
        {
            get { return adminId; }
            set { adminId = value; }
        }
        /*End of my schedule*/

        /*my courses*/
        public string COURSENAME
        {
            get { return courseName; }
            set { courseName = value; }
        }

        public string YEARSEM
        {
            get { return yearSem; }
            set { yearSem = value; }
        }
        /*End of my courses*/
    }
}
