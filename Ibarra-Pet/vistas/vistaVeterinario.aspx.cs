using Ibarra_Pet.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ibarra_Pet.vistas
{
    public partial class vistaVeterinario : System.Web.UI.Page
    {
        private static mascota mascotaGlobal;
        private static historiaClinica historiaGlobal;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                pnlNino.Visible = false;
                pnlHombre.Visible = false;
                mascotaGlobal = null;
                historiaGlobal = null;
            }
        }

        protected void rblTipoDueno_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = rblTipoDueno.SelectedValue;
            pnlNino.Visible = (tipo == "nino");
            pnlHombre.Visible = (tipo == "hombre");
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreMascota = txtNombreMascota.Text;
                string raza = txtRaza.Text;
                string tipoMascota = ddlTipoMascota.SelectedItem.Text;
                DateTime fechaNacimientoMascota = DateTime.Parse(txtFechaNacMascota.Text);
                int numeroVacunas = int.Parse(txtVacunas.Text);

                mascota m = new mascota(nombreMascota, raza, tipoMascota, fechaNacimientoMascota, numeroVacunas);

                string cedula = txtCedula.Text;
                string ciudad = txtCiudad.Text;
                int edad = int.Parse(txtEdad.Text);
                string genero = ddlGenero.SelectedItem.Text;
                string tipoDueno = rblTipoDueno.SelectedValue;

                string mensajeExtra = "";

                if (tipoDueno == "nino")
                {
                    DateTime fechaNacimientoNino = DateTime.Parse(txtFechaNacNino.Text);
                    niño d = new niño(cedula, ciudad, edad, genero, "niño", fechaNacimientoNino);
                    m.Dueño = d;

                    if (fechaNacimientoNino.Day == DateTime.Now.Day &&
                        fechaNacimientoNino.Month == DateTime.Now.Month)
                    {
                        mensajeExtra = "🎁 ¡Feliz cumpleaños! Se ha registrado un obsequio para el niño.";
                    }
                }
                else if (tipoDueno == "hombre")
                {
                    int numMascotas = int.Parse(txtNumMascotas.Text);
                    string tipoComida = ddlTipoComida.SelectedItem.Text;

                    hombre d = new hombre(cedula, ciudad, edad, genero, "hombre", numMascotas, tipoComida);
                    m.Dueño = d;

                    mensajeExtra = $"ℹ️ El hombre alimenta a sus mascotas con comida {tipoComida.ToLower()} y tiene {numMascotas} mascota(s).";
                }
                else if (tipoDueno == "mujer")
                {
                    mujer d = new mujer(cedula, ciudad, edad, genero, "mujer");
                    m.Dueño = d;

                    if (DateTime.Now.Month == 3)
                    {
                        mensajeExtra = "💐 Descuento aplicado: Mes de marzo.";
                    }
                    else
                    {
                        mensajeExtra = "ℹ️ La mujer tiene descuento especial en consultas durante marzo.";
                    }
                }

                mascotaGlobal = m;
                historiaGlobal = new historiaClinica(m, DateTime.Now, "Consulta general registrada.");

                lblResultado.Text = m.verInfoMascota() + "<br/><br/><strong>" + mensajeExtra + "</strong>";
            }
            catch (Exception ex)
            {
                lblResultado.Text = "<span style='color:red;'>Error: " + ex.Message + "</span>";
            }
        }

        protected void btnAgregarEnfermedad_Click(object sender, EventArgs e)
        {
            try
            {
                if (historiaGlobal == null)
                {
                    lblResultado.Text = "⚠️ Primero registre una mascota.";
                    return;
                }

                string nombre = txtNombreEnfermedad.Text;
                string descripcion = txtDescripcionEnfermedad.Text;

                enfermedad enf = new enfermedad(nombre, descripcion);
                historiaGlobal.agregarEnfermedad(enf);

                lblResultado.Text = "✅ Enfermedad agregada correctamente.";
                txtNombreEnfermedad.Text = "";
                txtDescripcionEnfermedad.Text = "";
            }
            catch (Exception ex)
            {
                lblResultado.Text = "Error al agregar enfermedad: " + ex.Message;
            }
        }

        protected void btnGenerarInforme_Click(object sender, EventArgs e)
        {
            if (historiaGlobal != null)
            {
                lblHistoriaClinica.Text = historiaGlobal.verReporte().Replace("\n", "<br/>");
            }
            else
            {
                lblHistoriaClinica.Text = "⚠️ No hay historia clínica registrada.";
            }
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Mascota
            txtNombreMascota.Text = "";
            txtRaza.Text = "";
            ddlTipoMascota.SelectedIndex = 0;
            txtFechaNacMascota.Text = "";
            txtVacunas.Text = "";

            // Dueño
            txtCedula.Text = "";
            txtCiudad.Text = "";
            txtEdad.Text = "";
            ddlGenero.SelectedIndex = 0;
            rblTipoDueno.ClearSelection();

            // Panel niño
            txtFechaNacNino.Text = "";
            pnlNino.Visible = false;

            // Panel hombre
            txtNumMascotas.Text = "";
            ddlTipoComida.SelectedIndex = 0;
            pnlHombre.Visible = false;

            // Enfermedades
            txtNombreEnfermedad.Text = "";
            txtDescripcionEnfermedad.Text = "";

            // Etiquetas
            lblResultado.Text = "";
            lblHistoriaClinica.Text = "";

            // Reset variables estáticas
            mascotaGlobal = null;
            historiaGlobal = null;
        }
    }
    
}