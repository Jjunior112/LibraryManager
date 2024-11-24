// using Microsoft.AspNetCore.Identity;
// using Microsoft.Extensions.DependencyInjection;
// using System;
// using System.Threading.Tasks;

// namespace LibraryManager.Data
// {
//     public static class RoleSeeder
//     {
//         public static async Task SeedRolesAsync(IServiceProvider serviceProvider)
//         {
//             var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
//             var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();

//             string[] roleNames = { "Admin", "User" };

//             foreach (var roleName in roleNames)
//             {
//                 if (!await roleManager.RoleExistsAsync(roleName))
//                 {
//                     await roleManager.CreateAsync(new IdentityRole(roleName));
//                 }
//             }

//             // Criar um administrador padrão
//             var adminUser = new IdentityUser
//             {
//                 UserName = "admin@admin.com",
//                 Email = "admin@admin.com",
//                 EmailConfirmed = true
//             };

//             var user = await userManager.FindByEmailAsync(adminUser.Email);
//             if (user == null)
//             {
//                 var createUser = await userManager.CreateAsync(adminUser, "Admin@123");
//                 if (createUser.Succeeded)
//                 {
//                     await userManager.AddToRoleAsync(adminUser, "Admin");
//                 }
//             }
//         }
//     }
// }


using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace LibraryManager.Data
{
    public static class RoleSeeder
    {
        public static async Task SeedRolesAsync(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();

            string[] roleNames = { "Admin", "User" };

            // Criar roles Admin e User
            foreach (var roleName in roleNames)
            {
                if (!await roleManager.RoleExistsAsync(roleName))
                {
                    await roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }

            // Criar um administrador padrão
            var adminUser = new IdentityUser
            {
                UserName = "admin@admin.com",
                Email = "admin@admin.com",
                EmailConfirmed = true
            };

            var existingAdmin = await userManager.FindByEmailAsync(adminUser.Email);
            if (existingAdmin == null)
            {
                var createAdmin = await userManager.CreateAsync(adminUser, "Admin@123");
                if (createAdmin.Succeeded)
                {
                    await userManager.AddToRoleAsync(adminUser, "Admin");
                }
            }



            // Criar um usuário padrão
            var users = userManager.Users.ToList();

            foreach (var user in users)
            {
                // Adiciona o usuário à role "User" se ainda não estiver nela
                if (!await userManager.IsInRoleAsync(user, "User"))
                {
                    await userManager.AddToRoleAsync(user, "User");
                }


            }
        }
    }
}
