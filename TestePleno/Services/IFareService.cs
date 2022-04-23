using System.Collections.Generic;
using TestePleno.Models;

namespace TestePleno.Services
{
    public interface IFareService
    {

        Fare Create(Fare fare, decimal valor, string operatorCode);
        Fare Create(Fare fare);
        Fare FindByID(long id);
        List<Fare> FindAll();
        Fare Update(Fare fare);
        void Delete(long id);
        Fare GetFareByValor(decimal valor);
    }
}
