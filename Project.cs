using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurs
{
    public class Project
    {
        private decimal cost;
        private decimal premiumRate;
        public string? ProjectName { get; set; }
        public string Cost 
        {
            get
            {
                return cost.ToString();
            }
            set
            {
                if (!(decimal.TryParse(value, out decimal cost))) throw new ArgumentException("Цена проекта должна быть числом!");
                this.cost = cost;
            }
        } //decimal
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Employee ProjectLeader { get; set; } = null!;
        public Client ProjectClient { get; set; } = null!;
        public List<TeamMember> TeamMembers { get; set; } = null!;
        public string PremiumRate 
        {
            get
            {
                return premiumRate.ToString();
            }
            set
            {
                if (!(decimal.TryParse(value, out decimal premiumRate))) throw new ArgumentException("Премия должна быть числом!");
                this.premiumRate = premiumRate;
            }
        } //decimal

        public Project() { }
        public Project(string projectName, string cost, DateTime startDate, DateTime endDate,
                       Employee projectLeader, Client projectClient, string premiumRate)
        {
            ProjectName = projectName;
            Cost = cost;
            StartDate = startDate;
            EndDate = endDate;
            ProjectLeader = projectLeader;
            ProjectClient = projectClient;
            TeamMembers = new List<TeamMember>();
            PremiumRate = premiumRate;
        }

        public void AddTeamMember(Employee employee, DateTime participationStart, DateTime participationEnd)
        {
            TeamMembers.Add(new TeamMember(employee, participationStart, participationEnd));
        }
    }
}
