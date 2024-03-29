﻿namespace MovieAPI.Model
{
    public class Director
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public ICollection<Movie>? Movies { get; set; }
    }
}
