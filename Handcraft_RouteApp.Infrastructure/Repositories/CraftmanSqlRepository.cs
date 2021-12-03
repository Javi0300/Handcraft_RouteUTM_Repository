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
             var artesain = await _context.Craftmen.AsQueryable<Craftman>().AsNoTracking().ToListAsync();
            return artesain.AsQueryable();
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

        public async Task<Craftman> GetById(int id)
        {
            var artesain = await _context.Craftmen.Include(ct => ct.Address).Include(a => a.Association).Include(s => s.SocialNetwork).FirstOrDefaultAsync(ct => ct.IdCraftman == id);
            return artesain;
        }

        public async Task<int> Create(Craftman craftman)
        {
            var entity = craftman;
            await _context.AddAsync(entity);
            var rows = await _context.SaveChangesAsync();

            if(rows <= 0)
            {
                throw new Exception("¡ERROR!: No se pudo registrar al artesano correctamente...");
            }
            return entity.IdCraftman;

        
        }
        
        public async Task<bool> Update(int id, Craftman craftman)
        {
            if(id <= 0 || craftman == null)
                throw new ArgumentException("Falta información para continuar con el proceso de modificación...");

            var entity = await GetById(id);

            entity.FirstName = craftman.FirstName;
            entity.LastName = craftman.LastName;
            entity.Age = craftman.Age;
            entity.Email = craftman.Email;
            entity.Gender = craftman.Gender;
            entity.Logo = percraftmanson.Logo;

            if(person.Address != null)
            {
                if(entity.Address == null)
                    entity.Address = new Address();

               //entity.Address.City = craftman.Address.City;
                entity.Address.Number = craftman.Address.Number;
                entity.Address.Street = craftman.Address.Street;
                entity.Address.ZipCode = craftman.Address.ZipCode;
            }
            else if(entity.Address != null) 
                _context.Remove(entity.Address);

            _context.Update(entity);

            var rows = await _context.SaveChangesAsync();
            return rows > 0;
        }
        
    }
}
