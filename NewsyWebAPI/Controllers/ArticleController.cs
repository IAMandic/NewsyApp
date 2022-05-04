using DomainModel.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewsyWebAPI.Repositories.Article;

namespace NewsyWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly IArticleRepository _articleRepository;
        public ArticleController(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        [HttpGet]
        public IActionResult GetArticles()
        {
            try
            {
                var articles = _articleRepository.GetArticles();
                return Ok(articles);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [Authorize]
        [HttpPost]
        public IActionResult AddArticle([FromBody] Article article)
        {
            if (article == null)
                return BadRequest();
            
            try
            {
                _articleRepository.InsertArticle(article);
                return Ok();
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [Authorize]
        [HttpPut]
        public IActionResult UpdateArticle([FromBody] Article article)
        {
            if (article == null)
                return BadRequest();

            try
            {
                _articleRepository.UpdateArticle(article);
                return Ok();
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpGet("{articleId:int}")]
        public IActionResult GetArticle(int articleId)
        {
            try
            {
                return Ok(_articleRepository.GetArticle(articleId));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
