using MusicSite.Services.UserService;
using System.Web.Security;

namespace MusicSite.AccountService.Logout
{
    public class LogoutService : ILogoutService
    {
        private IUserService _userService;

        public LogoutService(IUserService userService)
        {
            this._userService = userService;
        }

        public void Logout()
        {
            FormsAuthentication.SignOut();
        }
    }
}