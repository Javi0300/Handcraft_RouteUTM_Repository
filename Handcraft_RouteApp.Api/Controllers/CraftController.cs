//cSpell:disable
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
using Handcraft_RouteApp.Domain.Dtos;
using Handcraft_RouteApp.Infrastructure.Repositories;

namespace Handcraft_RouteApp.Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class CraftController : ControllerBase
    {   
        
        [HttpGet]
        [Route("All")]
        public IActionResult GetAll()
        {
            var repository = new CraftSqlRepository();
            var crafts = repository.GetAll();
            var respuestaC = crafts.Select(ct => CreateDtoFromObject(ct));
            return Ok(respuestaC);
        }



        [HttpGet]
        [Route("namecraft/{namecraft}")]
        public IActionResult GetByName(string namecraft)
        {
            var repository = new CraftSqlRepository();
            var craft = repository.GetByName(namecraft);
            return Ok(craft);
        }

        
    
        private CraftResponse CreateDtoFromObject(Craft crafts){
            var dtos = new CraftResponse(
                Name : crafts.NameCraft,
                Image : crafts.Image,
                TypeMaterial : crafts.Material 
            
            );
            return dtos;
        }


        private Craft CreateObjectFromDto(CraftRequest dto){
            //if(dto.Age <= 0 && !dto.Gender.HasValue && string.IsNullOrEmpty(dto.City))
              //  return null;
            var craft = new Craft{
                Id = 0,
                NameCraft = string.Empty,
                Description = string.Empty,
                Image = string.Empty,
                MaterialNavigation = new Material
                {
                    TypeMaterial = string.Empty
                }
            };

            return craft;
        }
    }
}