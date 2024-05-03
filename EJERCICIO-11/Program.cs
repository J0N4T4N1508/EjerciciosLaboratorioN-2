// 11) Ordena una lista de números ingresados por el usuario de menor a mayor.

Console.WriteLine("Ordenamiento de Lista");
Console.WriteLine("");

// Pedir al usuario que ingrese los números
Console.WriteLine("Ingrese los números separados por espacios:");

// Leer la entrada del usuario y dividirla en números individuales
string entrada = Console.ReadLine();
string[] numerosComoString = entrada.Split(' ');

// Convertir los números de string a int y almacenarlos en una lista
List<int> numeros = new List<int>();
foreach (string numeroString in numerosComoString)
{
    int numero;
    if (int.TryParse(numeroString, out numero))
    {
        numeros.Add(numero);
    }
    else
    {
        Console.WriteLine($"'{numeroString}' no es un número válido y será ignorado.");
    }
}

// Ordenar la lista de números de menor a mayor
numeros.Sort();

// Imprimir la lista ordenada
Console.WriteLine("Números ordenados de menor a mayor:");
foreach (int numero in numeros)
{
    Console.Write(numero + " ");
}

Console.ReadKey();

