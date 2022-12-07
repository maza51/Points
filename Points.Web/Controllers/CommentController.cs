using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Points.Application.Interfaces;
using Points.Application.Models;
using Points.Domain.Entities;

namespace Points.Web.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(int id, string comment, string color)
        {
            var newComment = new CreateCommentModel
            {
                Text = comment,
                PointId = id,
                BackgroundColor = color
            };
            
            var createdComment = await _commentService.CreateAsync(newComment);
            
            return RedirectToAction("Index", "Point");
        }
    }
}