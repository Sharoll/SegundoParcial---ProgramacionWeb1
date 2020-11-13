using System;
using System.IO;
using System.Security.AccessControl;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidad
{
    public class Persona
    {
        [Column(TypeName = "varchar(10)")]
        public string TipoDocumento {get;set;}

        [Key]
        [Column(TypeName = "varchar(15)")]
        public string Identificacion {get;set;}

        [Column(TypeName = "varchar(20)")]
        public string Nombre {get;set;}

        [Column(TypeName = "varchar(20)")]
        public string Direccion {get;set;}

        [Column(TypeName = "varchar(15)")]
        public string Telefono {get;set;}

        [Column(TypeName = "varchar(20)")]
        public string Pais{get;set;}

        [Column(TypeName = "varchar(20)")]
        public string Departamento {get;set;}

        [Column(TypeName = "varchar(20)")]
        public string Ciudad {get;set;}
    }
}
