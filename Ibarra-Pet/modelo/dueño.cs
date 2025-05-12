using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ibarra_Pet.modelo
{
    public class dueño
    {
        private string cedula;
        private string ciudad;
        private int edad;
        private string genero;
        private string tipo;

        public dueño(string cedula, string ciudad, int edad, string genero, string tipo)
        {
            this.cedula = cedula;
            this.ciudad = ciudad;
            this.edad = edad;
            this.genero = genero;
            this.tipo = tipo;
        }

        public string Cedula { get => cedula; }
        public string Tipo { get => tipo; }

        public virtual string verInfoDueño()
        {
            return "Dueño: " + this.cedula + ", Ciudad: " + this.ciudad + ", Edad: " + this.edad + ", Género: " + this.genero + ", Tipo: " + this.tipo;
        }
    }
}