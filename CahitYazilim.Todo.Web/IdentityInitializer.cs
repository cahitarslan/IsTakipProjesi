using CahitYazilim.Todo.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace CahitYazilim.Todo.Web
{
    public static class IdentityInitializer
    {
        public static async Task SeedData(UserManager<AppUser> userManager,RoleManager<AppRole> roleManager)
        {
            var adminRole = await roleManager.FindByNameAsync("Admin");
            if (adminRole == null)
            {
                await roleManager.CreateAsync(new AppRole { Name = "Admin" });
            }

            var memberRole = await roleManager.FindByNameAsync("Member");
            if (memberRole == null)
            {
                await roleManager.CreateAsync(new AppRole { Name = "Member" });
            }

            var adminUser = await userManager.FindByNameAsync("cahit");
            if (adminUser==null)
            {
                AppUser user = new AppUser
                {
                    Name = "Cahit",
                    Surname = "ARSLAN",
                    UserName = "cahit",
                    Email = "cahit@gmail.com"
                };
                await userManager.CreateAsync(user,"1");
                await userManager.AddToRoleAsync(user, "Admin");
            }
        }
    }
}
