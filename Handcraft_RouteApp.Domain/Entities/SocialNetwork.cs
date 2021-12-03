using System;
using System.Collections.Generic;

#nullable disable

namespace Handcraft_RouteApp.Domain.Entities
{
    public partial class SocialNetwork
    {
        public int IdSocialNetworks { get; set; }
        public string Link { get; set; }
        public int? IdCraftman { get; set; }

        public virtual Craftman IdCraftmanNavigation { get; set; }
    }
}
