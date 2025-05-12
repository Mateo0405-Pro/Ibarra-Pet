using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ibarra_Pet.modelo
{
    public class historiaClinica
    {
        private mascota mascota;
        private List<enfermedad> listaEnfermedades;
        private DateTime fechaConsulta;
        private string observaciones;

        public historiaClinica(mascota mascota, DateTime fechaConsulta, string observaciones)
        {
            this.mascota = mascota;
            this.fechaConsulta = fechaConsulta;
            this.observaciones = observaciones;
            this.listaEnfermedades = new List<enfermedad>();
        }

        public void agregarEnfermedad(enfermedad e)
        {
            this.listaEnfermedades.Add(e);
        }

        public string verReporte()
        {
            string reporte = "---- HISTORIA CLÍNICA ----\n";
            reporte += mascota.verInfoMascota() + "\n";
            reporte += $"Fecha consulta: {fechaConsulta.ToShortDateString()}\n";
            reporte += $"Observaciones: {observaciones}\n";
            reporte += "--- Enfermedades ---\n";

            foreach (var enf in listaEnfermedades)
            {
                reporte += enf.verInfoEnfermedad() + "\n";
            }

            return reporte;
        }
    }
}