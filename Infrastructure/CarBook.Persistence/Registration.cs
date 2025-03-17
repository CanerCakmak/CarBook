using CarBook.Application.Interfaces.Repositories;
using CarBook.Application.Interfaces.UnitOfWorks;
using CarBook.Domain.Identity;
using CarBook.Persistence.Context;
using CarBook.Persistence.Repositories;
using CarBook.Persistence.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistence
{
    public static class Registration
    {
        public static void AddPersistence(this IServiceCollection services) 
        {
            services.AddDbContext<AppDbContext>();

            services.AddScoped(typeof(IReadRepository<>), typeof(ReadRepository<>));
            services.AddScoped(typeof(IWriteRepository<>), typeof(WriteRepository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddIdentityCore<User>(opt =>
            {
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequiredLength = 2;
                opt.Password.RequireLowercase = false;
                opt.Password.RequireUppercase = false;
                opt.Password.RequireDigit = false;
                opt.SignIn.RequireConfirmedEmail = false;
            }).AddRoles<Role>().AddEntityFrameworkStores<AppDbContext>();
        }

    }
}
