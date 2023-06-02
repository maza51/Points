namespace Points.Application.Comments
{
    public class CreateCommentModel
    {
        public string Text { get; set; }
        public string BackgroundColor { get; set; }
        
        public int PointId { get; set; }
    }
}