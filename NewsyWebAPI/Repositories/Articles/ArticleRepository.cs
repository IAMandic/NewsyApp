using DomainModel.Models;
using NewsyWebAPI.DatabaseContext;
using System.Collections.Generic;
using System.Linq;

namespace NewsyWebAPI.Repositories.Article
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly NewsyDBContext _newsyDBContext;
        
        public ArticleRepository(NewsyDBContext newsyDBContext)
        {
            _newsyDBContext = newsyDBContext;
        }

        public IEnumerable<DomainModel.Models.Article> GetArticles()
        {
            return _newsyDBContext.Articles.ToList();
        }

        public void InsertArticle(DomainModel.Models.Article article)
        {
            _newsyDBContext.Articles.Add(article);
            _newsyDBContext.SaveChanges();
        }
        public DomainModel.Models.Article GetArticle(int articleId)
        {
            return _newsyDBContext.Articles.FirstOrDefault(item => item.Id.Equals(articleId));
        }

        public void UpdateArticle(DomainModel.Models.Article article)
        {
            var articleForUpdate = GetArticle(article.Id);
            if(articleForUpdate != null)
            {
                articleForUpdate.Title = article.Title;
                articleForUpdate.Text = article.Text;
                articleForUpdate.Updated = System.DateTime.Now;
                articleForUpdate.Created = article.Created;

                _newsyDBContext.SaveChanges();
            }
        }
    }
}
