// 12) Verifica si una palabra ingresada por el usuario es un palíndromo. 

Console.WriteLine("Verificar si la palabra es palindromo");
Console.WriteLine("");

Console.Write("Ingrese una palabra: ");
String palabra = Console.ReadLine();


// Convierte la palabra ingresada a mayúsculas para hacer la comparación  sin importar mayúsculas o minúsculas.
string palabraMayusculas = palabra.ToUpper();

// Inicializa una cadena vacía para almacenar la versión invertida de la palabra.
String palabraInvertida = "";


// Itera a través de cada carácter de la palabra en orden inverso y lo concatena a la cadena 'palabraInvertida'.
for (int i = palabra.Length - 1; i>=0; i--) 
{
    palabraInvertida += palabraMayusculas[i];
}

// Verifica si la palabra original y su versión invertida son iguales, lo que indica que la palabra es un palíndromo.
if (palabraMayusculas == palabraInvertida)
{
    Console.WriteLine($"La palabra {palabra} si es palindromo");
}
else 
{
    Console.WriteLine($"La palabra {palabra} no es palindromo");
}

Console.ReadKey();

