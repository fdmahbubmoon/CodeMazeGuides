using AutoMapper;
using MediatR;
using VerticalSliceArchitecture.ServiceManager;

namespace VerticalSliceArchitecture.Features.Requirements
{
    public class GetAllRequirements
    {
        //Input
        public class GetRequirementsQuery : IRequest<IEnumerable<RequirementResult>> { }

        //Output
        public class RequirementResult
        {
            public int Id { get; set; }
            public int RAM { get; set; }
            public int GPU { get; set; }
        }

        //Handler
        public class Handler : IRequestHandler<GetRequirementsQuery, IEnumerable<RequirementResult>>
        {
            private readonly IServiceManager _serviceManager;
            private readonly IMapper _mapper;

            public Handler(IServiceManager serviceManager, IMapper mapper)
            {
                _serviceManager = serviceManager;
                _mapper = mapper;
            }

            public async Task<IEnumerable<RequirementResult>> Handle(GetRequirementsQuery request, CancellationToken cancellationToken)
            {
                var requirements = await _serviceManager.Requirement.GetAllRequirementsAsync();
                var results = _mapper.Map<IEnumerable<RequirementResult>>(requirements);
                return results;
            }
        }
    }
}
