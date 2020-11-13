using System;
using System.Collections.Generic;
using System.Linq;
using Datos;
using Entidad;
using Microsoft.EntityFrameworkCore;

namespace Logica
{
    public class PagoService
    {
        private readonly PersonaContext _context;
        public PagoService(PersonaContext context){
            _context=context;
        }

         public GuardarPagoResponse Guardar(Pago pago)
        {
            try
            {
                var pagoBuscado = _context.Pagos.Find(pago.CodPago);
                if(pagoBuscado != null){
                    return new GuardarPagoResponse("Error, ya registrarada");
                }
                _context.Pagos.Add(pago);
                _context.SaveChanges();
                return new GuardarPagoResponse(pago);
            }
            catch (Exception e)
            {
                return new GuardarPagoResponse($"Error de la Aplicacion: {e.Message}");
            }
            finally { }
        }
        public List<Pago> ConsultarTodos()
        {
            List<Pago> pagos = _context.Pagos.ToList();

            return pagos;
        }

        public class GuardarPagoResponse 
        {
        public GuardarPagoResponse(Pago pago)
        {
            Error = false;
            Pago = pago;
        }
        public GuardarPagoResponse(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
        }
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Pago Pago { get; set; }

    }
    }
}