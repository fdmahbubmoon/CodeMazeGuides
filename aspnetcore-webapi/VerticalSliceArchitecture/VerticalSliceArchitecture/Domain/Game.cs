namespace VerticalSliceArchitecture.Domain
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public int ConsoleId { get; set; }
        public GameConsole Console { get; set; }
        public int RequirementId { get; set; }
        public Requirement Requirement { get; set; }
    }
}
