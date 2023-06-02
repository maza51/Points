using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Points.Application.Exceptions;
using Points.Application.Interfaces;
using Points.DataAccess;
using Points.Domain.Entities;

namespace Points.Application.Points
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

            await _dbContext.Points.AddAsync(newPoint);
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

        public async Task<Point> UpdateAsync(Point pointModel)
        {
            var pointInDb = await _dbContext.Points.AsQueryable()
                .FirstOrDefaultAsync(x => x.Id == pointModel.Id);

            if (pointInDb is null)
            {
                throw new NotFoundException("point not found");
            }

            pointInDb.PositionX = pointModel.PositionX;
            pointInDb.PositionY = pointModel.PositionY;
            pointInDb.Radius = pointModel.Radius;
            pointInDb.Color = pointModel.Color;

            await _dbContext.SaveChangesAsync();

            return pointInDb;
        }

        public async Task DeleteAsync(int id)
        {
            var pointInDb = await _dbContext.Points.AsQueryable()
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            if (pointInDb is null)
            {
                throw new NotFoundException("point not found");
            }
            
            _dbContext.Points.Remove(pointInDb);

            await _dbContext.SaveChangesAsync();
        }

        public async Task<Point> GetByIdAsync(int id)
        {
            var pointInDb = await _dbContext.Points.AsQueryable()
                .AsNoTracking()
                .Include(x => x.Comments)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (pointInDb is null)
            {
                throw new NotFoundException("point not found");
            }

            return pointInDb;
        }
    }
}