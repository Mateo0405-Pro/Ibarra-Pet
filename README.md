# 🐾 Ibarra-Pet - Sistema de Gestión Veterinaria

Este proyecto es un sistema de gestión clínica veterinaria desarrollado en **C# con ASP.NET Web Forms**, orientado al registro, control y visualización de información médica de mascotas. La aplicación está estructurada con clases organizadas por tipo de entidad, manteniendo una arquitectura limpia, reutilizable y escalable. Es un proyecto académico, ideal como base para implementaciones reales en clínicas veterinarias.

---

## 🚀 Funcionalidades principales

- Registro de mascotas con datos como nombre, raza, tipo (perro, gato, ave, etc.), fecha de nacimiento y número de vacunas.
- Asociación de cada mascota a un dueño, clasificados en:
  - 👶 **Niñ@**: registra fecha de nacimiento y genera obsequio si es su cumpleaños.
  - 👨 **Hombre**: registra número de mascotas y tipo de comida (preparada o casera).
  - 👩 **Mujer**: aplica descuento especial durante el mes de marzo.
- Registro de patologías o enfermedades durante la consulta.
- Generación automática del historial clínico del paciente.
- Interfaz intuitiva con diseño moderno usando **Bootstrap 5** y animaciones personalizadas.

---

## 🧱 Estructura del proyecto

```
Ibarra-Pet/
├── modelo/              # Clases: mascota, dueño, niño, hombre, mujer, enfermedad, historiaClinica
├── vistas/              # Formularios ASPX para la interfaz web
├── App_Data/            # Espacio reservado para base de datos si se desea integrar
└── README.md            # Descripción del proyecto
```


---

## 💻 Tecnologías utilizadas

- C# con ASP.NET Web Forms
- HTML5 + CSS3
- Bootstrap 5.3
- Visual Studio 2022
- Git y GitHub

---

## 📌 Estado del proyecto

✅ Proyecto completo y funcional, con lógica de negocio implementada. Listo para ampliarse con persistencia de datos, login de usuarios y conexión a base de datos real.

---

## 🤝 Autor

Desarrollado por **Mateo Perugachi**  
Proyecto profesional, orientado a demostrar buenas prácticas en el desarrollo web estructurado con C#.

---

