using Microsoft.AspNetCore.Mvc;
using Biblioteca.BL.Interfaces;
using Biblioteca.Entites.DTO;
using System.Net;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DSE_RJ202336_AM200230.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        private readonly IEmpleadoService service;

        public EmpleadoController(IEmpleadoService service)
        {
            this.service = service;
        }


        // GET: api/<EmpleadoController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<EmpleadoController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(EmpleadoDto), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public async Task<IActionResult> Get(int id)
        {
            EmpleadoDto obj = (EmpleadoDto)await this.service.GetEmpleadoByIdAsync(id);
            return (obj != null) ? (IActionResult)this.Ok(obj) : (IActionResult)this.NoContent();
        }

        // POST api/<EmpleadoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmpleadoController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(EmpleadoDto), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]

        public async Task<IActionResult> Put(int id, EmpleadoDto model)
        {
            if(model == null)
            {
                return (IActionResult)this.BadRequest();
            }
            EmpleadoDto result = await this.service.UpdateEmpleado(model);
            return (result != null)? (IActionResult)this.Ok(result) : (IActionResult)this.BadRequest();
        }


        // DELETE api/<EmpleadoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
