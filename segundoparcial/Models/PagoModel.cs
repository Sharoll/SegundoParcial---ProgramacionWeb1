using System;
using Entidad;

namespace segundoparcial.Models
{
    public class PagoInputModel{

        public string codPago {get;set;}
        public string codPersona {get;set;}  
        public string tipoPago {get;set;}
        public DateTime fechaPago {get;set;}
        public decimal valorPago {get;set;}
        public decimal valorIvaPago {get;set;}
        
    }

    public class PagoViewModel : PagoInputModel
    {
        public PagoViewModel()
        {

        }
        public PagoViewModel(Pago pago)
        {
            codPago = pago.CodPago;
            codPersona = pago.CodPersona;
            tipoPago = pago.TipoPago;
            fechaPago = pago.FechaPago;
            valorPago = pago.ValorPago;
            valorIvaPago = pago.ValorIvaPago;
            
        }
    }
}