using System;
using ecoaprender.app.data.User.Repositories;
using ecoaprender.app.data.User.Sql;
using ecoaprender.app.domain.User.Interfaces;
using ecoaprender.app.domain.User.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ecoaprender.app.di {
    
    public class Bootstrap {

        public static void Configure (IServiceCollection services) {

            //--- sql
            services.AddSingleton<UserSql> ();

            //--- services
            services.AddSingleton<IUserService, UserService> ();

            //--- repository
            services.AddSingleton<IUserRepository, UserRepository> ();
        }
    }
}