using Domain.Models;

namespace Domain.Services
{
    public interface IUserService
    {
        public UserModel GetUserInfo();
    }
}