using System;
using System.Collections.Generic;

#nullable disable

namespace Handcraft_RouteApp.Domain.Entities
{
    public partial class Craftman
    {
        public Craftman()
        {
            //Addresses = new HashSet<Address>();
            //Associations = new HashSet<Association>();
            //SocialNetworks = new HashSet<SocialNetwork>();
        }

        public int IdCraftman { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char Gender { get; set; }
        public DateTime Birthday { get; set; }
        public int age
        {        
            get
            {
                DateTime nacimiento = new DateTime(Birthday.Year, Birthday.Month, Birthday.Day);
                int age = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;
                return age;
            }
        }
        public int Municipality { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Logo { get; set; }

        //public virtual ICollection<Address> Addresses { get; set; }
        //public virtual ICollection<Association> Associations { get; set; }
        //public virtual ICollection<SocialNetwork> SocialNetworks { get; set; }
        public virtual Address Address{get;set; }
        public virtual Association Association{get;set; }
        public virtual SocialNetwork SocialNetwork{get;set; }
    }
}
