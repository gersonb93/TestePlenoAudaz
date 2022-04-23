using Microsoft.AspNetCore.Mvc;
using TestePleno.Models;
using TestePleno.Services;

namespace TestePleno.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperatorController : Controller
    {
        private readonly IOperatorService operatorService;

        public OperatorController(IOperatorService operatorService)
        {
            this.operatorService = operatorService;
        }

        // GET api/<OperatorController>/5
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(operatorService.FindAll());
        }

        /*
        // GET api/<OperatorController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(operatorService.FindByID(id));
        }

        
        // POST api/<OperatorController>/5
        [HttpPost]
        public IActionResult Insert([FromBody] Operator operador)
        {
            var operadorInserido = operatorService.Create(operador);
            return CreatedAtAction(nameof(Get), new { id = operador.Id }, operador);
        }

        
        // PUT api/<OperatorController>/5
        [HttpPut]
        public IActionResult Put([FromBody] Operator operador)
        {
            var operadorAtualizado = operatorService.Update(operador);
            if (operadorAtualizado == null) return BadRequest();
            return Ok(operadorAtualizado);
        }

        // DELETE api/<OperatorController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            operatorService.Delete(id);

            return NoContent();
        }
        */
    }
}
