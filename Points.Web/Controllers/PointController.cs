using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Points.Application.Interfaces;
using Points.Application.Models;
using Points.Domain.Entities;

namespace Points.Web.Controllers
{
    public class PointController : Controller
    {
        private readonly IPointService _pointService;

        public PointController(IPointService pointService)
        {
            _pointService = pointService;
        }

        public async Task<IActionResult> Index()
        {
            List<Point> points = await _pointService.GetAllAsync();
            
            return View(points);
        }

        public async Task<IActionResult> Create()
        {
            var rnd = new Random();
            
            var model = new CreatePointModel
            {
                PositionX = rnd.Next(100, 200),
                PositionY = rnd.Next(100, 200),
                Radius = rnd.Next(10, 50),
                Color = "#00D2FF"
            };
            
            await _pointService.CreateAsync(model);
            
            return Redirect("Index");
        }
    }
}