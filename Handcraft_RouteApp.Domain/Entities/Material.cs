using System;
using System.Collections.Generic;

#nullable disable

namespace Handcraft_RouteApp.Domain.Entities
{
    public partial class Material
    {
        public int IdMaterial { get; set; }
        public string TypeMaterial { get; set; }
        public int? IdCraft { get; set; }

        public virtual Craft IdCraftNavigation { get; set; }
    }
}
