using VerticalSliceArchitecture.Domain;

namespace VerticalSliceArchitecture.Features.Requirements
{
    public interface IRequirementService
    {
        Task<IEnumerable<Requirement>> GetAllRequirementsAsync();
        Task<Requirement> GetRequirementByIdAsync(int requirementId);
    }
}
