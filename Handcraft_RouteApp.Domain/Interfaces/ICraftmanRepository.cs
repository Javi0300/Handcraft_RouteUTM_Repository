using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Handcraft_RouteApp.Domain.Entities;


namespace Handcraft_RouteApp.Domain.Interfaces
{
    public interface ICraftmanRepository
    {
        Task<IQueryable<Craftman>> GetAll();

        Task<IQueryable<Craftman>> GetByName(string firstName);

        Task<IQueryable<Craftman>> GetByGender(char gender);

    }    
}
