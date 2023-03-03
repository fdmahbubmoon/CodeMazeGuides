using VerticalSliceArchitecture.Features.Consoles;
using VerticalSliceArchitecture.Features.Games;
using VerticalSliceArchitecture.Features.Requirements;

namespace VerticalSliceArchitecture.ServiceManager
{
    public interface IServiceManager
    {
        IConsoleService Console { get; }
        IGameService Game { get; }
        IRequirementService Requirement { get; }
        Task SaveAsync();
    }
}
