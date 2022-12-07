using System.Collections.Generic;
using Points.Domain.Entities;

namespace Points.Application.Models
{
    public class CreatePointModel
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int Radius { get; set; }
        public string Color { get; set; }
    }
}