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
    public class PagoController : ControllerBase
    {
         private readonly PagoService _pagoService;
        public PagoController(PersonaContext context){
    
            _pagoService = new PagoService(context);
        }

        // GET: api/Pago
        [HttpGet()]
        public IEnumerable<PagoViewModel> Gets(){
            var pagos = _pagoService.ConsultarTodos().Select(p=> new PagoViewModel(p));
            return pagos;
        }

        // POST: api/Pago
        [HttpPost]
        public ActionResult<PagoViewModel> Post(PagoInputModel pagoInput){
            
            Pago pago = MapearPago(pagoInput);
            var response = _pagoService.Guardar(pago);

            if (response.Error)
            {
            return BadRequest(response.Mensaje);
            }
            return Ok(response.Pago);
        }

        private Pago MapearPago(PagoInputModel pagoInput){
            var pago = new Pago();
            
                pago.CodPago = pagoInput.codPago;
                pago.CodPersona=pagoInput.codPersona;
                pago.TipoPago=pagoInput.tipoPago;
                pago.FechaPago=pagoInput.fechaPago;
                pago.ValorPago=pagoInput.valorPago;
                pago.ValorIvaPago=pagoInput.valorIvaPago;
                
            return pago;
        }

    }
}