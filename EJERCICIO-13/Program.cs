// 13) Crea un programa que genere la tabla de multiplicar de un número ingresado por el usuario. 

Console.WriteLine("Generador de Tablas de Multiplicar");
Console.WriteLine("");

Console.Write("Ingrese un número para generar su tabla de multiplicar: ");
int numero = int.Parse(Console.ReadLine());

// Itera para generar la tabla de multiplicar del número ingresado por los  12 primeros números.
for (int i = 1; i <= 12; i++) 
{
    int multiplicar = numero * i;
    Console.WriteLine($"{numero} x {i} = {multiplicar}");
}

Console.ReadKey();

