using System;
using System.Collections.Generic;

#nullable disable

namespace Handcraft_RouteApp.Domain.Entities
{
    public partial class Material
    {
        public Material()
        {
            Crafts = new HashSet<Craft>();
        }

        public int Id { get; set; }
        public string TypeMaterial { get; set; }

        public virtual ICollection<Craft> Crafts { get; set; }
    }
}
