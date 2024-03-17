namespace MovieAPI.Model
{
    public class MovieDTO
    {
        public int Id { get; set; }
        public int DirectorId { get; set; }
        public string? Name { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
