using VisitorManagementSystem.Data;
using VisitorManagementSystem.Models;

namespace VisitorManagementSystem.Services
{
    public class DataSeeder : IDataSeeder
    {
        //used DI to inject in the database context 
        private readonly ApplicationDbContext _context;

        public DataSeeder(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }

        //a method that seeds data
        public async Task SeedAsync()
        {
            //if there are no fields in the StaffNames db
            if (!_context.StaffNames.Any())
            {
                var staff = new List<StaffNames>
                {
                    new StaffNames()

                    {Id = Guid.NewGuid(), Name = "Dwayne Bobson", Department = "Counselling", VisitorCount = 2 },

                    new StaffNames()

                    {Id = Guid.NewGuid(), Name = "Jettick Deter", Department = "Web Design", VisitorCount = 2 },

                    new StaffNames()

                    {Id = Guid.NewGuid(), Name = "Bobodile Bundee", Department = "Ultimate", VisitorCount = 2 },

                    new StaffNames()

                    {Id = Guid.NewGuid(), Name = "Xiyziauyuoweiwenxhihao", Department = "Early Childhood", VisitorCount = 2 },

                    new StaffNames()

                    {Id = Guid.NewGuid(), Name = "Jim with a J", Department = "Software", VisitorCount = 2 },

                };
                _context.StaffNames.AddRange(staff);
                await _context.SaveChangesAsync();
            }
        }
    }
}
