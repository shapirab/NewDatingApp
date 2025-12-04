using DatingApp.DATA.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.DATA.Services.Interfaces
{
    public interface IMemberService
    {
        Task<ICollection<AppUser>> GetAllUsers();
        Task<AppUser?> GetUser(string userId);
    }
}
