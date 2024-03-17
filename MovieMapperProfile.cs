using AutoMapper;
using MovieAPI.Model;

public class MovieMapperProfile : Profile
{
    public MovieMapperProfile()
    {
        CreateMap<Movie, MovieDTO>();
        CreateMap<Director, DirectorWithMoviesDto>();
    }
}