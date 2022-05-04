using DomainModel.Helpers;
using DomainModel.Models;
using System.Threading.Tasks;

namespace NewsyWebAPI.Services.AuthService
{
    public interface IAuthService
    {
        Task<ServiceResponse<int>> Register(User user, string password);
        Task<bool> UserExists(string username);
        Task<ServiceResponse<string>> Login(string username, string password);
        int GetUserId();
        string GetUserEmail();
        Task<User> GetUserByEmail(string email);
    }
}
