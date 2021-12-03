using System;
using System.Collections.Generic;

#nullable disable

namespace Handcraft_RouteApp.Domain.Entities
{
    public partial class Address
    {
        public int IdAddress { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public int IdCraftman { get; set; }

        public virtual Craftman IdCraftmanNavigation { get; set; }
    }
}
