// 6) Toma una cadena de texto y muestra su inversión.

Console.WriteLine("Inversión de Cadena");

String cadena = "sistemas";
String cadenaInvertida = "";

// Itera a través de la cadena original en orden inverso.
for (int i = cadena.Length - 1;i >=0; i--) 
{
    // Concatena cada carácter de la cadena original en orden inverso a la cadena invertida.
    cadenaInvertida += cadena[i];
}

Console.WriteLine($"La cadena invertida de {cadena} es: {cadenaInvertida}");
Console.ReadKey();

