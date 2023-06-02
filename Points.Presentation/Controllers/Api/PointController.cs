using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Points.Application.Interfaces;
using Points.Application.Points;
using Points.Domain.Entities;

namespace Points.Presentation.Controllers.Api
{
    [Route("api/points")]
    public class PointController : Controller
    {
        private readonly IPointService _pointService;

        public PointController(IPointService pointService)
        {
            _pointService = pointService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var pointsInDb = await _pointService.GetAllAsync();
            
            return Ok(pointsInDb);
        }

        [HttpPost]
        public async Task<IActionResult> Create()
        {
            var rnd = new Random();
            
            var model = new CreatePointModel
            {
                PositionX = rnd.Next(20, 600),
                PositionY = rnd.Next(20, 600),
                Radius = rnd.Next(10, 50),
                Color = "#00D2FF"
            };
            
            var point = await _pointService.CreateAsync(model);

            return Ok(point);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Point updateModel)
        {
            var pointUpdated = await _pointService.UpdateAsync(updateModel);

            return Ok(pointUpdated);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            await _pointService.DeleteAsync(id);

            return Ok();
        }
    }
}