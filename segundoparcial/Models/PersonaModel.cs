using Entidad;

namespace segundoparcial.Models
{
    public class PersonaInputModel{
        public string TipoDocumento {get;set;}
        public string Identificacion {get;set;}
        public string Nombre {get;set;}
        public string Direccion {get;set;}
        public string Telefono {get;set;}
        public string Pais {get;set;}
        public string Departamento {get;set;}
        public string Ciudad {get;set;}
    }

    
    public class PersonaViewModel : PersonaInputModel
    {
        public PersonaViewModel()
        {

        }
        public PersonaViewModel(Persona persona)
        {
            TipoDocumento = persona.TipoDocumento;
            Identificacion = persona.Identificacion;
            Nombre = persona.Nombre;
            Direccion = persona.Direccion;
            Telefono = persona.Telefono;
            Pais = persona.Pais;
            Departamento = persona.Departamento;
            Ciudad = persona.Ciudad;
            
        }
    }
}