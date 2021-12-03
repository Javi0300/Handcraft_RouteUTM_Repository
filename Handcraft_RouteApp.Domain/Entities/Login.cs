using System;
using System.Collections.Generic;

#nullable disable

namespace Handcraft_RouteApp.Domain.Entities
{
    public partial class Login
    {
        public int IdLogin { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
