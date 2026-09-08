# MiApiCuadrado

API Web desarrollada en .NET para calcular el cuadrado de un numero entero.

## Endpoint

```text
GET /api/Math/cuadrado/{numero}
```

## Ejemplo

Solicitud:

```text
GET http://localhost:5142/api/Math/cuadrado/5
```

Respuesta:

```text
25
```

## Validacion

La API no acepta numeros negativos.

Ejemplo:

```text
GET /api/Math/cuadrado/-5
```

Respuesta:

```text
El numero debe ser mayor o igual a 0.
```

## Tecnologias

* C#
* .NET
* ASP.NET Core Web API
* Git
* GitHub


///TAREA 3 ACTUALIZADA /08/09/2026 09:56 AM
