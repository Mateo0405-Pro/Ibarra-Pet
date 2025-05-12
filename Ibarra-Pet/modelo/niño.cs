using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ibarra_Pet.modelo
{
    public class niño : dueño
    {
        private DateTime fechaNacimiento;

        public niño(string cedula, string ciudad, int edad, string genero, string tipo, DateTime fechaNacimiento)
            : base(cedula, ciudad, edad, genero, tipo)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public override string verInfoDueño()
        {
            return base.verInfoDueño() + ", Fecha nacimiento: " + this.fechaNacimiento.ToShortDateString();
        }
    }
}