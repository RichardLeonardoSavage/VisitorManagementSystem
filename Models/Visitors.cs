using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisitorManagementSystem.Models
{
    public class Visitors
    {
        public Guid Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string? Business { get; set; }

        [Display(Name = "Time in")]
        public DateTime? DateIn { get; set; }

        [Display(Name = "Time out")]
        public DateTime? Dateout { get; set; }

        //navigation
        
        public Guid StaffNameId { get; set; }
        public StaffNames? StaffName { get; set; }
    }
}
