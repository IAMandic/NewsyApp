using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int UserId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        public Article()
        { }
    }
}
