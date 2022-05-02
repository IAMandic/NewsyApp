using DomainModel.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NewsyBlazorServer.Services.Articles
{
    public interface IArticleService
    {
        public Task<List<Article>> GetArticles();
        public Task AddArticlteAsync(Article article);
        public Task<Article> GetArticleAsync(int articleId);
        public Task UpdateArticleAsync(Article article);
    }
}
