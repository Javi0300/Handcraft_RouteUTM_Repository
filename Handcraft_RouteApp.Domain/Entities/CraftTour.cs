using System;
using System.Collections.Generic;

#nullable disable

namespace Handcraft_RouteApp.Domain.Entities
{
    public partial class CraftTour
    {
        public int IdCraftTour { get; set; }
        public string NameCTour { get; set; }
        public string DescriptionCTour { get; set; }
        public string MeetingPoint { get; set; }
        public string MunicipalityOne { get; set; }
        public string MunicipalityTwo { get; set; }
        public string MunicipalityThree { get; set; }
        public string HandicraftsTheme { get; set; }
    }
}
