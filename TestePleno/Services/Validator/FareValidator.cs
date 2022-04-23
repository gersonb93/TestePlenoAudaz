using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestePleno.Models;

namespace TestePleno.Services.Validator
{
    public class FareValidator : AbstractValidator<Fare>
    {
        

        public FareValidator()
        {
           // RuleFor(x => x.Status != 1).NotNull().NotEmpty().Must(IsMorf).WithMessage("Status ativo = 1 e inativo = 0");
            RuleFor(x => x.Value);
            RuleFor(x => x.DtCadastro).LessThan(DateTime.Now).GreaterThan(DateTime.Now.AddMonths(6));

        }

        private bool IsMorf(int status)
        {
            
            return status == '1' || status == '0';
        }
    }
}
