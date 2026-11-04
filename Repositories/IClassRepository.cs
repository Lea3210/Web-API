using Entities;

namespace Repositories
{
    public interface IClassRepository
    {
        User AddUser(User user1);
        User GetUserById(int id);
        User LoginUser(LoginUser user1);
        void UpdateUserById(int id, User user1);
    }
}