namespace MusicSite.AccountService.Login
{
    public interface ILoginService
    {
        bool Login(string email, string password);
    }
}