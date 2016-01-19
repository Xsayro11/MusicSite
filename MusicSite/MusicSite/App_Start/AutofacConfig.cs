using Autofac;
using Autofac.Integration.Mvc;
using log4net.AutoFac;
using MusicSite.AccountService;
using MusicSite.AccountService.Login;
using MusicSite.AccountService.Logout;
using MusicSite.AccountService.Register;
using MusicSite.DAL;
using MusicSite.Logging;
using MusicSite.Models.EntityModels;
using MusicSite.Services.ManagementServices;
using MusicSite.Services.ManagementServices.AddServices;
using MusicSite.Services.ManagementServices.DeleteServices;
using MusicSite.Services.ManagementServices.EditServices;
using MusicSite.Services.RepositoryService;
using MusicSite.Services.UnitOfWorkService;
using MusicSite.Services.UserService;
using System.Web.Mvc;

namespace MusicSite
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            RegisterTypes(builder);

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterModule(new LoggingModule());

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

        private static void RegisterTypes(ContainerBuilder builder)
        {
            builder.RegisterType<Context>().As<IContext>();
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>));
            builder.RegisterType<Log4NetLoggingAdapter>().As<ILogger>();

            builder.RegisterType<UserAddService>().As<IAddService<User>>();
            builder.RegisterType<UserEditService>().As<IEditService<User>>();
            builder.RegisterType<UserDeleteService>().As<IDeleteService<User>>();
            builder.RegisterGeneric(typeof(ManagementServices<>)).As(typeof(IManagementServices<>));

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();

            builder.RegisterType<UserService>().As<IUserService>();

            builder.RegisterType<RegisterService>().As<IRegisterService>();
            builder.RegisterType<LoginService>().As<ILoginService>();
            builder.RegisterType<LogoutService>().As<ILogoutService>();
            builder.RegisterType<Account>().As<IAccount>();
        }
    }
}