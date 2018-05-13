using System.Collections.Generic;

namespace LeaveManagementApp.Models
{
    public class Organization
    {
        public string Id { get; set; }

        public ICollection<ApplicationUser> Staff { get; set; }

        public string Name { get; set; }

    }
}