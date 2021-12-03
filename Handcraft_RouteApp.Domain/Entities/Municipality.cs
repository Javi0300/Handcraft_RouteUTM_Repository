using System;
using System.Collections.Generic;

#nullable disable

namespace Handcraft_RouteApp.Domain.Entities
{
    public partial class Municipality
    {
        public Municipality()
        {
            CraftTourMatrialCraftNavigations = new HashSet<CraftTour>();
            CraftTourVisitPointOneNavigations = new HashSet<CraftTour>();
            CraftTourVisitPointThreeNavigations = new HashSet<CraftTour>();
            CraftTourVisitPointTwoNavigations = new HashSet<CraftTour>();
        }

        public int IdMunicipality { get; set; }
        public string NameMunicp { get; set; }

        public virtual ICollection<CraftTour> CraftTourMatrialCraftNavigations { get; set; }
        public virtual ICollection<CraftTour> CraftTourVisitPointOneNavigations { get; set; }
        public virtual ICollection<CraftTour> CraftTourVisitPointThreeNavigations { get; set; }
        public virtual ICollection<CraftTour> CraftTourVisitPointTwoNavigations { get; set; }
    }
}
