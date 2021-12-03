using System;
using System.Collections.Generic;

#nullable disable

namespace Handcraft_RouteApp.Domain.Entities
{
    public partial class Craft
    {
        public Craft()
        {
           // Materials = new HashSet<Material>();
        }

        public int IdCraft { get; set; }
        public string NameCraft { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        //public virtual ICollection<Material> Materials { get; set; }
        public virtual Material Material{get; set; }
    }
}
