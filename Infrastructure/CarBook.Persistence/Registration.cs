using CarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistence
{
    public static class Registration
    {
        public static void AddPersistence(this IServiceCollection services) 
        {
            services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer("Server=DESKTOP-QIPI316 ; initial catalog = CarBookDb; integrated security = true; TrustServerCertificate = True;"));




        }

    }
}
