using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ibarra_Pet.modelo
{
    public class hombre : dueño
    {
        private int numeroMascotas;
        private string tipoComida;

        public hombre(string cedula, string ciudad, int edad, string genero, string tipo, int numeroMascotas, string tipoComida)
            : base(cedula, ciudad, edad, genero, tipo)
        {
            this.numeroMascotas = numeroMascotas;
            this.tipoComida = tipoComida;
        }

        public override string verInfoDueño()
        {
            return base.verInfoDueño() + ", Mascotas: " + this.numeroMascotas + ", Comida: " + this.tipoComida;
        }
    }
}