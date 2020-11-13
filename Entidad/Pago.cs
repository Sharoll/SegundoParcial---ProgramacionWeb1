using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidad
{
    public class Pago
    {
        [Column(TypeName = "varchar(15)")]
        public string CodPersona {get;set;}
        
        [Column(TypeName = "varchar(15)")]
        public string CodPago {get;set;}

        [Column(TypeName = "varchar(30)")]
        public string TipoPago {get;set;}

        [Column(TypeName = "date")]
        public DateTime FechaPago {get;set;}

        [Column(TypeName = "decimal(6,0)")]
        public decimal ValorPago{get;set;}

        [Column(TypeName = "decimal(6,0)")]
        public decimal ValorIvaPago {get;set;}
         
    }
}