# 🎥 CineTrujillo – Sistema de Venta de Entradas de Cine

CineTrujillo es un sistema web desarrollado con ASP.NET Core MVC, diseñado para la gestión y venta de entradas de cine en línea.
Permite a los usuarios explorar películas, seleccionar funciones, elegir asientos y realizar compras de forma rápida y sencilla.

Este proyecto está orientado a aprendizaje, práctica profesional y uso real, aplicando arquitectura MVC, consumo de API REST y conexión a base de datos relacional.

---

## 🚀 Características Principales

- 🎬 Visualización de cartelera de películas
- 🕒 Selección de funciones (horario y sala)
- 💺 Selección interactiva de asientos
- 🛒 Proceso de compra paso a paso
- 🔐 Inicio de sesión de usuarios
- 🎟️ Confirmación de compra tipo ticket / FALATA IMPLEMENTAR
- 📊 Historial de compras del usuario
- 🎨 Interfaz moderna y responsive

---

## 🛠️ Tecnologías Utilizadas
| Categoría            | Tecnologías              |
| -------------------- | ------------------------ |
| Lenguaje Backend     | C#                       |
| Framework            | ASP.NET Core MVC         |
| API                  | ASP.NET Core Web API     |
| Base de Datos        | SqlServer                |
| ORM                  | Entity Framework Core    |
| Frontend             | HTML5, CSS3, Bootstrap 5 |
| Arquitectura         | MVC + API REST           |
| IDE                  | Visual Studio 2022       |
| Control de Versiones | Git & GitHub             |

---

## 📂 Estructura del Proyecto

```
VetCenter/
│── Controllers/
│   ├── CitaController.cs
│   ├── ClienteController.cs
│   ├── MascotaController.cs
│   ├── MedicamentoController.cs
│   ├── UsuarioController.cs
│   └── PanelController.cs
│
│── Models/
│   ├── AppDbContext.cs
│   ├── Cita.cs
│   ├── Cliente.cs
│   ├── Mascota.cs
│   ├── Medicamento.cs
│   └── Usuario.cs
│
│── Views/
│   ├── Cita/
│   ├── Cliente/
│   ├── Mascota/
│   ├── Medicamento/
│   ├── Panel/
│   └── Shared/
│
│── wwwroot/
│── appsettings.json
└── Program.cs

```

---

## ⚙️ Configuración del Proyecto

### 1️⃣ Clonar el repositorio
```
git clone https://github.com/BannerRodriguez/vetcenter.git
```

### 2️⃣ Configurar la base de datos

Editar el archivo `appsettings.json:`

```json
"ConnectionStrings": {
  "DefaultConnection": "server=localhost;database=vetcenter;user=root;password=;"
}
```

### 3️⃣ Restaurar dependencias
```
dotnet restore
```

### 4️⃣ Ejecutar el proyecto
```
dotnet run
```

---

## 📈 Mejoras futuras:
- Historial clínico de mascotas
- Notificaciones de citas
- Roles avanzados
- Exportación de reportes

---

## 🧑‍💻 Autor

Desarrollado por Banner Rodriguez

---

## 📄 Licencia

Este proyecto está bajo la licencia MIT.

---
