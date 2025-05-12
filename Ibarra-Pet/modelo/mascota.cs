using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ibarra_Pet.modelo
{
    public class mascota
    {
        private string nombre;
        private string raza;
        private string tipoMascota;
        private DateTime fechaNacimiento;
        private int numeroVacunas;
        private dueño dueño;

        public mascota(string nombre, string raza, string tipoMascota, DateTime fechaNacimiento, int numeroVacunas)
        {
            this.nombre = nombre;
            this.raza = raza;
            this.tipoMascota = tipoMascota;
            this.fechaNacimiento = fechaNacimiento;
            this.numeroVacunas = numeroVacunas;
        }

        public dueño Dueño { get => dueño; set => dueño = value; } 

        public string verInfoMascota()
        {
            return "Nombre: " + this.nombre + ", Raza: " + this.raza + ", Tipo: " + this.tipoMascota +
             ", Fecha Nac: " + this.fechaNacimiento.ToShortDateString() + ", Vacunas: " + this.numeroVacunas +
             "\n--- Dueño ---\n" + this.dueño.verInfoDueño();
        }
    }
}