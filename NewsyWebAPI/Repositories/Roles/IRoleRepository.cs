using DomainModel.Models;
using System.Collections.Generic;

namespace NewsyWebAPI.Repositories.Roles
{
    public interface IRoleRepository
    {
        public IEnumerable<Role> GetRoles();
    }
}
