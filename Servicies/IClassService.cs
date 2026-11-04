using Entities;

namespace Servicies
{
    public interface IClassService
    {
        User AddUser(User user1);
        int CheckPassword(string value);
        User GetUserById(int id);
        User LoginUser(LoginUser user1);
        void UpdateUserById(int id, User user1);
    }
}