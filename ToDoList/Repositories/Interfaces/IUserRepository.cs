using ToDoList.Models;

namespace ToDoList.Repositories.Interfaces
{
    public interface IUserRepository
    {
        public UserModel CreateUser(UserModel user);
        public bool UserExists(UserModel user);
        public bool UserExists(string email, string password);
        public UserModel FindUserByEmail(string email);
        public UserModel UpdateUser(int id);
        public bool DeleteUser(int id);
    }
}
