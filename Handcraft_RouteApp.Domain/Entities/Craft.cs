using System;
using System.Collections.Generic;

#nullable disable

namespace Handcraft_RouteApp.Domain.Entities
{
    public partial class Craft
    {
        public int Id { get; set; }
        public string NameCraft { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Material { get; set; }

        public virtual Material MaterialNavigation { get; set; }
    }
}
