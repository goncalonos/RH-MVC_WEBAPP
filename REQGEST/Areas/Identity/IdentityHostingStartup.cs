//using System;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Identity.UI;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;
//using REQGEST.Areas.Identity.Data;
//using REQGEST.Data;

//[assembly: HostingStartup(typeof(REQGEST.Areas.Identity.IdentityHostingStartup))]
//namespace REQGEST.Areas.Identity
//{
//    public class IdentityHostingStartup : IHostingStartup
//    {
//        public void Configure(IWebHostBuilder builder)
//        {
//            builder.ConfigureServices((context, services) => {
//                services.AddDbContext<ReqGestDbContext>(options =>
//                    options.UseSqlServer(
//                        context.Configuration.GetConnectionString("ReqGestDbContextConnection")));

//                services.AddDefaultIdentity<AplicationUser>(options =>
//                {
//                    options.SignIn.RequireConfirmedAccount = false;
//                    options.Password.RequireUppercase = false;
//                    options.Password.RequireLowercase = false;
//                })
//                    .AddEntityFrameworkStores<ReqGestDbContext>();
//            });
//        }
//    }
//}