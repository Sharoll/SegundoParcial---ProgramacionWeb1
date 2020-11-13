using Entidad;

namespace segundoparcial.Models
{
    public class PersonaInputModel{
        public string tipoDocumento {get;set;}
        public string identificacion {get;set;}
        public string nombre {get;set;}
        public string direccion {get;set;}
        public string telefono {get;set;}
        public string pais {get;set;}
        public string departamento {get;set;}
        public string ciudad {get;set;}
    }

    
    public class PersonaViewModel : PersonaInputModel
    {
        public PersonaViewModel()
        {

        }
        public PersonaViewModel(Persona persona)
        {
            tipoDocumento = persona.TipoDocumento;
            identificacion = persona.Identificacion;
            nombre = persona.Nombre;
            direccion = persona.Direccion;
            telefono = persona.Telefono;
            pais = persona.Pais;
            departamento = persona.Departamento;
            ciudad = persona.Ciudad;
            
        }
    }
}