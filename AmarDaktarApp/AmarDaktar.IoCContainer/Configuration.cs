﻿using AmarDaktar.BLL;
//using AmarDaktar.BLL.Contracts;
//using AmarDaktar.Repositories.Abastractions.IEntity;
//using AmarDaktar.Repositories.EntityRepo;
//using AmarDaktar.Repositories.UnitOfWork;
//using AmarDaktar.Repositories.Abastractions.IUnitWork;
using AmarDaktar.BLL.Contracts;
using AmarDaktar.DataBaseContext;
using AmarDaktar.Repositories.Abastractions.IEntity;
using AmarDaktar.Repositories.Abastractions.IUnitWork;
using AmarDaktar.Repositories.EntityRepo;
using AmarDaktar.Repositories.UnitOfWork;
using Login_and_Log_out.Data;
using Login_and_Log_out.Helpers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace AmarDaktar.IoCContainer
{
    public static class IoCContainer
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddTransient<IDoctorService, DoctorService>();
            services.AddTransient<IDoctorRepository, DoctorRepository>();
            services.AddTransient<IHospitalService, HospitalService>();
            services.AddTransient<IHospitalRepository, HospitalRepository>();
            services.AddTransient<IUserRepository, UserRepository>();

            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<AmarDaktarDbContext>();
            services.AddScoped<JwtService>();
        }
    }
}
