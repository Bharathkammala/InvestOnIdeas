using InvestOnIdeas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestOnIdeas.Services
{
    internal class UserService
    {
        private readonly List<UserModel> users = new()
        {
            new UserModel { UserId = 1, Name = "Rahul Verma", Email = "rahul@example.com",  },
            new UserModel { UserId = 2, Name = "Priya Sharma", Email = "priya@example.com", },
            new UserModel { UserId = 3, Name = "Admin", Email = "admin@investon.com", }
        };

        public async Task<UserModel> LoginAsync(string email)
        {
            await Task.Delay(100);
            return users.FirstOrDefault(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
        }

        public async Task<List<UserModel>> GetAllUsersAsync()
        {
            await Task.Delay(200);
            return users;
        }
    }
}
