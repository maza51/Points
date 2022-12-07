using System.Threading.Tasks;
using Points.Application.Interfaces;
using Points.Application.Models;
using Points.DataAccess;
using Points.Domain.Entities;

namespace Points.Application.Services
{
    public class CommentService: ICommentService
    {
        private readonly AppDbContext _dbContext;

        public CommentService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Comment> CreateAsync(CreateCommentModel commentModel)
        {
            var newComment = new Comment
            {
                Text = commentModel.Text,
                BackgroundColor = commentModel.BackgroundColor,
                PointId = commentModel.PointId
            };

            await _dbContext.AddAsync(newComment);
            await _dbContext.SaveChangesAsync();

            return newComment;
        }
    }
}