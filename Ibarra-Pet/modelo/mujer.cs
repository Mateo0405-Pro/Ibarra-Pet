using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ibarra_Pet.modelo
{
    public class mujer : dueño
    {
        public mujer(string cedula, string ciudad, int edad, string genero, string tipo)
            : base(cedula, ciudad, edad, genero, tipo)
        {
        }

        public override string verInfoDueño()
        {
            return base.verInfoDueño() + " (¡Descuento especial en marzo!)";
        }
    }
}