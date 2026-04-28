# 🎥 CineTrujillo – Sistema de Venta de Entradas de Cine

CineTrujillo es una solución web completa para la venta de entradas de cine, desarrollada con ASP.NET Core MVC + Web API + MySQL.

El sistema permite a los usuarios explorar películas, seleccionar funciones, elegir asientos en tiempo real y realizar compras con confirmación tipo ticket.

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
- ⚡ Consumo de API REST

---

🧱 Arquitectura del Sistema

[ Cliente Web (MVC) ]  --->  [ API REST ]  --->  [ Base de Datos MySQL ]
        (Views)               (Controllers)         (Entity Framework)

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

🔹 🔧 API – CineTrujilloAPI

```
CineTrujilloAPI/
│── Controllers/
│   ├── AsientosController.cs
│   ├── CompraController.cs
│   ├── FuncionesController.cs
│   ├── PeliculaController.cs
│   └── UsuarioController.cs
│
│── Data/
│   └── CineDbContext.cs
│
│── DTOs/
│   ├── CompraDto.cs
│   ├── CompraResponseDto.cs
│   ├── LoginDto.cs
│   ├── PeliculaDto.cs
│   └── RegistroDto.cs
│
│── Models/
│   ├── Asiento.cs
│   ├── Compra.cs
│   ├── DetalleCompra.cs
│   ├── Funcion.cs
│   ├── Pelicula.cs
│   └── Usuario.cs
│
│── Services/
│   ├── CompraService.cs
│   ├── PeliculaService.cs
│   └── UsuarioService.cs

```
🔹 🌐 Web – CineTrujilloWeb

```
CineTrujilloWeb/
│── Controllers/
│   ├── HomeController.cs
│   ├── CompraController.cs
│   └── UsuarioController.cs
│
│── Models/
│   ├── Asiento.cs
│   ├── CompraDto.cs
│   ├── CompraViewModel.cs
│   ├── Funcion.cs
│   ├── Pelicula.cs
│   ├── UsuarioLoginModel.cs
│   ├── UsuarioRegisterModel.cs
│   └── UsuarioResponse.cs
│
│── Services/
│   └── ApiService.cs
│
│── Views/
│   ├── Home/
│   ├── Compra/
│   ├── Usuario/
│   └── Shared/

```

---

## ⚙️ Configuración del Proyecto

### 1 Clonar el repositorio
```
https://github.com/BannerAlfredo/CineTrujillo.git
```
### 2. Crear  Actualizar la base de datos
SQL: Creamos la base de datos
```bash
CREATE DATABASE CineTrujilloDB;
USE CineTrujilloDB;
```

### 3. Configura la cadena de conexión

Edita el archivo `appsettings.json` en `CineTrujilloApi`:

```json
"ConnectionStrings": {
  "DefaulConnection": "Data Source=BANNER;Initial Catalog=My_Firts_Api;Integrated Security=True;Pooling=False;Encrypt=False;Trust Server Certificate=False"
},
```

### 4. Aplica las migraciones

```bash
Add-Migration
```

VISUAL STUDIO 2022: Ingresamos a Herramientas, administrador de paquetes NuGut, Consola de Administrador de paquetes luego ingresamos
```bash
Update-Database
```

### 5. Ejecuta la aplicación

```bash
Ejecutamos nuevo perfil
```

---
🔄 Flujo del Sistema

- Usuario inicia sesión
- Selecciona película
- Elige función
- Selecciona asientos
- Confirma compra
- Se genera la compra
- Visualiza en "Mis Compras"

---
## 📈 Mejoras futuras:
- Detalle de peliculas
- Ticket de compra
- Agregar validaciones (Descuentos, ofertas entre otrso)

---

## 🧑‍💻 Autor

Desarrollado por Banner Rodriguez - BRAYAN GUEVARA RUIZ

---

## 📄 Licencia

Este proyecto está bajo la licencia MIT.

---
