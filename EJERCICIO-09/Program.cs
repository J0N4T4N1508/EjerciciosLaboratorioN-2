// 9) Cuenta el número de vocales en una cadena de texto. 

Console.WriteLine("Contador de Vocales");
Console.WriteLine("");

String cadena = "Estructura de datos";

// Definimos una lista de las vocales tanto mayúsculas como minúsculas.
List<char> vocales = new List<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

// Variable para almacenar el total de vocales encontradas en la cadena.
int total = 0;

foreach (char caracter in cadena ) 
{
    // Verifica si el carácter actual es una vocal, comparándolo con los elementos de la lista 'vocales'.
    if (vocales.Contains(caracter)) 
    {
        total++;
    }
}

Console.WriteLine($"El total de vocales en la cadena {cadena} es : {total}");
Console.ReadKey();

