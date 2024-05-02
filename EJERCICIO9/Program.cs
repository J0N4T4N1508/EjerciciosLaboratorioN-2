// 9) Cuenta el número de vocales en una cadena de texto. 



//string cadena = "Estructura de Datos";
//string vocales = "aeiou";

//int total = 0;

//for (int i = 0; i < vocales.Length  ; i++) 
//{
//    char caracter = cadena[i];
//    int contar = cadena.Count(caracter);

//}

//Console.WriteLine(total);
using System;

class Program
{
    static void Main()
    {
        string cadena = "Estructura de Datos";
        string vocales = "aeiou";

        int total = 0;

        // Iterar sobre cada vocal en la cadena de vocales
        foreach (char vocal in vocales)
        {
            // Contar cuántas veces aparece la vocal en la cadena
            int contar = ContarCaracteres(cadena, vocal);
            // Incrementar el total de vocales
            total += contar;
        }

        Console.WriteLine($"El número total de vocales en la cadena es: {total}");
    }

    // Función para contar cuántas veces aparece un carácter en una cadena
    static int ContarCaracteres(string cadena, char caracter)
    {
        int contador = 0;
        foreach (char c in cadena)
        {
            if (char.ToLower(c) == char.ToLower(caracter))
            {
                contador++;
            }
        }
        return contador;
    }
}