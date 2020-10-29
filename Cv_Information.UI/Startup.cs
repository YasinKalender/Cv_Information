using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Cv_Information.Business.Abstract;
using Cv_Information.Business.Concrete;
using Cv_Information.Business.CustomLogger;
using Cv_Information.Business.ValidationRules;
using Cv_Information.DAL.Context;
using Cv_Information.DTOs.Dto.AboutDtos;
using Cv_Information.DTOs.Dto.AppUserDtos;
using Cv_Information.DTOs.Dto.EducationDtos;
using Cv_Information.DTOs.Dto.ExperienceDtos;
using Cv_Information.DTOs.Dto.SkillsDto;
using Cv_Information.Entities.ORM.Concrete;
using Cv_Information.Repository.Abstract;
using Cv_Information.Repository.Concrete;
using Cv_Information.UI.Identity;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Cv_Information.UI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddAutoMapper(typeof(Startup));

            services.AddTransient<IValidator<AboutAddViewModel>, AboutAddValidation>();
            services.AddTransient<IValidator<AboutUpdateModel>, AboutUpdateValidator>();
            services.AddTransient<IValidator<AppUserRegister>, AppUserRegisterValidator>();
            services.AddTransient<IValidator<AppUserSýgn>, AppUserSignValidator>();
            services.AddTransient<IValidator<EducationUpdateDto>, EducationUpdateValidator>();
            services.AddTransient<IValidator<ExperienceAddDto>, ExperienceAddValidator>();
            services.AddTransient<IValidator<SkillAddUpdateDto>, SkillAddUpdateValidator>();

            services.AddControllersWithViews().AddFluentValidation();


            services.AddScoped<IEducationRepository, EducationRepository>();
            services.AddScoped<IExperienceRepository, ExperienceRepository>();
            services.AddScoped<ISkillsRepository, SkillsRepository>();
            services.AddScoped<IAboutRepository, AboutRepository>();
            services.AddScoped<IAppUserRepository, AppUserRepository>();



            services.AddScoped<IEducationService, EducationManager>();
            services.AddScoped<IExperienceService, ExperienceManager>();
            services.AddScoped<ISkillsService, SkillsManager>();
            services.AddScoped<IAboutService, AboutManager>();
            services.AddScoped<IAppUserService, AppUserManager>();

            services.AddTransient<INLog, NLogLogger>();


            services.AddDbContext<ProjectContext>();

            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<ProjectContext>();

            services.Configure<IdentityOptions>(opt =>
            {
                opt.Password.RequiredLength = 1;
                opt.Password.RequireLowercase = false;
                opt.Password.RequireUppercase = false;
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequireDigit = false;



            });

            services.ConfigureApplicationCookie(opt =>
            {

                opt.Cookie.Name = "Cookie";
                opt.Cookie.SameSite = SameSiteMode.Strict;
                opt.Cookie.HttpOnly = true;
                opt.ExpireTimeSpan = TimeSpan.FromSeconds(30);
                opt.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;
                opt.LoginPath = "/Home/Login";



            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }


            app.UseStatusCodePagesWithReExecute("/Home/StatusCode", "?code={0}");



            app.UseRouting();
            app.UseStaticFiles();
            IdentitySeed.IdentityData(userManager, roleManager).Wait();
            app.UseAuthentication();
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area}/{controller=Home}/{action=Index}/{id?}"

                    );


                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"

                    );
            });
        }
    }
}
