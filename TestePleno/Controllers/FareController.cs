using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using TestePleno.Models;
using TestePleno.Services;

namespace TestePleno.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FareController : ControllerBase
    {
        private readonly IFareService fareService;
        private OperatorService _operatorService;

        public FareController(IFareService fareService)
        {
            this.fareService = fareService;
         
        }

        // GET api/<FareController>/5
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(fareService.FindAll());
        }
      
        // POST api/<FareController>/5
        [HttpPost]
        public IActionResult Insert(decimal valor, string operatorCode)
        {
            Fare fare = new Fare();
            var selectedOperator = _operatorService.GetOperatorByCode(operatorCode);
            var selectedValor = fareService.GetFareByValor(valor);
            fare.OperatorId = selectedOperator.Id;
            
            if(fare.Status != 1 && selectedOperator.Equals(operatorCode) && !selectedValor.Value.Equals(valor))
            {
                fareService.Create(fare);
                return CreatedAtAction(nameof(Get), new { id = fare.Id }, fare);
            } else
            {
                return NoContent();
            } 

            //   var fareInserido = fareService.Create(fare);
            //return Ok(fareService.Create(fare));
            //return CreatedAtAction(nameof(Get), new { id = fare.Id }, fare);
        }
              


        /*
         
        // GET api/<FareController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(fareService.FindByID(id));
        }




        // PUT api/<FareController>/5
        [HttpPut]
        public IActionResult Put([FromBody] Fare fare)
        {
            var fareAtualizado = fareService.Update(fare);
            if (fareAtualizado == null) return BadRequest();
            return Ok(fareAtualizado);
        }

        // DELETE api/<FareController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            fareService.Delete(id);

            return NoContent();
        }
        */
    }
}
