using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSafe.Web.Helpers;

namespace WSafe.Web.Data
{
    public class SeedDb
    {
        private readonly EmpresaContext _context;
        private readonly IUserHelper _userHelper;

        public SeedDb(
            EmpresaContext context,
            IUserHelper userHelper)
        {
            _context = context;
            _userHelper = userHelper;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckRoles();
            var manager = await CheckUserAsync("7157", "Francisco", "Puerta", "flpuertacardon@gmail.com", "3112363842", "Cra 43A 60 sur 64", "Manager");
            var lider = await CheckUserAsync("7157", "Francisco", "Puerta", "flpuertacardon@gmail.com", "3112363842", "Cra 43A 60 sur 64", "Lider");

            await CheckManagerAsync(manager);
        }

        private async Task CheckManagerAsync(User user)
        {
            if (!_context.Managers.Any())
            {
                _context.Managers.Add(new Manager { User = user });
                await _context.SaveChangesAsync();
            }
        }

        private async Task<User> CheckUserAsync(
            string document,
            string firstName,
            string lastName,
            string email,
            string phone,
            string address,
            string role)
        {
            var user = await _userHelper.GetUserByEmailAsync(email);
            if (user == null)
            {
                user = new User
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    UserName = email,
                    PhoneNumber = phone,
                    Address = address,
                    Document = document
                };

                await _userHelper.AddUserAsync(user, "flpc5416?");
                await _userHelper.AddUserToRoleAsync(user, role);

                var token = await _userHelper.GenerateEmailConfirmationTokenAsync(user);
                await _userHelper.ConfirmEmailAsync(user, token);
            }

            return user;
        }

        private async Task CheckRoles()
        {
            await _userHelper.CheckRoleAsync("Manager");
            await _userHelper.CheckRoleAsync("Lider");
            await _userHelper.CheckRoleAsync("Copasst");
            await _userHelper.CheckRoleAsync("Brigadista");
            await _userHelper.CheckRoleAsync("Gerente");
            await _userHelper.CheckRoleAsync("Auditor");
            await _userHelper.CheckRoleAsync("Jefe");
            await _userHelper.CheckRoleAsync("Supervisor");
            await _userHelper.CheckRoleAsync("Trabajador");
        }

    }
}
