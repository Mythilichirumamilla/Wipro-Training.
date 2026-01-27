using System;

namespace SecureUserLib
{
    public class AuthService
    {
        private readonly SecurityService _security = new();

        public User Register(string username, string password)
        {
            try
            {
                return new User
                {
                    Username = username,
                    HashedPassword = _security.HashPassword(password)
                };
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message);
                throw;
            }
        }

        public bool Login(User user, string password)
        {
            try
            {
                return _security.VerifyPassword(password, user.HashedPassword);
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message);
                return false;
            }
        }
    }
}
