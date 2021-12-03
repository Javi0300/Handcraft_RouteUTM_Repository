using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Handcraft_RouteApp.Domain.Entities;
using Handcraft_RouteApp.Domain.Interfaces;
using Handcraft_RouteApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Handcraft_RouteApp.Infrastructure.Repositories
{
    public class CraftmanSqlRepository : ICraftmanRepository
    {
        private readonly HandCraftRouteContext _context;
        
        public CraftmanSqlRepository()
        {
            _context = new HandCraftRouteContext();
        }

        public async Task<IQueryable<Craftman>> GetAll()
        {
            var artesain = await _context.Craftmen.ToListAsync();
            return artesain.AsQueryable().AsNoTracking();
        }


        public async Task<Craftman> GetByName(string firstName)
        {
            var artesain = await _context.Craftmen.FindAsync(firstName);

            return artesain;
        }

        public async Task<Craftman> GetByGender(char gender)
        {
            var artesain = await _context.Craftmen.FindAsync(gender);

            return artesain;
        }

        public bool Create(Craftman craftman)
        {
            _context.Add(craftman);
            var id = _context.SaveChanges();
            return id > 0;
        }

        Task<IQueryable<Craftman>> ICraftmanRepository.GetByName(string firstName)
        {
            throw new NotImplementedException();
        }

        Task<IQueryable<Craftman>> ICraftmanRepository.GetByGender(char gender)
        {
            throw new NotImplementedException();
        }
    }
}