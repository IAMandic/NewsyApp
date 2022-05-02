using DomainModel.Models;
using NewsyWebAPI.DatabaseContext;
using System.Collections.Generic;
using System.Linq;

namespace NewsyWebAPI.Repositories
{
    public class UserRepository
    {
        private readonly NewsyDBContext _newsyDBContext;
        public UserRepository(NewsyDBContext newsyDBContext)
        {
            _newsyDBContext = newsyDBContext;
        }

        public IEnumerable<User> GetUsers()
        {
            return _newsyDBContext.Users.ToList();
        }
    }
}
