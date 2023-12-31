namespace TorneioApi.Domain
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Titles { get; set; }
        public int Games { get; set; }
        public int Goals { get; set; }
        public double? GoalsPerGame { get; set; }
        public string? Picture { get; set; }
        public string? Description { get; set; }
    }
}
