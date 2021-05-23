using Domain.Models;

namespace Domain.Services
{
    public class UserService : IUserService
    {
        public UserModel GetUserInfo()
        {
            return new UserModel
            {
                UserId = "wertyuiopasdfghjklzxcvbnm",
                Fullname = "Nguyen Hoang Kha"
            };
        }
    }
}