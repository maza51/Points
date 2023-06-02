using System.Threading.Tasks;
using Points.Application.Comments;
using Points.Domain.Entities;

namespace Points.Application.Interfaces
{
    public interface ICommentService
    {
        Task<Comment> CreateAsync(CreateCommentModel commentModel);
    }
}