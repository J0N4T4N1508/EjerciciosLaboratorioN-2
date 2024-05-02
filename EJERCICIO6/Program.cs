// 6) Toma una cadena de texto y muestra su inversión.

String cadena = "sistemas";
String cadenaInvertida = "";

for (int i = cadena.Length - 1;i >=0; i--) 
{
    cadenaInvertida += cadena[i];
}
Console.WriteLine($"La cadena invertida de {cadena} es: {cadenaInvertida}.");
