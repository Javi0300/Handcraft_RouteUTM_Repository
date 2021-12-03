using System;
using System.Collections.Generic;

#nullable disable

namespace Handcraft_RouteApp.Domain.Entities
{
    public partial class Commerce
    {
        public Commerce()
        {
            FoodTourNameComerceOneNavigations = new HashSet<FoodTour>();
            FoodTourNameComerceThreeNavigations = new HashSet<FoodTour>();
            FoodTourNameComerceTwoNavigations = new HashSet<FoodTour>();
        }

        public int IdCommerce { get; set; }
        public string NameCommerce { get; set; }
        public string Telephone { get; set; }

        public virtual ICollection<FoodTour> FoodTourNameComerceOneNavigations { get; set; }
        public virtual ICollection<FoodTour> FoodTourNameComerceThreeNavigations { get; set; }
        public virtual ICollection<FoodTour> FoodTourNameComerceTwoNavigations { get; set; }
    }
}
