using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequirementsEngineeringGroupProject
{
    public class Student
    {
   
        public int StudentID { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }


        // collections 
        public List<StudySession> StudySessions { get; private set; }

        
    }
}
