using DatingApp.DATA.DbContexts;
using DatingApp.DATA.Models.Entities;
using DatingApp.DATA.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.DATA.Services.Implementations.SQL
{
    public class MemberService(AppDbContext db) : IMemberService
    {
        public async Task<ICollection<AppUser>> GetAllUsers()
        {
            return await db.Users.OrderBy(user => user.DisplayName).ToListAsync();
        }

        public async Task<AppUser?> GetUser(string userId)
        {
            return await db.Users.FindAsync(userId);
        }
    }
}
