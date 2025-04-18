using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurs
{
    public class TeamMember
    {
        public Employee Employee { get; set; }
        public DateTime ParticipationStart { get; set; }
        public DateTime ParticipationEnd { get; set; }

        public TeamMember(Employee employee, DateTime participationStart, DateTime participationEnd)
        {
            Employee = employee;
            ParticipationStart = participationStart;
            ParticipationEnd = participationEnd;
        }
    }
    
}
