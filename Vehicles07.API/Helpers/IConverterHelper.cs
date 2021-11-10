using System;
using System.Threading.Tasks;
using Vehicles07.API.Data.Entities;
using Vehicles07.API.Models;

namespace Vehicles07.API.Helpers
{
    public interface IConverterHelper
    {
        Task<User> ToUserAsync(UserViewModel model, Guid imageId, bool isNew);

        UserViewModel userViewModel(User user);
    }
}
