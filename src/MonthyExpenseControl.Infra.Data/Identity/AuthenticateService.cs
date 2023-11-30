using Microsoft.AspNetCore.Identity;
using MonthyExpenseControl.Domain.Account;

namespace MonthyExpenseControl.Infra.Data.Identity
{
    public class AuthenticateService : IAuthenticate
    {
        private readonly UserManager<ApplicationUser> UserManager;

        private readonly SignInManager<ApplicationUser> SignInManager;

        public AuthenticateService(UserManager<ApplicationUser> userManager,
                                   SignInManager<ApplicationUser> signInManager )
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }
        public async Task<bool> AuthenticateAsync(string email, string password)
        {
            var result = await SignInManager.PasswordSignInAsync(email, password, false, lockoutOnFailure: true);
            if (result == null) 
            {
                throw new InvalidOperationException("Acesso não permitido! Verifique credenciais e tente novamente");
            }

            return result.Succeeded;
        }

        public async Task Logout()
        {
            await SignInManager.SignOutAsync();
        }

        public async Task<bool> RegisterUserAsync(string email, string password)
        {
            var applicationUser = new ApplicationUser()
            {
                Email = email,
                UserName = email
            };

            var result = await UserManager.CreateAsync(applicationUser);

            if(result == null) 
            {
                throw new InvalidOperationException("Erro ao criar usuário." +
                                                    " Tente outras credenciais");
            }

            if (result.Succeeded)
            {
                await SignInManager.SignInAsync(applicationUser, isPersistent: false);
            }

            return result.Succeeded;
        }
    }
}
