// 1) Realiza la suma, resta, multiplicación y división de dos números ingresados por el usuario. 

Console.WriteLine("Ingrese el primer número:");
int num_uno = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número:");
int num_dos = int.Parse(Console.ReadLine());

var suma = num_uno + num_dos;
var resta = num_uno - num_dos;
var multiplicacion = num_uno * num_dos;
var division = num_uno / num_dos;

Console.WriteLine($"La suma de {num_uno} + {num_dos} es: {suma}");
Console.WriteLine($"La resta de {num_uno} - {num_dos} es: {resta}");
Console.WriteLine($"La multiplicacion de {num_uno} * {num_dos} es: {multiplicacion}");
Console.WriteLine($"La division de {num_uno} / {num_dos} es: {division}");