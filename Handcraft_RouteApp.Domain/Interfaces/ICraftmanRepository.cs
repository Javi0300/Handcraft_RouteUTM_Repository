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

        Task<Craftman> GetByName(string firstName);

        Task<Craftman> GetByGender(char gender);

        
        Task<bool> Update(Craftman craftman);
        Task<int> Create(Craftman craftman);

    }    
}
