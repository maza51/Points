using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Points.Application.Models;
using Points.Domain.Entities;

namespace Points.Application.Interfaces
{
    public interface IPointService
    {
        Task<Point> CreateAsync(CreatePointModel point);
        Task<List<Point>> GetAllAsync();
        Task<Point> UpdateAsync(UpdatePointModel point);
        Task<Point> GetByIdAsync(int id);
    }
}