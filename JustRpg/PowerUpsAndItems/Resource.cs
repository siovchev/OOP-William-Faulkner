namespace JustRpg.PowerUpsAndItems
{
    using JustRpg.EngineAndRenderer;
    public abstract class Resource : IResource
    {
        public MatrixCoords Position { get; set; }

        public bool IsPresent { get; set; }
        public int HitPoints { get; set; }

        public Resource(MatrixCoords position, bool isPresent, int hitPoints)
        {
            this.Position = position;
            this.IsPresent = isPresent;
            this.HitPoints = hitPoints;
        }
    }
}
