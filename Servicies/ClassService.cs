using Entities;
using Repositories;


namespace Servicies
{
    public class ClassService : IClassService
    {
        IClassRepository repo;

        public ClassService(IClassRepository classRepository)
        {
            repo = classRepository;
        }

        //ClassRepository repo=new ClassRepository();

        public User AddUser(User user1)
        {
            return repo.AddUser(user1);
        }

        public User GetUserById(int id)
        {
            return repo.GetUserById(id);
        }

        public User LoginUser(LoginUser user1)
        {
            return repo.LoginUser(user1);
        }

        public void UpdateUserById(int id, User user1)
        {
            repo.UpdateUserById(id, user1);
        }


        public int CheckPassword(string value)
        {
            int result = Zxcvbn.Core.EvaluatePassword(value).Score;
            return result;
        }
    }
}
