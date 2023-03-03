using AutoMapper;
using VerticalSliceArchitecture.Domain;

namespace VerticalSliceArchitecture.Features.Games
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Game, AddGameToConsole.GameResult>();
            CreateMap<Game, GetAllGamesForConsole.GameResult>()
                .ForMember(dest => dest.RAM, opt => opt.MapFrom(m=>m.Requirement.RAM))
                .ForMember(dest => dest.GPU, opt => opt.MapFrom(m=>m.Requirement.GPU));
            CreateMap<Game, UpdateGameForConsole.UpdateGameResult>();
        }
    }
}
