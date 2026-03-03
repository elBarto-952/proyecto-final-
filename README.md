Proyecto Promedio de Estudiantes

## Integrantes
- Darwin Mesa Gomez
- Juan Sebastian Hurtado Mejia

---

## Descripción del problema
Los estudiantes necesitan conocer si aprobaron o no una materia según sus calificaciones. 
Este programa permite ingresar tres notas de un estudiante, calcular el promedio automáticamente y mostrar si aprobó o reprobó según el resultado obtenido.

---

## IPO (Entrada - Proceso - Salida)

| Entrada | Proceso | Salida |
|----------|---------|---------|
| Nombre del estudiante | Suma de notas | Nombre |
| Nota 1 | Cálculo del promedio | Promedio |
| Nota 2 | División entre 3 | Estado (Aprobó/Reprobó) |
| Nota 3 | | |

---

## Variables

| Variable | Tipo | Propósito |
|-----------|------|-----------|
| nombre | string | Guardar nombre del estudiante |
| nota1 | double | Primera nota |
| nota2 | double | Segunda nota |
| nota3 | double | Tercera nota |
| promedio | double | Resultado del promedio |

---

## Casos de prueba

### Caso normal
Entrada:
Notas: 4.0, 3.5, 3.0  

Salida:
Promedio: 3.5  
Aprobó

---

### Caso borde
Entrada:
Notas: 2.0, 2.5, 2.9  

Salida:
Promedio: 2.46  
Reprobó

---

## Instrucciones para compilar y ejecutar

1. Abrir la terminal en la carpeta del proyecto
2. Crear proyecto consola:
