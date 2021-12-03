using System;
using System.Collections.Generic;

#nullable disable

namespace Handcraft_RouteApp.Domain.Entities
{
    public partial class GeoLocation
    {
        public int IdGeoLocation { get; set; }
        public string Altitude { get; set; }
        public string Latitude { get; set; }
    }
}
