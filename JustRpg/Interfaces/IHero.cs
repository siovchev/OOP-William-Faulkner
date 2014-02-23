using System;
namespace JustRpg.Interfaces
{
    using System;
    // Describes the base class for any unit
    public interface IHero
    {

         string Name { get; set; }

         int Experience { get; set; }
    }
}
