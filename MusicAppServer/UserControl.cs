namespace MusicAppServer
{
    internal class UserControl
    {
        public static bool IsUserExistSign(string email)
        {
            using (var context = new AppContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Email == email);
                if (user != null)
                {
                    return true;
                }
                return false;
            }
        }
        public static bool IsUserExistLogin(string email, string password)
        {
            using (var context = new AppContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
                if (user != null)
                {
                    return true;
                }
                return false;
            }
        }
        public static void AddUser(User user)
        {
            using (var context = new AppContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }
        public static User GetUserById(int id)
        {
            using (var context = new AppContext())
            {
                return context.Users.Find(id);
            }
        }
        public static void UpdateUserName(User user, string newName)
        {
            using (var context = new AppContext())
            {
                user.Name = newName;
                context.Users.Update(user);
                context.SaveChanges();
            }
        }
        public static void UpdateUserEmail(User user, string newMail)
        {
            if (IsUserExistSign(newMail)) throw new Exception("This email is already in use.");
            using (var context = new AppContext())
            {
                user.Email = newMail;
                context.Users.Update(user);
                context.SaveChanges();
            }
        }
        public static void UpdateUserPassword(User user, string newPassword)
        {
            using (var context = new AppContext())
            {
                user.Password = newPassword;
                context.Users.Update(user);
                context.SaveChanges();
            }
        }
        public static void RemoveUser(int userId)
        {
            using (var context = new AppContext())
            {
                var user = context.Users.Find(userId);
                if (user != null)
                {
                    context.Users.Remove(user);
                    context.SaveChanges();
                }
            }
        }
    }
}
