# ProcesoCRUD — Gestor de Artículos (WinForms + Microsoft Access)

Aplicación WinForms de ejemplo para gestión CRUD de artículos usando una base de datos Microsoft Access (`.accdb`).

## Para qué sirve
Permite listar, insertar, actualizar y eliminar artículos almacenados en `bd_aprendizaje.accdb`. Incluye reportes (ReportViewer) y lógica de acceso a datos mediante OLE DB.

## Tecnologías y herramientas
- Visual Studio (recomendado: Visual Studio 2026)
- .NET Framework 4.7.2
- C# 7.3
- Microsoft Access Database Engine (ACE OLEDB)
- Microsoft Reporting (ReportViewer)
- Microsoft SQL Server Types (para soporte de tipos en reportes)

## Paquetes / componentes utilizados
- Microsoft Reporting Services Report Viewer (control de informes WinForms)
- Microsoft SQL Server Types 14.0.314.76

Si necesitas instalarlos desde NuGet (ejemplos):
- Package Manager Console:
  - `Install-Package Microsoft.ReportingServices.ReportViewerControl.Winforms`
  - `Install-Package Microsoft.SqlServer.Types -Version 14.0.314.76`

## Requisitos previos (máquina del desarrollador / usuario)
1. Visual Studio 2026 (o versión compatible).
2. .NET Framework 4.7.2 Developer Pack.
3. Microsoft Access Database Engine Redistributable (instalar la bitness que coincida con la aplicación: `x86` o `x64`).
4. Si usas ReportViewer: instalar paquete ReportViewer o el runtime correspondiente.

## Clonar e instalar el repositorio (pasos)
1. Clonar:
   - `git clone https://github.com/<tu-usuario>/ProcesoCRUD.Presentacion.git`
2. Abrir la solución en Visual Studio:
   - `Archivo → Abrir → Proyecto/Solución` y seleccionar `.sln`.
3. Restaurar paquetes NuGet:
   - `Herramientas → Administrador de paquetes NuGet → Administrar paquetes para la solución` o `Restore` automático al compilar.
4. Añadir o confirmar la base de datos Access:
   - Sitúa `bd_aprendizaje.accdb` en la carpeta del proyecto o en una ruta establecida.
   - En el Explorador de soluciones, selecciona `bd_aprendizaje.accdb` → Propiedades → `Copy to Output Directory` = `Copy if newer` (recomendado).
   - Nota: `.gitignore` del proyecto excluye `*.accdb`. Si quieres versionar la BD, quita la regla correspondiente; cuidado con datos sensibles.
5. Configurar la plataforma:
   - `Project Properties → Build → Platform target` = `x86` o `x64` según el Access Database Engine instalado. Si dudas, usa `x86` y el motor ACE 32-bit.
6. Ejecutar la aplicación:
   - `F5` o `Debug → Iniciar depuración`.

## Configuración de conexión
La aplicación usa `Conexion.cs` para componer la cadena OLE DB. Asegúrate de que:
- El `Provider` coincide con el engine instalado (`Microsoft.ACE.OLEDB.12.0` o `Microsoft.ACE.OLEDB.16.0`).
- La ruta a `bd_aprendizaje.accdb` apunta al fichero en tiempo de ejecución (se recomienda usar `AppDomain.CurrentDomain.BaseDirectory`).

## Solución de problemas comunes
- Error: `El proveedor 'Microsoft.ACE.OLEDB.12.0' no está registrado`:
  - Instala Access Database Engine de la bitness correcta o cambia `Platform target`.
- No aparecen datos después de insertar:
  - Verifica que no estés abriendo una copia distinta de la BD (bin\Debug). Ajusta `Copy to Output Directory`.
  - Comprueba el valor devuelto por los métodos (`Guardar_ar` devuelve `"OK"` o mensaje de error).
- Permisos / integridad referencial:
  - Si `codigo_me` / `codigo_ca` son claves foráneas, asegúrate de que los valores existan en sus tablas.

## Buenas prácticas
- Usar consultas parametrizadas (ya aplicadas en la capa Lógica).
- No versionar la BD si contiene datos sensibles; en su lugar provee un script de creación.
- Mantener la cadena de conexión configurable (app.config) si el proyecto avanza.

## Estructura del proyecto (resumen)
- `ProcesoCRUD.Presentacion` — WinForms (UI)
- `ProcesoCRUD.Presentacion.Logica` — acceso a datos y reglas
- `ProcesoCRUD.Presentacion.Modelo` — clases de modelo
- `Reporte` — definición y formularios de reportes
- `bd_aprendizaje.accdb` — base de datos (no versionada por defecto)

