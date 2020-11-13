using System;
using Entidad;

namespace segundoparcial.Models
{
    public class PagoInputModel{

        public string CodPago {get;set;}
        public string CodPersona {get;set;}  
        public string TipoPago {get;set;}
        public DateTime FechaPago {get;set;}
        public decimal ValorPago {get;set;}
        public decimal ValorIvaPago {get;set;}
        
    }

    public class PagoViewModel : PagoInputModel
    {
        public PagoViewModel()
        {

        }
        public PagoViewModel(Pago pago)
        {
            CodPago = pago.CodPago;
            CodPersona = pago.CodPersona;
            TipoPago = pago.TipoPago;
            FechaPago = pago.FechaPago;
            ValorPago = pago.ValorPago;
            ValorIvaPago = pago.ValorIvaPago;
            
        }
    }
}