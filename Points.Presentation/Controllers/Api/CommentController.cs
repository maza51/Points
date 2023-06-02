using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Points.Application.Comments;
using Points.Application.Interfaces;
using Points.Domain.Entities;

namespace Points.Presentation.Controllers.Api
{
    [Route("api/comments")]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCommentModel model)
        {
            var comment = await _commentService.CreateAsync(model);

            return Ok(comment);
        }
    }
}