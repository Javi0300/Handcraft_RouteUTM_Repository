using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Net.WebSockets;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.Security.AccessControl;
using System.Runtime.InteropServices;
using Handcraft_RouteApp.Domain.Entities;


namespace Handcraft_RouteApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserLoginController : ControllerBase
    {
        /* [HttpPost]
        public string post(Users User)
        {
            string MsResult="";

            int Id = User.Id;

            string UserName = User.UserName;

            string Password = User.Password;

            string Rol = User.Rol;

            if (Id<=0 ||UserName=="" || Password=="" || Rol=="")
            {
                //cSpell:disable
                MsResult="¡ERROR!: No se pudo iniciar sesión...Compruebe la información ingresada.";
            }
            else
            {
                MsResult="¡SUCCESS!: Bienvenido(a) "+User.UserName+".";
            }
            return MsResult;

        }*/
    }
}