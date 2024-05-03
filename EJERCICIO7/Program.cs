// 7) Calcula la suma de los números pares en un rango especificado por el usuario. 


Console.WriteLine("calcular la suma de numeros pares ");
Console.WriteLine("");

// Solicita al usuario que ingrese un  rango especifico.
Console.Write("Ingrese el rango de inicio: ");
int desde = int.Parse(Console.ReadLine());
Console.Write("Ingrese el rango de fin: ");
int hasta = int.Parse(Console.ReadLine());

// Inicializa una variable para almacenar la suma de los números pares en el rango especificado.
int suma = 0;

// Itera a través de cada número en el rango especificado.
for (int i = desde; i <= hasta; i++) 
{
    if (i % 2 ==0 ) 
    {
        suma += i;
    }
}

Console.WriteLine($"La suma de numeros pares en el rango de {desde} a {hasta} es: {suma}");
Console.ReadKey();



