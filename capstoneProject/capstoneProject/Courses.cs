using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capstoneProject
{
    public class Courses
    {
        private string _courseName;
        private string _assignmentName;
        private string _classDay;



        public string CourseName
        {
            get { return _courseName; }
            set { _courseName = value; }
        }


        public string AssignmentName
        {
            get { return _assignmentName; }
            set { _assignmentName = value; }
        }

        public string DayOfClass
        {
            get { return _classDay; }
            set { _classDay = value; }
        }

        public Courses()
        {

        }

        public Courses(string courseName)
        {
            _courseName = courseName;
        }
    }
}