using TravelPortalBlazor.Core.Entity.Interface;

namespace TravelPortalBlazor.Core.Entity

{
    public class City : IEntity<Guid>
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public required string Name { get; set; }
    }
}
