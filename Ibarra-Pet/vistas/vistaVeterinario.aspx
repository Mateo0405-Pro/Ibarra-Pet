<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="vistaVeterinario.aspx.cs" Inherits="Ibarra_Pet.vistas.vistaVeterinario" %>

<!DOCTYPE html>
<html lang="es">
<head>
  <meta charset="UTF-8" />
  <meta name="viewport" content="width=device-width, initial-scale=1.0" />
  <title>Ibarra-Pet - Gestión Clínica</title>
  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" />
  <style>
  body {
    background: linear-gradient(to bottom right, #ffffff, #ecfdf5);
    font-family: 'Segoe UI', sans-serif;
    position: relative;
  }

  .bg-animated {
    position: fixed;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
    background-image: url('https://cdn-icons-png.flaticon.com/512/616/616408.png');
    background-repeat: repeat;
    background-size: 120px;
    opacity: 0.07;
    animation: pawScroll 60s linear infinite;
    z-index: -1;
    filter: grayscale(100%) contrast(120%) brightness(85%);
  }

  @keyframes pawScroll {
    from { background-position: 0 0; }
    to { background-position: 1000px 1000px; }
  }

  .main-title {
    font-size: 3.5rem;
    font-weight: 900;
    text-align: center;
    background: linear-gradient(90deg, #14b8a6, #22d3ee, #3b82f6);
    -webkit-background-clip: text;
    -webkit-text-fill-color: transparent;
    animation: pulse 4s infinite;
  }

  @keyframes pulse {
    0%, 100% { text-shadow: 0 0 8px rgba(14, 165, 233, 0.3); }
    50% { text-shadow: 0 0 16px rgba(34, 211, 238, 0.6); }
  }

  .card-style {
    background: rgba(255, 255, 255, 0.97);
    border-radius: 1.5rem;
    box-shadow: 0 12px 30px rgba(0, 0, 0, 0.08);
  }

  .btn-gradient {
    background: linear-gradient(to right, #10b981, #3b82f6);
    color: white;
    border: none;
    border-radius: 50px;
    padding: 0.75rem 1.5rem;
    font-weight: bold;
    transition: transform 0.3s ease, box-shadow 0.3s ease;
  }

  .btn-gradient:hover {
    transform: scale(1.06);
    background: linear-gradient(to right, #3b82f6, #10b981);
    box-shadow: 0 5px 15px rgba(59, 130, 246, 0.3);
  }

  .alert-info {
    background-color: #ecfeff;
    border-left: 4px solid #06b6d4;
    color: #0369a1;
    font-size: 0.95rem;
  }

  .lead {
    font-size: 1.1rem;
  }

  .navbar-brand strong {
    color: #0f766e;
  }

.radio-button-list label {
  display: inline-block;
  background: #f1f5f9;
  color: #0f172a;
  padding: 0.5rem 1rem;
  margin-right: 10px;
  border-radius: 50px;
  font-weight: 600;
  cursor: pointer;
  border: 2px solid transparent;
  transition: all 0.3s ease;
}

.radio-button-list input[type="radio"] {
  display: none;
}

.radio-button-list input[type="radio"]:checked + label {
  background: linear-gradient(to right, #10b981, #3b82f6);
  color: white;
  border-color: #0ea5e9;
  box-shadow: 0 2px 8px rgba(14, 165, 233, 0.3);
}

</style>
</head>
<body>
  <div class="bg-animated"></div>
  <form id="form1" runat="server">
    <div class="container py-5">
      <div class="text-center mb-5">
        <img src="https://cdn-icons-png.flaticon.com/512/616/616408.png" width="80" class="mb-3" />
        <h1 class="main-title">Ibarra-Pet</h1>
        <p class="lead text-secondary fw-semibold">Cuidamos a quienes más amas 🐾</p>
      </div>

      <div class="card card-style p-5">
        <h4 class="text-primary fw-bold mb-4">🐶 Datos de la Mascota</h4>
        <div class="row g-4">
          <div class="col-md-6">
            <label class="form-label">Nombre</label>
            <asp:TextBox ID="txtNombreMascota" runat="server" CssClass="form-control" />
          </div>
          <div class="col-md-6">
            <label class="form-label">Raza</label>
            <asp:TextBox ID="txtRaza" runat="server" CssClass="form-control" />
          </div>
          <div class="col-md-6">
            <label class="form-label">Tipo de Mascota</label>
            <asp:DropDownList ID="ddlTipoMascota" runat="server" CssClass="form-select">
              <asp:ListItem Text="Perro" />
              <asp:ListItem Text="Gato" />
              <asp:ListItem Text="Ave" />
              <asp:ListItem Text="Otro" />
            </asp:DropDownList>
          </div>
          <div class="col-md-6">
            <label class="form-label">Fecha de Nacimiento</label>
            <asp:TextBox ID="txtFechaNacMascota" runat="server" TextMode="Date" CssClass="form-control" />
          </div>
          <div class="col-md-6">
            <label class="form-label">Número de Vacunas</label>
            <asp:TextBox ID="txtVacunas" runat="server" TextMode="Number" CssClass="form-control" />
          </div>
        </div>

        <hr class="my-5">
        <h4 class="text-success fw-bold mb-4">🧑 Datos del Dueño</h4>
        <div class="row g-4">
          <div class="col-md-6">
            <label class="form-label">Cédula</label>
            <asp:TextBox ID="txtCedula" runat="server" CssClass="form-control" />
          </div>
          <div class="col-md-6">
            <label class="form-label">Ciudad</label>
            <asp:TextBox ID="txtCiudad" runat="server" CssClass="form-control" />
          </div>
          <div class="col-md-6">
            <label class="form-label">Edad</label>
            <asp:TextBox ID="txtEdad" runat="server" TextMode="Number" CssClass="form-control" />
          </div>
          <div class="col-md-6">
            <label class="form-label">Género</label>
            <asp:DropDownList ID="ddlGenero" runat="server" CssClass="form-select">
              <asp:ListItem Text="Masculino" />
              <asp:ListItem Text="Femenino" />
              <asp:ListItem Text="Otro" />
            </asp:DropDownList>
          </div>
        </div>
       <div class="mt-3">
          <label class="form-label">Tipo de Dueño</label>
          <div class="radio-button-list">
            <asp:RadioButtonList ID="rblTipoDueno" runat="server" RepeatDirection="Horizontal" AutoPostBack="true"
                OnSelectedIndexChanged="rblTipoDueno_SelectedIndexChanged" CssClass="form-check form-check-inline">
                <asp:ListItem Text="Niñ@" Value="nino" />
                <asp:ListItem Text="Hombre" Value="hombre" />
                <asp:ListItem Text="Mujer" Value="mujer" />
            </asp:RadioButtonList>
          </div>
        </div>

        <asp:Panel ID="pnlNino" runat="server" Visible="false" CssClass="mt-4">
          <label class="form-label">Fecha de Nacimiento del Niñ@</label>
          <asp:TextBox ID="txtFechaNacNino" runat="server" TextMode="Date" CssClass="form-control" />
        </asp:Panel>

        <asp:Panel ID="pnlHombre" runat="server" Visible="false" CssClass="row g-3 mt-3">
          <div class="col-md-6">
            <label class="form-label">Número de Mascotas</label>
            <asp:TextBox ID="txtNumMascotas" runat="server" TextMode="Number" CssClass="form-control" />
          </div>
          <div class="col-md-6">
            <label class="form-label">Tipo de Comida</label>
            <asp:DropDownList ID="ddlTipoComida" runat="server" CssClass="form-select">
              <asp:ListItem Text="Preparada" />
              <asp:ListItem Text="Casera" />
            </asp:DropDownList>
          </div>
        </asp:Panel>

        <hr class="my-5">
        <h4 class="text-danger fw-bold mb-4">💊 Enfermedades / Patologías</h4>
        <div class="row g-4">
          <div class="col-md-6">
            <label class="form-label">Nombre</label>
            <asp:TextBox ID="txtNombreEnfermedad" runat="server" placeholder="Ej. Parvovirus" CssClass="form-control" />
          </div>
          <div class="col-md-6">
            <label class="form-label">Descripción</label>
            <asp:TextBox ID="txtDescripcionEnfermedad" runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control" />
          </div>
        </div>

        <div class="mt-5 d-grid gap-3">
          <asp:Button ID="btnRegistrar" runat="server" Text="💾 Registrar Mascota y Dueño" CssClass="btn-gradient" OnClick="btnRegistrar_Click" />
          <asp:Button ID="btnAgregarEnfermedad" runat="server" Text="➕ Agregar Enfermedad" CssClass="btn-gradient" OnClick="btnAgregarEnfermedad_Click" />
          <asp:Button ID="btnGenerarInforme" runat="server" Text="📄 Generar Historia Clínica" CssClass="btn-gradient" OnClick="btnGenerarInforme_Click" />
          <asp:Button ID="btnLimpiar" runat="server" Text="🧹 Limpiar Formulario" CssClass="btn btn-secondary" OnClick="btnLimpiar_Click" />

        </div>

        <div class="mt-4">
          <asp:Label ID="lblResultado" runat="server" CssClass="text-success fw-semibold" />
          <div class="alert alert-info mt-2">
            <asp:Label ID="lblHistoriaClinica" runat="server" />
          </div>
        </div>
      </div>
    </div>
  </form>
</body>
</html>
