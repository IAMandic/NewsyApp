using System.Collections.Generic;

namespace NewsyWebAPI.Repositories.Article
{
    public interface IArticleRepository
    {
        IEnumerable<DomainModel.Models.Article> GetArticles();
        void InsertArticle(DomainModel.Models.Article article);
        DomainModel.Models.Article GetArticle(int articleId);
        void UpdateArticle(DomainModel.Models.Article article);
    }
}
