namespace Points.Application.Models
{
    public class UpdatePointModel
    {
        public int Id { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int Radius { get; set; }
        public string Color { get; set; }
    }
}