// 15) Toma un número entero y calcula la suma de sus dígitos.

Console.WriteLine("Suma de Dígitos");
Console.WriteLine("");

Console.Write("Ingrese un número: ");
String numero = Console.ReadLine();


// Inicializa una variable para almacenar la suma de los dígitos del número.
int suma = 0;


// Itera a través de cada carácter en la cadena de texto que representa al número.
foreach (char digito in numero) 
{
    // Convierte cada carácter (dígito) de la cadena a un valor numérico entero.
    int convertir = int.Parse(digito.ToString()); 
    suma += convertir;
}

Console.WriteLine($"La suma de digitos del numero {numero} es: {suma}");
Console.ReadKey();

