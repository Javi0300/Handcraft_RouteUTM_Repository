using System;
using System.Collections.Generic;

#nullable disable

namespace Handcraft_RouteApp.Domain.Entities
{
    public partial class User
    {
        public int IdUser { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int? Rol { get; set; }

        public virtual Rol RolNavigation { get; set; }
    }
}
