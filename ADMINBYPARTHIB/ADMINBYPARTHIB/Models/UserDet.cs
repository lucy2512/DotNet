namespace ADMINBYPARTHIB.Models
{
    public class UserDet
    {
        public User GetDet(string username,string Password)
        {
            User us = new User();
            us.userName = username;
            us.password = Password;
            return us;
        }
    }
}
