namespace RestApiTests.Models
{
    public class CreatePostRequest
    {
        public int userId { get; set; }
        public string title { get; set; }
        public string body { get; set; }
    }
}