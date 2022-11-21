namespace College_Space.Models
{
    public class UserDet
    {
        public User GetDet(string username, string Password)
        {
            User us = new User();
            us.UserName = username;
            us.PassWord = Password;
            return us;
        }
    }
}
