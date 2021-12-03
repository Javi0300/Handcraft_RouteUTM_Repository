using System;
using System.Collections.Generic;

#nullable disable

namespace Handcraft_RouteApp.Domain.Entities
{
    public partial class FoodTour
    {
        public int IdFoodTour { get; set; }
        public string NameFTour { get; set; }
        public string DescriptionFTour { get; set; }
        public string MeetingPoint { get; set; }
        public string FinalPoint { get; set; }
        public int NameComerceOne { get; set; }
        public int NameComerceTwo { get; set; }
        public int? NameComerceThree { get; set; }
        public string MenuDescription { get; set; }
        public string ImageOne { get; set; }
        public string ImageTwo { get; set; }
        public string ImageThree { get; set; }

        public virtual Commerce NameComerceOneNavigation { get; set; }
        public virtual Commerce NameComerceThreeNavigation { get; set; }
        public virtual Commerce NameComerceTwoNavigation { get; set; }
    }
}
