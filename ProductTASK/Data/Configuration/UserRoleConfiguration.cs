using Microsoft.AspNetCore.Identity;
using ProductTASK.Data.Context;
using ProductTASK.Models;

namespace ProductTASK.Data.Configuration
{
    public class UserRoleConfiguration 
    {
        public static async Task Initialize(IApplicationBuilder applicationBuilder)
                                            //ApplicationDbContext context,
                                            //UserManager<ApplicationUser> userManager,
                                            //RoleManager<ApplicationRole> roleManager)
        {

            using var serviceScope = applicationBuilder.ApplicationServices.CreateScope();
            var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

            using var scope = applicationBuilder.ApplicationServices
                .GetRequiredService<IServiceScopeFactory>()
                .CreateScope();

            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<ApplicationRole>>();
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            
            context.Database.EnsureCreated();

            String adminId1 = "";

            string role1 = "Admin";
            string desc1 = "This is the administrator role";

            string role2 = "Member";
            string desc2 = "This is the member role";

            string password = "P@$$w0rd";

            if (await roleManager.FindByIdAsync(role1) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role1, desc1, DateTime.Now));
            }
            if (await roleManager.FindByIdAsync(role2) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role2, desc2, DateTime.Now));
            }

            if (await userManager.FindByEmailAsync("aa@aa.aa") == null)
            {
                var user = new ApplicationUser
                {
                    Email = "aa@aa.aa",
                    FirstName = "Master",
                    LastName = "Admin",
                    NormalizedEmail = "aa@aa.aa".ToUpper(),
                    NormalizedUserName = "aa@aa.aa".ToUpper(),
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                    LockoutEnabled = false,
                    SecurityStamp = new Guid().ToString()
                };

                var result = await userManager.CreateAsync(user);

                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role1);
                }
                adminId1 = user.Id;
            }

            if (await userManager.FindByEmailAsync("mm@mm.mm") == null)
            {
                var user = new ApplicationUser
                {
                    Email = "mm@mm.mm",
                    FirstName = "Mermelad",
                    LastName = "Marmeladev",
                    NormalizedEmail = "mm@mm.mm".ToUpper(),
                    NormalizedUserName = "mm@mm.mm".ToUpper(),
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                    LockoutEnabled = false,
                    SecurityStamp = new Guid().ToString()
                };

                var result = await userManager.CreateAsync(user);

                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role2);
                }
            }

        }
    }
}
