// 5) Verifica si un número ingresado por el usuario es primo o no. 

Console.WriteLine("Verificar si es número primo");
Console.Write("Ingrese un numero: ");
int numero = int.Parse(Console.ReadLine());

int divisores = 0;
for (int i = 1; i <= numero; i++) 
{
    if (numero % i ==0) 
    { 
        divisores++;
    }
}

if (numero > 1 && divisores == 2)
{
    Console.WriteLine($"El numero {numero} es primo");
}
else 
{
    Console.WriteLine($"El numero {numero} no es primo");
}

Console.ReadKey();
