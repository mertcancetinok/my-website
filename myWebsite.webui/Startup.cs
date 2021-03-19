using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using myWebsite.data.Abstract;
using myWebsite.data.Concrete.EfCore;
using myWebsite.webui.MailService;
using myWebsite.business.Abstract;
using myWebsite.business.Concrete;

namespace myWebsite.webui
{
    public class Startup
    {
        private IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ShopContext>(
        options => options.UseSqlServer(_configuration.GetConnectionString("SqlServerConnection")));
            services.AddControllersWithViews();
            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<ISocialService, SocialManager>();
            services.AddScoped<ISkillService, SkillManager>();
            services.AddScoped<IPortfolyoService, PortfolyoManager>();
            services.AddScoped<IJobService, JobManager>();
            services.AddScoped<IContactService, ContactManager>();

            services.AddScoped<IUserRepository, EfCoreUserRepository>();
            services.AddScoped<ISocialRepository, EfCoreSocialRepository>();
            services.AddScoped<ISkillRepository, EfCoreSkillRepository>();
            services.AddScoped<IPortfolyoRepository, EfCorePortfolyoRepository>();
            services.AddScoped<IJobRepository, EfCoreJobRepository>();
            services.AddScoped<IContactRepository, EfCoreContactRepository>();

            services.AddAuthorization();
            
            services.AddScoped<IEmailService, SmtpMailService>(i => 
            new SmtpMailService(
                _configuration["EmailSender:Host"],
                _configuration.GetValue<int>("EmailSender:Port"),
                _configuration["EmailSender:UserName"],
                _configuration["EmailSender:Password"],
                _configuration.GetValue<bool>("EmailSender:EnableSSL")
  
                )
            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                
                endpoints.MapControllerRoute(
                    name:"portfolyo",
                    pattern:"portfolyo",
                    defaults:new{controller="home",action="portfolyo"}
                );
                endpoints.MapControllerRoute(
                    name:"blog",
                    pattern:"blog",
                    defaults:new{controller="home",action="blog"}
                );
                endpoints.MapControllerRoute(
                    name:"contact",
                    pattern:"contact",
                    defaults:new{controller="home",action="contact"}
                );
                endpoints.MapControllerRoute(
                    name:"about",
                    pattern:"about",
                    defaults:new{controller="home",action="about"}
                    );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                    
                    );
            });
        }
    }
}