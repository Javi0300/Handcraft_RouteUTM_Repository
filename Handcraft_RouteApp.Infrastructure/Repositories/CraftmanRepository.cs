using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using Handcraft_RouteApp.Domain.Entities;
using Handcraft_RouteApp.Infrastructure.Repositories;
using Handcraft_RouteApp.Domain.Dtos;

namespace Handcraft_RouteApp.Infrastructure.Repositories
{
    public class CraftmanRepository
    {
        

       //List<Craftman> _craftman;

        /* public CraftmanRepository()
        {
            var fileName = "Craftman.data.json";
            if(File.Exists(fileName))
            {
                var json = File.ReadAllText(fileName);
                _craftman= JsonSerializer.Deserialize<IEnumerable<Craftman>>(json).ToList();
            }
        }*/
        //cSpell:disable

        // retornar a todos los artesanos
        /*public IEnumerable<Craftman> GetAll()
        {
            var artesain = _craftman.Select(ct => ct);
            return artesain;
        }*/

        //Retornar por ID
        // public IEnumerable<Craftman> GetById(int id)
        // {
        //     var artesain = _craftman.Where(ct => ct.IdCraftman == id);
        //     return artesain;
        // }

        //retorna a todos los artesanos que coincidan con el nombre ingresado
        // public IEnumerable<Craftman> GetByName(string firstName)
        // {
        //     var artesain = _craftman.Where(ct => ct.FirstName == firstName);

        //     return artesain;
        // }

        //retornar a todos los artesanos que coincidan con el apellido ingresado
        // public IEnumerable<Craftman> GetByLastName(string lastName)
        // {
        //     var artesain = _craftman.Where(ct => ct.LastName == lastName);

        //     return artesain;
        // }

        //retornar a un artesano(a) en concreto dependiendo el nombre y apellido
        /*public IEnumerable<Craftman> GetByArtesain(string first_Name, string last_Name)
        {
            var artesain = _craftman.Where(ct => ct.FirstName == first_Name && ct.LastName == last_Name);

            return artesain;
        }*/

        //retornar a todos los artesanos mediante su genero
        /* public IEnumerable<Craftman> GetByGender(char gender)
        {
            var artesain = _craftman.Where(ct => ct.Gender.Value == gender);

            return artesain;
        }*/

        //retornar a todos los artesanos de una edad en concreto
        /*public IEnumerable<Craftman> GetByAge(DateTime age)
        {
            var artesain = _craftman.Where(ct => ct.Age == age);

            return artesain;
        }*/

        //retornar a todos los artesanos dependiendo el municipio ingresado
        /*public IEnumerable<Craftman> GetByMunicip(int municipality)
        {
            var artesain = _craftman.Where(ct => ct.Municipality == municipality);

            return artesain;
        }*/

        //retornar a un artesano en concreto mediante su número telefonico
        /*public IEnumerable<Craftman> GetByNumber(string telephone)
        {
            var artesain = _craftman.Where(ct => ct.Telephone == telephone);

            return artesain;
        }*/

        //retornar a todos los artesanos mediante su asociación 
        /*public IEnumerable<Craftman> GetByAssociation(int assosiation)
        {
            var artesain = _craftman.Where(ct => ct.Association == assosiation);

            return artesain;
        }*/

        //retornar a todos los artesanos mediante su fecha de alta dd/mm/aa
        /*public IEnumerable<Craftman> GetByCreateDate(DateTime date)
        {
            var artesain = _craftman.Where(ct => ct.CreateDate == date);

            return artesain;
        }*/

        //retornar a los artesanos por mes
       /* public IEnumerable<Craftman> GetByMonth(int Consult_month)
        {
            var artesain = _craftman.Where(ct => ct.CreateMonth == Consult_month);

            return artesain;
        }

        //retornar a los artesanos por año
        public IEnumerable<Craftman> GetByYear(int Consult_year)
        {
            var artesain = _craftman.Where(ct => ct.CreateYear == Consult_year);

            return artesain;
        }

        //retornar la cantidad de artesanos registrados en el sistema dependiendo su genero
        public int CountByGender(char Craftman_gender)
        {
            var artesain = _craftman.Count(ct => ct.Gender == Craftman_gender);

            return artesain;
        }*/

        

    }
}

