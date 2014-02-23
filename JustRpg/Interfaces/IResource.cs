namespace JustRpg
{
    using JustRpg.Units;
    public interface IResource
    {
        bool IsPresent { get; }
        int HitPoints { get; set; }
    }
}
