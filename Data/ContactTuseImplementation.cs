using mypersonalwebsite.Models;
using mypersonalwebsite.Repository;

namespace mypersonalwebsite.Data
{
    public class ContactTuseImplementation : IContactTuseRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public ContactTuseImplementation(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateRecord(ContactTuse model)
        {
            await _dbContext.Contacts.AddAsync(model);
            await _dbContext.SaveChangesAsync();
        }
    }
}
