// 4)Crea una función que calcule la factorial de un número.

Console.WriteLine("Calculadora de Factorial");
Console.Write("Ingresa un número para calcular su factorial: ");
int numero = int.Parse(Console.ReadLine());

int factorial(int numero) 
{
    int multiplicador = 1;
    for (int i = 1; i <= numero; i++) 
    {
        multiplicador *= i;
    }
    return multiplicador;
}

int f=factorial(numero);
Console.WriteLine($"El factorial del numero {numero} es: {f}");
Console.ReadKey();