using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace Points.Domain.Entities
{
    public class Point
    {
        public int Id { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int Radius { get; set; }
        public string Color { get; set; }
        
        public List<Comment> Comments { get; set; }
    }
}