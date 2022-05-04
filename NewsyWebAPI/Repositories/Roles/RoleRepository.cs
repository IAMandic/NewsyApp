using DomainModel.Models;
using NewsyWebAPI.DatabaseContext;
using System.Collections.Generic;

namespace NewsyWebAPI.Repositories.Roles
{
    public class RoleRepository : IRoleRepository
    {
        private readonly NewsyDBContext _newsyDBContext;
        public RoleRepository(NewsyDBContext newsyDBContext)
        {
            _newsyDBContext = newsyDBContext;
        }

        public IEnumerable<Role> GetRoles()
        {
            return _newsyDBContext.Roles;
        }
    }
}
