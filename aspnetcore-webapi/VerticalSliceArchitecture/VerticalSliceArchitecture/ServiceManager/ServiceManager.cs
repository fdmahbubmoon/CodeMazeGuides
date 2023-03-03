using VerticalSliceArchitecture.Data;
using VerticalSliceArchitecture.Features.Consoles;
using VerticalSliceArchitecture.Features.Games;
using VerticalSliceArchitecture.Features.Requirements;

namespace VerticalSliceArchitecture.ServiceManager
{
    public class ServiceManager : IServiceManager
    {
        private readonly DataContext _context;
        private IConsoleService _consoleService;
        private IGameService _gameService;
        private IRequirementService _requirementService;

        public ServiceManager(DataContext context)
        {
            _context = context;
        }

        public IConsoleService Console
        {
            get
            {
                if (_consoleService == null)
                    _consoleService = new ConsoleService(_context);

                return _consoleService;
            }
        }

        public IGameService Game
        {
            get
            {
                if (_gameService == null)
                    _gameService = new GameService(_context);

                return _gameService;
            }
        }

        public IRequirementService Requirement
        {
            get
            {
                if (_requirementService == null)
                    _requirementService = new RequirementService(_context);

                return _requirementService;
            }
        }

        public Task SaveAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}
