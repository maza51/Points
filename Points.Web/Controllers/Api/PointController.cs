using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Points.Application.Interfaces;
using Points.Application.Models;

namespace Points.Web.Controllers.Api
{
    [Route("api/[controller]")]
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

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdatePointModel updateModel)
        {
            var pointUpdated = await _pointService.UpdateAsync(updateModel);

            return Ok(pointUpdated);
        }
    }
}