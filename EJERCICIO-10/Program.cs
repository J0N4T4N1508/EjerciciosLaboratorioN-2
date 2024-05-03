// 10) Genera los primeros 10 números de la serie Fibonacci. 

Console.WriteLine("Números de la Serie Fibonacci");
Console.WriteLine("");

int n = 10; // Número de términos de la serie Fibonacci a generar

// Inicialización de los primeros dos términos de la serie Fibonacci
int a = 0;
int b = 1;

Console.WriteLine("Los primeros " + n + " números de la serie Fibonacci son:");

// Itera para generar y mostrar los primeros 'n' términos de la serie Fibonacci.
for (int i = 0; i < n; i++)
{
    Console.Write(a + " ");

    // Actualiza 'a' y 'b' para generar el siguiente término de la serie Fibonacci.
    int temp = a;
    a = b;
    b = temp + b;
}

Console.ReadKey();

