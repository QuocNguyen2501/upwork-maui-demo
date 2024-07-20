using UpworkDemo.Models;

namespace UpworkDemo.Services
{
    public static class UserService
    {
        private static User CurrentUser = new User();

        public static void setUsername(string username)
        {
            CurrentUser.Username = username;
        }

        public static void setPassword(string password)
        {
            CurrentUser.Password = password;
        }

        public static User getUser()
        {
            return CurrentUser;
        }
    }
}
