using System.Collections.Generic;
using TestePleno.Models;

namespace TestePleno.Services
{
    public interface IOperatorService
    {
        Operator Create(Operator operador);
        Operator FindByID(long id);
        List<Operator> FindAll();
        Operator Update(Operator operador);
        void Delete(long id);
        Operator GetOperatorByCode(string code);
    }
}
