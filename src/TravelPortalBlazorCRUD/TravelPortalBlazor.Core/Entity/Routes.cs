using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPortalBlazor.Core.Entity.Interface;

namespace TravelPortalBlazor.Core.Entity
{
    public class Routes : IEntity<Guid>
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string name { get; set; } // = StartCity.Name + " - " + EndCity.Name;
        public Guid StartCityId { get; set; }
        public Guid EndCityId { get; set; }
        [ForeignKey(nameof(EndCity))]
        public City? EndCity { get; set; }
    }
}
