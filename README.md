# 🏀 Backend - Marcador de Baloncesto

Este backend está desarrollado en **.NET 8 (ASP.NET Core Web API)** con **Entity Framework Core** y persistencia en **MySQL**.  
Se encarga de almacenar y exponer información de los partidos jugados a través de una API REST.

---

## 🚀 Endpoints principales

- **GET** `/api/partidos`  
  Devuelve la lista de todos los partidos guardados.

- **GET** `/api/partidos/{id}`  
  Devuelve un partido específico por su ID.

- **POST** `/api/partidos`  
  Crea un nuevo partido en la base de datos.  
  Ejemplo de cuerpo de la petición:

```json
  {
    "equipoLocal": "Lakers",
    "equipoVisitante": "Heat",
    "puntosLocal": 80,
    "puntosVisitante": 75,
    "faltasLocal": 10,
    "faltasVisitante": 8,
    "cuarto": 4,
    "estado": "Finalizado"
  }
```


- PUT /api/partidos/{id}
Actualiza un partido existente.

- DELETE /api/partidos/{id}
Elimina un partido de la base de datos.







# 📚 Descripción de las clases principales

## 1. Partido

- Ubicación: Models/Partido.cs

- Función: Modelo de datos que representa un partido.

### Campos:

- Id: Identificador único.
- EquipoLocal, EquipoVisitante: Nombres de los equipos.
- PuntosLocal, PuntosVisitante: Marcador.
- FaltasLocal, FaltasVisitante: Estadísticas de faltas.
- Cuarto: Número de cuarto actual.
- Estado: Estado del partido (En curso o Finalizado).
- Fecha: Fecha de creación del partido.

## 2. MarcadorContext

- Ubicación: Data/MarcadorContext.cs

- Función: Contexto de Entity Framework Core.
Gestiona la conexión con la base de datos MySQL.

### DbSets:

DbSet<Partido> Partidos: Representa la tabla de partidos en la BD.

## 3. PartidosController

- Ubicación: Controllers/PartidosController.cs

- Función: Controlador REST que expone los endpoints para gestionar partidos.

### Métodos:

- Get() → Devuelve todos los partidos.

- GetById(int id) → Devuelve un partido específico.

- Post(Partido partido) → Crea un nuevo partido.

- Put(int id, Partido partido) → Actualiza un partido.

- Delete(int id) → Elimina un partido.

### 4. Program.cs

- Función: Archivo principal de configuración del proyecto.

- Responsabilidades:

- Configura DbContext con MySQL.

- Habilita Swagger para probar la API.

- Configura los controladores y mapea rutas.


# ✅ Checklist de Backend

- Modelo Partido creado.

- Contexto MarcadorContext con MySQL.

- Controlador PartidosController con CRUD completo.

- Configuración en Program.cs para Swagger y EF Core.

-  API funcionando en http://localhost:5180/api/partidos.

# Flujo de uso

El frontend juega el partido (manejo de puntos, faltas, cuartos, estado).

Al presionar Guardar Partido, el frontend hace un POST al backend.

El backend guarda el partido en MySQL.

Los partidos pueden consultarse desde Swagger o mediante GET /api/partidos.