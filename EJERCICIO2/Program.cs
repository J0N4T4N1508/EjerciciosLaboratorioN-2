// 2) Solicita un número al usuario y determina si es par o impar. 

Console.WriteLine("Verificación de Número Par o Impar");
Console.WriteLine("Ingrese un número: ");
int numero = int.Parse(Console.ReadLine());


if (numero % 2 == 0)
{
    Console.WriteLine($"El numero {numero} es par.");
}
else
{
    Console.WriteLine($"El numero {numero} es impar.");
}

Console.ReadKey();



