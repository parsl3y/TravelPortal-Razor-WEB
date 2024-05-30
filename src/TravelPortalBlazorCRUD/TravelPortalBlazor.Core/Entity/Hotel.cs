using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPortalBlazor.Core.Entity.Interface;

namespace TravelPortalBlazor.Core.Entity
{
    public class Hotel : IEntity<Guid>
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string name { get; set; }
        public string? ImagePath { get; set; }
        public byte[]? Photo { get; set; }
        public double rating { get; set; }

    }
}
