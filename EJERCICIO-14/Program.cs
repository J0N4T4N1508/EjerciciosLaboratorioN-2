// 14) Pide el radio de un círculo al usuario y calcula su área. 

Console.WriteLine("Cálculo del Área de un Círculo");
Console.WriteLine("");

Console.Write("Ingrese la radio: ");
int radio = int.Parse(Console.ReadLine());

double pi = 3.14;
double area = pi * Math.Pow(radio,2);

Console.Write($"El area del circulo es: {area}");
Console.ReadKey();

