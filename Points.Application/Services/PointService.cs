using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Points.Application.Interfaces;
using Points.Application.Models;
using Points.DataAccess;
using Points.Domain.Entities;

namespace Points.Application.Services
{
    public class PointService : IPointService
    {
        private readonly AppDbContext _dbContext;

        public PointService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Point> CreateAsync(CreatePointModel pointModel)
        {
            var newPoint = new Point
            {
                PositionX = pointModel.PositionX,
                PositionY = pointModel.PositionY,
                Radius = pointModel.Radius,
                Color = pointModel.Color
            };

            await _dbContext.AddAsync(newPoint);
            await _dbContext.SaveChangesAsync();

            return newPoint;
        }

        public async Task<List<Point>> GetAllAsync()
        {
            return await _dbContext.Points.AsQueryable()
                .AsNoTracking()
                .Include(x => x.Comments)
                .ToListAsync();
        }

        public async Task<Point> UpdateAsync(UpdatePointModel pointModel)
        {
            var pointInDb = await _dbContext.Points.AsQueryable()
                .FirstOrDefaultAsync(x => x.Id == pointModel.Id);

            pointInDb.PositionX = pointModel.PositionX;
            pointInDb.PositionY = pointModel.PositionY;
            pointInDb.Radius = pointModel.Radius;
            pointInDb.Color = pointModel.Color;

            await _dbContext.SaveChangesAsync();

            return pointInDb;
        }

        public async Task<Point> GetByIdAsync(int id)
        {
            return await _dbContext.Points.AsQueryable()
                .AsNoTracking()
                .Include(x => x.Comments)
                .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}