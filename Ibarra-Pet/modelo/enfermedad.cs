using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ibarra_Pet.modelo
{
    public class enfermedad
    {
        private string nombre;
        private string descripcion;

        public enfermedad(string nombre, string descripcion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public string verInfoEnfermedad()
        {        
            return "Nombre: " + this.nombre + ", Descripción: " + this.descripcion;
        }
    }
}