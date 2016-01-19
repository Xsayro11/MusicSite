using MusicSite.Logging;
using MusicSite.Services.UserService;

namespace MusicSite.AccountService.Login
{
    public class LoginService : ILoginService
    {
        private IUserService _userService;
        private ILogger _log;

        public LoginService(IUserService userService, ILogger log)
        {
            this._userService = userService;
            this._log = log;
        }

        public bool Login(string email, string password)
        {
            var user = _userService.GetUserByEmail(email);

            if (user == null)
                return false;

            if (user.Password == password)
                return true;

            return false;
        }
    }
}