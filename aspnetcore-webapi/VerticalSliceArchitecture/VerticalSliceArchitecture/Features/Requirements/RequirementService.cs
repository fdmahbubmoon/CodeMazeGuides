using Microsoft.EntityFrameworkCore;
using VerticalSliceArchitecture.Data;
using VerticalSliceArchitecture.Domain;

namespace VerticalSliceArchitecture.Features.Requirements
{
    public class RequirementService : IRequirementService
    {
        private readonly DataContext _context;

        public RequirementService(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Requirement>> GetAllRequirementsAsync()
        {
            return await _context.Requirements
                .OrderBy(x => x.Id)
                .ToListAsync();
        }

        public async Task<Requirement> GetRequirementByIdAsync(int requirementId)
        {
            return await _context.Requirements
                .FirstOrDefaultAsync(x => x.Id == requirementId);
        }
    }
}
