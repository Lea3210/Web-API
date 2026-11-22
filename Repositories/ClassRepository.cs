using Entities;
using System.Text.Json;


namespace Repositories
{
    public class ClassRepository : IClassRepository
    {
        //This full path on your disk (M:) won't run on another computer: use a path relative to the project
        static string filePath = "M:\\API\\Web-API\\Repositories\\file.txt";
        public User AddUser(User user1)
        {
            int numberOfUsers = System.IO.File.ReadLines(filePath).Count();
            user1.id = numberOfUsers + 1;
            string userJson = JsonSerializer.Serialize(user1);
            System.IO.File.AppendAllText(filePath, userJson +
            Environment.NewLine);
            return user1;
        }

        public User GetUserById(int id)
        {
            using (StreamReader reader = System.IO.File.OpenText(filePath))
            {
                string? currentUserInFile;
                while ((currentUserInFile = reader.ReadLine()) != null)
                {
                    User user =
                    JsonSerializer.Deserialize<User>(currentUserInFile);
                    if (user.id == id)
                        return user;
                }
            }
            return null;
        }


        public User LoginUser(LoginUser user1)
        {
            using (StreamReader reader = System.IO.File.OpenText(filePath))
            {
                string? currentUserInFile;
                while ((currentUserInFile = reader.ReadLine()) != null)
                {
                    User user = JsonSerializer.Deserialize<User>(currentUserInFile);
                    if (user.email == user1.lemail && user.password == user1.lpassword)
                        return user;
                }
            }
            return null;

        }
        public void UpdateUserById(int id, User user1)
        {

            string textToReplace = string.Empty;
            using (StreamReader reader =
            System.IO.File.OpenText(filePath))
            {
                string currentUserInFile;
                while ((currentUserInFile = reader.ReadLine()) != null)
                {
                    User user = JsonSerializer.Deserialize<User>(currentUserInFile);
                    if (user.id == id)
                        textToReplace = currentUserInFile;
                }
            }
            if (textToReplace != string.Empty)
            {
                string text = System.IO.File.ReadAllText(filePath);
                text = text.Replace(textToReplace,
                JsonSerializer.Serialize(user1));
                System.IO.File.WriteAllText(filePath, text);
            }
        }

    }
}
