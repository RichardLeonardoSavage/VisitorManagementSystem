using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VisitorManagementSystem.Models;

namespace VisitorManagementSystem.ViewModels
{
    public class VisitorsVM
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

        [Display(Name = "Staff Person Visited")]
        public Guid StaffNameId { get; set; }
        [Display(Name = "Staff Person Visited")]
        public StaffNames? StaffName { get; set; }
    }
}
