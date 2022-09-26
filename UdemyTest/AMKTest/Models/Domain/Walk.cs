namespace AMKTest.Models.Domain
{
    public class Walk
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public double Length { get; set; }
        public Guid RegionID { get; set; }

        public Guid WalkDifficultyID { get; set; }

        public Region Region { get; set; }
        public WalkDifficulty walkDifficulty { get; set; }
    }
}
