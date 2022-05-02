using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public bool IsAdmin { get; set; }
        public bool Active { get; set; }
        public Role()
        {

        }
    }
}
