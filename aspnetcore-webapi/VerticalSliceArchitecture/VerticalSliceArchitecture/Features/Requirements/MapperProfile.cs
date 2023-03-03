using AutoMapper;
using VerticalSliceArchitecture.Domain;

namespace VerticalSliceArchitecture.Features.Requirements
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Requirement, GetAllRequirements.RequirementResult>();
        }
    }
}
