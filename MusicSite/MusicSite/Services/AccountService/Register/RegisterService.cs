using MusicSite.Logging;
using MusicSite.Models.EntityModels;
using MusicSite.Services.UserService;

namespace MusicSite.AccountService.Register
{
    public class RegisterService : IRegisterService
    {
        private IUserService _userService;
        private ILogger _log;

        public RegisterService(IUserService userService, ILogger log)
        {
            this._userService = userService;
            this._log = log;
        }

        public void Register(string firstName, string lastName, string password, string email, byte gender)
        {
            //try
            //{
                _userService.AddUser(new User()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Password = password,
                    Email = email,
                    Gender = gender
                });
            //}
            //catch (Exception ex)
            //{
            //    _log.Write("Error on user register!", ex, EventSeverity.Error);
            //}
        }
    }
}