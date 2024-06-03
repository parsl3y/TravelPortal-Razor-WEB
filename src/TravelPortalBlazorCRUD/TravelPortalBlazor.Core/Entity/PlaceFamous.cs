using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPortalBlazor.Core.Entity.Interface;

namespace TravelPortalBlazor.Core.Entity
{
    public class PlaceFamous : IEntity<Guid>
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[]? Photo { get; set; }
        public City City { get; set; }
        [ForeignKey(nameof(CityId))]
        public Guid CityId { get; set; }
    }
}
