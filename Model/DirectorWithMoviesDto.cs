namespace MovieAPI.Model
{
    public class DirectorWithMoviesDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<MovieDTO>? Movies { get; set; }
    }
}
