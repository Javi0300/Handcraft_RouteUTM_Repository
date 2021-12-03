using System;
using System.Collections.Generic;

#nullable disable

namespace Handcraft_RouteApp.Domain.Entities
{
    public partial class Association
    {
        public int IdAssociation { get; set; }
        public string Name { get; set; }
        public int? IdCraftman { get; set; }

        public virtual Craftman IdCraftmanNavigation { get; set; }
    }
}
