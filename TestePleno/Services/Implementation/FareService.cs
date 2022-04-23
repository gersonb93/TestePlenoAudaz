using System.Collections.Generic;
using TestePleno.Models;
using TestePleno.Repository;
using System;
using System.Linq;

namespace TestePleno.Services
{
    public class FareService : IFareService
    {
        private readonly IRepository<Fare> _repository;
       

        public FareService(IRepository<Fare> repository)
        {
            _repository = repository;
           
        }
        public Fare Create(Fare fare, decimal valor, string operatorCode)

        {
            return _repository.Create(fare);
        }

        public Fare GetFareByValor(decimal valor)
        {
            var fares = _repository.FindAll();
            var selectedvalor = fares.FirstOrDefault(o => o.Value == valor);
            return selectedvalor;
        }

        public Fare FindByID(long id)
        {
            return _repository.FindByID(id);
        }

        public List<Fare> FindAll()
        {
            return _repository.FindAll();
        }

        public Fare Update(Fare fare)
        {
            return _repository.Update(fare);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public Fare Create(Fare fare)
        {
            return _repository.Create(fare);
        }
    }
}
