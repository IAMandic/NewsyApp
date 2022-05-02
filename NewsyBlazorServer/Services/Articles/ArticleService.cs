using DomainModel.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NewsyBlazorServer.Services.Articles
{
    public class ArticleService : IArticleService
    {
        private readonly HttpClient _httpClient;
        private readonly string BaseApiUrl = "https://localhost:44318/api/Article";

        public ArticleService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Article>> GetArticles()
        {
            return await _httpClient.GetFromJsonAsync<List<Article>>(BaseApiUrl);
        }

        public async Task AddArticlteAsync(Article article)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, BaseApiUrl);
            request.Content = new StringContent(JsonSerializer.Serialize(article), Encoding.UTF8, "application/json");
            await _httpClient.SendAsync(request);

        }

        public async Task<Article> GetArticleAsync(int articleId)
        {
            return await _httpClient.GetFromJsonAsync<Article>($"{BaseApiUrl}/{articleId}");
        }

        public async Task UpdateArticleAsync(Article article)
        {
            var request = new HttpRequestMessage(HttpMethod.Put, BaseApiUrl);
            request.Content = new StringContent(JsonSerializer.Serialize(article), Encoding.UTF8, "application/json");
            await _httpClient.SendAsync(request);
        }
    }
}
