using Hourglass;

try
{
    Console.Write("Ingrese orden de la matriz: ");
    if (int.TryParse(Console.ReadLine(), out int n))
    {
        var processor = new HourglassProcessor(n);

        processor.DisplayFull();
        processor.DisplayHourglass();
    }
    else
    {
        Console.WriteLine("Entrada no válida. Por favor ingrese un número.");
    }
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error de validación: {ex.Message}");
}