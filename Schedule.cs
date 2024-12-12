using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequirementsEngineeringGroupProject
{
    public class Schedule
    {
        // properties 
        public int ScheduleID { get; private set; }
        public int CourseID { get; private set; }
        public int ExamId { get; private set; }
        public int NotificationId {  get; private set; }


        // collections 
        public List<Course> Courses { get; private set; }
        public List<Exam> Exams { get; private set; }
        public List<Notification> Notifications { get; private set; }

        // Methods 
        public void AddCourse()
        {

        }

        public void AddExam()
        {

        }

    }
}
