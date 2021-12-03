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
    public class FoodTourController : ControllerBase
    {
        // [HttpPost]
        // public string post(FoodTour fTour)
        // {
        //     string MsResult = "";

        //     string NameF_Tour = fTour.NameF_Tour;

        //     string DescriptionF_Tour = fTour.DescriptionF_Tour;

        //     string MeetingPoint = fTour.MeetingPoint;

        //     string FinalPoint = fTour.FinalPoint;

        //     string NameComerceOne = fTour.NameComerceOne;

        //     string NameComerceTwo = fTour.NameComerceTwo;

        //     string NameComerceThree = fTour.NameComerceThree;

        //     string MenuDescription = fTour.MenuDescription;

        //     string ImageOne = fTour.ImageOne;

        //     string ImageTwo = fTour.ImageTwo;

        //     string ImageThree = fTour.ImageThree;

        //     if(NameF_Tour==""|| DescriptionF_Tour=="" || MeetingPoint=="" || MenuDescription==""|| ImageOne=="" || ImageTwo=="" || ImageThree=="")
        //     {
        //         //cSpell:disable
        //         MsResult = "¡ERROR!: No se pudo registrar el tour...Compruebe los datos ingresados.";
        //     }
        //     else
        //     {
        //         MsResult = "¡SUCCESS!: El tour gastronomico "+fTour.NameF_Tour+" se ha registrado exitosamente.";
        //     }
        //     return MsResult;
        // }
    }
}