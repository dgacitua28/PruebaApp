using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class PersonaDato
    {
        //Entity
        pruebaEntities1 prueba_db = new pruebaEntities1();

        public bool CrearPersona(PersonaModel personaDato)
        {
            bool respuesta = false;
            try
            {
                var grabado = prueba_db.Persona.Add(new Persona()
                {
                    Nombre = personaDato.Nombre,
                    Apellido = personaDato.Apellido,
                    Opciones = personaDato.Opciones,
                    Sexo = personaDato.Sexo
                });
                respuesta = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return respuesta;
        }

        public List<PersonaModel> Listar()
        {
            List<PersonaModel> listaPersona = new List<PersonaModel>();
            try
            {
                var lista = prueba_db.Persona.ToList();
                foreach (var persona in lista)
                {
                    PersonaModel p = new PersonaModel();
                    p.Nombre = persona.Nombre;
                    p.Apellido = persona.Apellido;
                    p.Opciones = persona.Opciones;
                    p.Sexo = persona.Sexo;
                    listaPersona.Add(p);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listaPersona;
        }

    }
}
