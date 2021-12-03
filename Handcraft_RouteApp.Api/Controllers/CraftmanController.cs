//cSpell:disable

using System;
using System.Net;
using System.Linq;
using System.Collections;
using System.IO.Pipelines;
using System.Net.WebSockets;
using System.IO.Compression;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.Security.AccessControl;
using System.Runtime.InteropServices;
using Handcraft_RouteApp.Domain.Dtos;
using Handcraft_RouteApp.Domain.Entities;
using Handcraft_RouteApp.Domain.Interfaces;
using Handcraft_RouteApp.Infrastructure.Repositories;

namespace Handcraft_RouteApp.Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class CraftmanController : ControllerBase
    {
        private readonly ICraftmanRepository _repository;

        public CraftmanController(ICraftmanRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("All")]
        public async Task<IActionResult> GetAll()
        {
            var craftmans = await _repository.GetAll();
            var respuestaC =  craftmans.Select(ct => CreateDtoFromObject(ct));
            return Ok(respuestaC);
        } 

        [HttpGet]
        [Route("Name/{firstName}")]
        public async Task<IActionResult> GetByName(string firstName)
        {
            var craftmans = await _repository.GetByName(firstName);
            return Ok(craftmans);
        }

        [HttpGet]
        [Route("gender/{gender}")]
        public async Task<IActionResult> GetByGender(char gender)
        {
            var craftmans = await _repository.GetByGender(gender);
            return Ok(craftmans);
        }

        #region"Response"
        private CraftmanResponse CreateDtoFromObject(Craftman craftmans){
            var dtos = new CraftmanResponse(

                Name : $"{craftmans.FirstName} {craftmans.LastName}",

                Gender : craftmans.Gender,

                Telephone : craftmans.Telephone,

                Email : craftmans.Email,

                Age : craftmans.age,

                Municipality : craftmans.Address == null ? string.Empty : craftmans.Address.Municipality
                
            );
            return dtos;
        }
        #endregion


        #region"Request"
        private Craftman CreateObjectFromDto(CraftmanRequest dto){
            
            var craftman = new Craftman{

                IdCraftman = 0,

                FirstName = string.Empty,

                LastName = string.Empty,

                Gender = dto.Gender.Value,

                Birthday = dto.Birthday.Date,

                Address = new Address
                {
                    Street = string.Empty,

                    Number = string.Empty,

                    ZipCode = string.Empty,

                    Municipality = string.Empty
                },
    
                Telephone = string.Empty,

                Email = string.Empty,

                SocialNetwork = new SocialNetwork{

                    Link = string.Empty

                },

                Association = new Association{

                    Name = string.Empty

                },

                Logo = string.Empty,
                
            };

            return craftman;
        }
        #endregion
    }
}