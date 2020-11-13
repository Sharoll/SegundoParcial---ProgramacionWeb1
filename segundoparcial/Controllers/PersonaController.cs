using System.Collections.Generic;
using System.Linq;
using Datos;
using Entidad;
using Logica;
using Microsoft.AspNetCore.Mvc;
using segundoparcial.Models;

namespace segundoparcial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class PersonaController : ControllerBase
    {
        private readonly PersonaService _personaService;
        public PersonaController(PersonaContext context){
    
            _personaService = new PersonaService(context);
        }

        // GET: api/Persona
        [HttpGet()]
        public IEnumerable<PersonaViewModel> Gets(){
            var personas = _personaService.ConsultarTodos().Select(p=> new PersonaViewModel(p));
            return personas;
        }

        // POST: api/Persona
        [HttpPost]
        public ActionResult<PersonaViewModel> Post(PersonaInputModel personaInput){
            Persona persona = MapearPersona(personaInput);
            var response = _personaService.Guardar(persona);

            if (response.Error)
            {
            return BadRequest(response.Mensaje);
            }
            return Ok(response.Persona);
        }

        private Persona MapearPersona(PersonaInputModel personaInput){
            var persona = new Persona();
            
                persona.TipoDocumento = personaInput.tipoDocumento;
                persona.Identificacion = personaInput.identificacion;
                persona.Nombre = personaInput.nombre;
                persona.Direccion = personaInput.direccion;
                persona.Telefono = personaInput.telefono;
                persona.Pais = personaInput.pais;
                persona.Departamento = personaInput.departamento;
                persona.Ciudad = personaInput.ciudad;
                return persona;
        }
     }
}