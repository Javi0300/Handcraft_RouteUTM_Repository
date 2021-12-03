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
    public class CraftTourController : ControllerBase
    {
        // [HttpPost]
        // public string post(CraftTour Tour)
        // {
        //     string MsResult= "";

        //     int Id = Tour.Id;

        //     string  NameC_Tour = Tour.NameC_Tour;

        //     string DescriptionC_Tour = Tour.DescriptionC_Tour;

        //     string MeetingPoint = Tour.MeetingPoint;

        //     string VisitPointOne = Tour.VisitPointOne;

        //     string VisitPointTwo = Tour.VisitPointTwo;

        //     string VisitPointThree = Tour.VisitPointThree;

        //     string MatrialCraft = Tour.MatrialCraft;

        //     if(Id<=0||NameC_Tour==""|| DescriptionC_Tour=="" || MeetingPoint=="" || VisitPointOne==""|| VisitPointTwo=="" || MatrialCraft=="")
        //     {
        //         //cSpell:disable
        //         MsResult="¡ERROR!: No se pudo registrar el tour...compruebe la información.";
        //     }
        //     else
        //     {
        //         MsResult="¡SUCCESS!: El tour artesanal "+Tour.NameC_Tour+" se ha registrado exitosamente.";
        //     }
        //     return MsResult;
        // }
    }
}