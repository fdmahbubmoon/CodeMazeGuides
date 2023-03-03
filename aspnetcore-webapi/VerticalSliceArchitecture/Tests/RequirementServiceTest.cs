namespace Tests
{
    public class RequirementServiceTest
    {
        private DataContext _context;

        [Fact]
        public async Task WhenGetAllRequirements_ThenRequirementsAreReturnedSuccessfully()
        {
            var options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase("requirementDB1")
                .Options;

            _context = new DataContext(options);

            _context.Requirements.Add(new Requirement
            {
                Id = 1,
                RAM = 2,
                GPU = 2
            });

            await _context.SaveChangesAsync();

            //When
            var Requirements = await new RequirementService(_context).GetAllRequirementsAsync();

            //Then
            Assert.NotNull(Requirements);

            Assert.True(Requirements.Any());
        }

        [Fact]
        public async Task WhenGetRequirementById_ThenSpecificRequirementIsReturned()
        {
            var options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase("RequirementDB2")
                .Options;

            _context = new DataContext(options);

            _context.Requirements.Add(new Requirement
            {
                Id = 1,
                RAM = 2,
                GPU = 2
            });

            await _context.SaveChangesAsync();

            //When
            var Requirement = await new RequirementService(_context).GetRequirementByIdAsync(1);

            await _context.SaveChangesAsync();

            //Then
            Assert.NotNull(Requirement);

            Assert.True(Requirement.Id == 1);
        }
    }
}