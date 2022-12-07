using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Points.Application.Interfaces;
using Points.Application.Services;
using Points.DataAccess;

namespace Points.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<IPointService, PointService>();
            services.AddTransient<ICommentService, CommentService>();
            
            return services;
        }
    }
}