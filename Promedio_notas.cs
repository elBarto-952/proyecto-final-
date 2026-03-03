using System;

class Proyecto
{
    static void Main()
    {
        // Variables
        string nombre;
        double nota1, nota2, nota3, promedio;

        // Entrada
        Console.Write("Nombre del estudiante: ");
        nombre = Console.ReadLine();

        Console.Write("Nota 1: ");
        nota1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nota 2: ");
        nota2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nota 3: ");
        nota3 = Convert.ToDouble(Console.ReadLine());

        // Proceso
        promedio = (nota1 + nota2 + nota3) / 3;

        // Salida
        Console.WriteLine("\nEstudiante: " + nombre);
        Console.WriteLine("Promedio: " + promedio);

        if (promedio >= 3.0)
            Console.WriteLine("Estado: Aprobó");
        else
            Console.WriteLine("Estado: Reprobó");
    }
}
