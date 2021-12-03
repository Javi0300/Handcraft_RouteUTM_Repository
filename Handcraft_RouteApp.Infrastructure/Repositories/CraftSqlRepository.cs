using System;
using System.Collections.Generic;
using System.Linq;
using Handcraft_RouteApp.Infrastructure.Data;
using Handcraft_RouteApp.Domain.Entities;

namespace Handcraft_RouteApp.Infrastructure.Repositories
{
    public class CraftSqlRepository
    {
        private readonly HandCraftRouteContext _contextC;
        
        public CraftSqlRepository()
        {
            _contextC = new HandCraftRouteContext();
        }

        public IEnumerable<Craft> GetAll()
        {
            var craftResult = _contextC.Crafts.Select(crt => crt);
            return craftResult;
        }

        //retorna la información por nombre de la artesania.
        public IEnumerable<Craft> GetByName(string namecraft)
        {
            var craftResult = _contextC.Crafts.Where(ct => ct.NameCraft == namecraft);

            return craftResult;
        }

    

    }
}