using LowerTriangularOfMatrix;

Console.Write("Ingrese orden de la matriz: ");
if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
{
    Console.WriteLine($"\nMatriz completa de orden {n}:");

    var processor = new MatrixProcessor(n);

    processor.DisplayFull();

    Console.WriteLine();

    Console.WriteLine($"\nTriangular inferior de la matriz:");
    processor.DisplayLowerTriangular();
}
else
{
    Console.WriteLine("Por favor, ingrese un número entero positivo válido.");
}