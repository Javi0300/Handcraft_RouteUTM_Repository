using System;
using System.Collections.Generic;

#nullable disable

namespace Handcraft_RouteApp.Domain.Entities
{
    public partial class CraftTour
    {
        public int Id { get; set; }
        public string NameCTour { get; set; }
        public string DescriptionCTour { get; set; }
        public string MeetingPoint { get; set; }
        public int? VisitPointOne { get; set; }
        public int? VisitPointTwo { get; set; }
        public int? VisitPointThree { get; set; }
        public int? MatrialCraft { get; set; }

        public virtual Municipality MatrialCraftNavigation { get; set; }
        public virtual Municipality VisitPointOneNavigation { get; set; }
        public virtual Municipality VisitPointThreeNavigation { get; set; }
        public virtual Municipality VisitPointTwoNavigation { get; set; }
    }
}
