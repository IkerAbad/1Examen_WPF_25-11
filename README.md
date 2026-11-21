# 1Examen_WPF_25-11

Primer examen de WPF del ciclo de DAM (noviembre de 2022). Es una aplicación de escritorio con el patrón MVVM para registrar el mantenimiento de equipos informáticos de una oficina.

## Qué hay

- `View/MainPage.xaml` es la pantalla de mantenimiento: código de equipo, fecha, tipo de equipo, código de usuario, observaciones, otro software y responsable, con un botón de buscar.
- `View/Informe.xaml` es la ventana del informe.
- `Model` tiene las clases `Equipos` y `Trabajadores`, y `ViewModel/UserViewModel.cs` conecta los datos con las vistas.

## Cómo abrirlo

Necesita Windows y Visual Studio con la carga de trabajo de escritorio de .NET. Abre `Examen_WPF.sln` y ejecútalo; usa .NET Framework 4.7.2. No lo he compilado desde el entorno en el que escribí este README, así que no puedo garantizar que compile sin tocar nada.

---

# 1Examen_WPF_25-11 (English)

First WPF exam of my DAM vocational course (November 2022). A desktop application using the MVVM pattern to record the maintenance of the computers in an office.

## What's inside

- `View/MainPage.xaml` is the maintenance screen: equipment code, date, equipment type, user code, notes, other software and person in charge, with a search button.
- `View/Informe.xaml` is the report window.
- `Model` holds the `Equipos` and `Trabajadores` classes, and `ViewModel/UserViewModel.cs` connects the data to the views.

## Opening it

It needs Windows and Visual Studio with the .NET desktop workload. Open `Examen_WPF.sln` and run it; it targets .NET Framework 4.7.2. I could not compile it in the environment where I wrote this README, so I can't guarantee it builds untouched.
