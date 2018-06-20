using System.Data.Entity;
using IdentityServer3.AspNetIdentity;
using IdentityServer3.Core.Services;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Ninject.Modules;
using Ninject.Web.Common;
using Rocket.BL.Common.Services;
using Rocket.DAL.Common.DbModels;
using Rocket.DAL.Common.DbModels.Identity;
using Rocket.DAL.Common.DbModels.Notification;
using Rocket.DAL.Common.DbModels.Parser;
using Rocket.DAL.Common.DbModels.ReleaseList;
using Rocket.DAL.Common.DbModels.Subscription;
using Rocket.DAL.Common.DbModels.User;
using Rocket.DAL.Common.Repositories;
using Rocket.DAL.Common.Repositories.IDbPersonalAreaRepository;
using Rocket.DAL.Common.Repositories.IDbUserRoleRepository;
using Rocket.DAL.Common.Repositories.Notification;
using Rocket.DAL.Common.Repositories.User;
using Rocket.DAL.Common.UoW;
using Rocket.DAL.Context;
using Rocket.DAL.Identity;
using Rocket.DAL.Repositories;
using Rocket.DAL.Repositories.Notification;
using Rocket.DAL.Repositories.PersonalArea;
using Rocket.DAL.Repositories.User;
using Rocket.DAL.Repositories.UserRole;
using Rocket.DAL.UoW;

namespace Rocket.DAL
{
    public class DALModule : NinjectModule
    {
        /// <summary>
        /// Настройка Ninject для DAL
        /// </summary>
        public override void Load()
        {
            // Контекст
            Bind<DbContext>().To<RocketContext>();
            Bind<RocketContext>().ToSelf().InRequestScope();

            // Репозитории
            Bind(typeof(IBaseRepository<>)).To(typeof(BaseRepository<>));
            Bind<IDbEmailRepository>().To<DbEmailRepository>();
            Bind<IDbUserRepository>().To<DbUserRepository>();
            Bind<IDbRoleRepository>().To<DbRoleRepository>();
            Bind<IDbPermissionRepository>().To<DbPermissionRepository>();
            Bind<IDbUserProfileRepository>().To<DbUserProfileRepository>();
            Bind<IDbEmailTemplateRepository>().To<DbEmailTemplateRepository>();
            Bind<IDbGuestBillingMessageRepository>().To<DbGuestBillingMessageRepository>();
            Bind<IDbReceiverRepository>().To<DbReceiverRepository>();
            Bind<IDbReleaseMessageRepository>().To<DbReleaseMessageRepository>();
            Bind<IDbUserBillingMessageRepository>().To<DbUserBillingMessageRepository>();
            Bind<IDbCustomMessageRepository>().To<DbCustomMessageRepository>();
            
            Bind<RocketUserManager>().ToSelf().InRequestScope();
            Bind<RockeRoleManager>().ToSelf().InRequestScope();
            Bind<IUserService>()
                .ToConstructor(context => new AspNetIdentityUserService<DbUser, string>(context.Inject<UserManager<DbUser, string>>(), null))
                .InRequestScope();

            Bind<IUserStore<DbUser>>().To<UserStore<DbUser>>();
            Bind<IRoleStore<DbRole, string>>().To<RoleStore<DbRole>>();

            // Паттерн единица работы
            Bind<IUnitOfWork>().To<UnitOfWork>();
            Bind<IStorage>().To<Storage>();
        }
    }
}
