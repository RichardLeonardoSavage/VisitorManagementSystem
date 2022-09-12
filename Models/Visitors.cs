namespace VisitorManagementSystem.Models
{
    public class Visitors
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime Dateout { get; set; }

        //navigation
        public Guid StaffnameId { get; set; }
        public StaffNames StaffName { get; set; }
    }
}
