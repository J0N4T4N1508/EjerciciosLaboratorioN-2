// 8) Crea una lista de los cuadrados de los primeros 10 números naturales. 

Console.WriteLine("Lista de los cuadrados de los primeros 10 números naturales:");

// Crear una lista de los primeros 10 números naturales
List<int> lista = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// Crear una lista para almacenar los cuadrados
List<int> listaCuadrados = new List<int>();

// Iterar sobre los elementos de la lista original y calcular los cuadrados
foreach (int numero in lista)
{
    int cuadrado = numero * numero;
    listaCuadrados.Add(cuadrado);
}



string listaCuadradosString = string.Join(", ", listaCuadrados);
Console.WriteLine(listaCuadradosString);
Console.ReadKey();

