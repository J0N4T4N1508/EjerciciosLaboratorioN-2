// 3) Pide la base y la altura de un triángulo al usuario y calcula su área. 
Console.WriteLine("Ingrese la base del triangulo");
int BASE = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la altura del triangulo");
int ALTURA =int.Parse(Console.ReadLine());

var area = (BASE * ALTURA) / 2;

Console.WriteLine($"El area del triangulo es: {area}");