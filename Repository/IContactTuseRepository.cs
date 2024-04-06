using mypersonalwebsite.Models;

namespace mypersonalwebsite.Repository
{
    public interface IContactTuseRepository
    {
        Task CreateRecord(ContactTuse model);
    }
}
