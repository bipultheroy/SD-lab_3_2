using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAssistant
{
    class MyInfoDTO
    {
        private int adminId,noteId;
        private string uname,note,noteSub,noteTime,stuId,dept,stuYear,stuSem,quiz_1,quiz_2,quiz_3,quiz_4,finalMark,courseNo;
        private string classDate, Present,remindDate;

        public MyInfoDTO(string noteSub, string note,int aid,string noteTime,string remdate)
        {
            this.note = note;
            this.noteSub= noteSub;
            this.adminId = aid;
            this.noteTime = noteTime;
            this.remindDate = remdate;
         
        }
        public MyInfoDTO(int nId,int aid)
        {
            this.noteId = nId;
            this.adminId = aid;

        }
        public MyInfoDTO(string sId, string dept,string syear,string ssem,string qz_1,string qz_2,string qz_3,string qz_4,string finalmark,string crsNo,int adid)
        {
            this.stuId = sId;
            this.dept = dept;
            this.stuYear = syear;
            this.stuSem = ssem;
            this.quiz_1 = qz_1;
            this.quiz_2 = qz_2;
            this.quiz_3 = qz_3;
            this.quiz_4 = qz_4;
            this.finalMark = finalmark;
            this.courseNo = crsNo;
            this.adminId = adid;
           

        }

        public MyInfoDTO(string sId, string dept, string syear, string ssem,  string classdate, string present, string crsNo, int adid)
        {
            this.stuId = sId;
            this.dept = dept;
            this.stuYear = syear;
            this.stuSem = ssem;
            this.classDate = classdate;
            this.Present = present;
            this.courseNo = crsNo;
            this.adminId = adid;


        }


        /*my Notes*/
        public string NOTETIME
        {
            get { return noteTime; }
            set { noteTime = value; }
        }
        public int NOTEID
        {
            get { return noteId; }
            set { noteId = value; }
        }
        public string NOTESUB
        {
            get { return noteSub; }
            set { noteSub = value; }
        }

        public string NOTE
        {
            get { return note; }
            set { note = value; }
        }
        public string REMINDDATE
        {
            get { return remindDate; }
            set { remindDate = value; }
        }
        public int ADMINID
        {
            get { return adminId; }
            set { adminId = value; }
        }
        /*End of My notes*/
        /*my exams */
        public string DEPT
        {
            get { return dept; }
            set { dept = value; }
        }
        public string COURSENO
        {
            get { return courseNo; }
            set { courseNo = value; }
        }
        public string STUDENTID
        {
            get { return stuId; }
            set { stuId = value; }
        }
        public string QZ_1
        {
            get { return quiz_1; }
            set { quiz_1 = value; }
        }
        public string QZ_2
        {
            get { return quiz_2; }
            set { quiz_2 = value; }
        }
        public string QZ_3
        {
            get { return quiz_3; }
            set { quiz_3 = value; }
        }
        public string QZ_4
        {
            get { return quiz_4; }
            set { quiz_4 = value; }
        }
        public string FINALMARK
        {
            get { return finalMark; }
            set { finalMark = value; }
        }
        public string STUSEM
        {
            get { return stuSem; }
            set { stuSem = value; }
        }
        public string STUYEAR
        {
            get { return stuYear; }
            set { stuYear = value; }
        }
        /*End of my exam*/

        /*my attendance*/
        public string CLASSDATE
        {
            get { return classDate; }
            set { classDate = value; }
        }
        public string PRESENT
        {
            get { return Present; }
            set { Present = value; }
        }
        /*End of my attendance*/
    }
}
