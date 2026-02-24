using System;

public class Program
{
    public static void Main()
    {
        string tipoVehiculo;
        int horas;
        bool esFestivo;
        decimal tarifa = 0;
        decimal total;

        // 🔹 Entrada tipo de vehículo
        Console.WriteLine("Ingrese el tipo de vehículo (carro, moto, camioneta):");
        tipoVehiculo = Console.ReadLine().ToLower();

        // 🔹 Validar horas (0 a 24)
        do
        {
            Console.WriteLine("Ingrese la cantidad de horas (0 - 24):");
        }
        while (!int.TryParse(Console.ReadLine(), out horas) || horas < 0 || horas > 24);

        // 🔹 Entrada día festivo
        Console.WriteLine("¿Es día festivo? (true/false):");
        while (!bool.TryParse(Console.ReadLine(), out esFestivo))
        {
            Console.WriteLine("Ingrese solo true o false:");
        }

        // 🔹 Asignar tarifa según tipo de vehículo
        if (tipoVehiculo == "carro")
        {
            tarifa = 3000;
        }
        else if (tipoVehiculo == "moto")
        {
            tarifa = 1500;
        }
        else if (tipoVehiculo == "camioneta")
        {
            tarifa = 4000;
        }
        else
        {
            Console.WriteLine("Tipo de vehículo no válido.");
            return;
        }

        // 🔹 Calcular subtotal
        total = tarifa * horas;

        // 🔹 Aumento por festivo (20%)
        if (esFestivo)
        {
            total += total * 0.20m;
        }

        // 🔹 Descuento por más de 8 horas (10%)
        if (horas > 8)
        {
            total -= total * 0.10m;
        }

        // 🔹 Regla adicional:
        // Si es camioneta Y horas > 12 → recargo adicional 5%
        if (tipoVehiculo == "camioneta" && horas > 12)
        {
            total += total * 0.05m;
        }

        // 🔹 Salida
        Console.WriteLine("=================================");
        Console.WriteLine("Valor total a pagar: $" + total);
        Console.WriteLine("=================================");
    }
}
