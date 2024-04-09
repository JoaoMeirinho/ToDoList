using ToDoList.Models;
using ToDoList.Repositories.Interfaces;

namespace ToDoList.Repositories
{
    public class UserRepository : IUserRepository
    {
        public UserModel CreateUser(UserModel user)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public UserModel FindUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public UserModel UpdateUser(int id)
        {
            throw new NotImplementedException();
        }

        public bool UserExists(UserModel user)
        {
            throw new NotImplementedException();
        }

        public bool UserExists(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
