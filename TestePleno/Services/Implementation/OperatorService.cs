using System.Collections.Generic;
using System.Linq;
using TestePleno.Models;
using TestePleno.Repository;

namespace TestePleno.Services
{
    public class OperatorService : IOperatorService
    {
        private readonly IRepository<Operator> _repository;

        public OperatorService(IRepository<Operator> repository)
        {
            _repository = repository;

        }

        public Operator Create(Operator operador)
        {
            return _repository.Create(operador);
        }

        public Operator GetOperatorByCode(string code)
        {
            var operators = _repository.FindAll();
            var selectedOperator = operators.FirstOrDefault(o => o.Code == code);
            return selectedOperator;
        }


        public Operator FindByID(long id)
        {
            return _repository.FindByID(id);
        }

        public List<Operator> FindAll()
        {
            return _repository.FindAll();
        }

        Operator IOperatorService.Update(Operator operador)
        {
            return _repository.Update(operador);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }


    }
}
