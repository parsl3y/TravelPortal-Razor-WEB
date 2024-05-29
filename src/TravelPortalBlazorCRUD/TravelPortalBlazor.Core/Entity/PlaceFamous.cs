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
        public string? ImagePath { get; set; } = "/img/image/no_photo.jpg";

        [NotMapped]
        public byte? Photo { get; set; }
        public Guid CityId { get; set; }
    }
}
