using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequirementsEngineeringGroupProject
{
    public class Calendar
    {
      
        public int CalendarId { get; private set; }
        public int CalendarEvent {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        // collections 
        public List<StudyBlock> StudyBlocks { get; set; }

        // Methods 
        public void ViewCalendar()
        {

        }
    }
}
