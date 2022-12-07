namespace Points.Application.Models
{
    public class CreateCommentModel
    {
        public string Text { get; set; }
        public string BackgroundColor { get; set; }
        
        public int PointId { get; set; }
    }
}