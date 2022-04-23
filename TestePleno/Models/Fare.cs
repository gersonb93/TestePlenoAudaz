using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePleno.Models
{
    public class Fare : IModel
    {
        public Guid OperatorId { get; set; }
        public int Status { get; set; }
        public decimal Value { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? DtCadastro { get; set; }
    }
}
