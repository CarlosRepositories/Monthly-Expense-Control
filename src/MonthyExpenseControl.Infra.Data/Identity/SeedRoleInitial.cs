using Microsoft.AspNetCore.Identity;
using MonthyExpenseControl.Domain.Account;

namespace MonthyExpenseControl.Infra.Data.Identity
{
    public class SeedRoleInitial : ISeedUserRoleInitial
    {
        private readonly UserManager<ApplicationUser> UserManager;

        private readonly RoleManager<IdentityRole> RoleManager;

        public SeedRoleInitial(UserManager<ApplicationUser> userManager,
                               RoleManager<IdentityRole> roleManager)
        {
            RoleManager = roleManager;
            UserManager = userManager;
        }

        public void seedRoles()
        {
            try
            {
                if (!RoleManager.RoleExistsAsync("User").Result)
                {
                    IdentityRole role = new IdentityRole();
                    role.Name = "User";
                    role.NormalizedName = "USER";
                    var result = RoleManager.CreateAsync(role).Result;
                }

                if (!RoleManager.RoleExistsAsync("Admin").Result)
                {
                    IdentityRole role = new IdentityRole();
                    role.Name = "Admin";
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void SeedUsers()
        {
            try
            {
                if (UserManager.FindByEmailAsync("usuarioTeste@email.com").Result == null)
                {

                    ApplicationUser user = new ApplicationUser();

                    user.UserName = "usuarioTeste@email.com";
                    user.Email = "usuarioTeste@email.com";
                    user.NormalizedEmail = "USUARIOTESTE@EMAIL.COM";
                    user.NormalizedUserName = "USUARIOTESTE@EMAIL.COM";
                    user.EmailConfirmed = true;
                    user.LockoutEnabled = true;
                    user.SecurityStamp = Guid.NewGuid().ToString();

                    IdentityResult result = UserManager.CreateAsync(user, "Pwdteste3011#").Result;

                    if (result.Succeeded)
                    {
                        UserManager.AddToRoleAsync(user, "User");
                    }

                }

                if (UserManager.FindByEmailAsync("AdminTeste@email.com").Result == null)
                {

                    ApplicationUser user = new ApplicationUser();

                    user.UserName = "AdminTeste@email.com";
                    user.Email = "AdminTeste@email.com";
                    user.NormalizedEmail = "ADMINTESTE@EMAIL.COM";
                    user.NormalizedUserName = "ADMINTESTE@EMAIL.COM";
                    user.EmailConfirmed = true;
                    user.LockoutEnabled = true;
                    user.SecurityStamp = Guid.NewGuid().ToString();

                    IdentityResult result = UserManager.CreateAsync(user, "Pwdadmin3011#").Result;

                    if (result.Succeeded)
                    {
                        UserManager.AddToRoleAsync(user, "Admin");
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
