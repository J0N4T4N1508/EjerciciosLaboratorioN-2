// 1) Realiza la suma, resta, multiplicación y división de dos números ingresados por el usuario. 

Console.WriteLine("Operaciones basicas con dos numeros");

Console.Write("Ingrese el primer número:");
int num_uno = int.Parse(Console.ReadLine());

Console.Write("Ingrese el segundo número:");
int num_dos = int.Parse(Console.ReadLine());

// Comprobar si el segundo número es cero y pedir un nuevo número si es así
while (num_dos == 0) 
{
    Console.WriteLine("El segundo número no puede ser cero. Inténtelo de nuevo.");
    Console.WriteLine("Ingrese el segundo número:");
    num_dos = int.Parse(Console.ReadLine());

}
// Si el segundo número es diferente de cero, realizar cálculos
if (num_dos != 0) 
{
    var suma = num_uno + num_dos;
    var resta = num_uno - num_dos;
    var multiplicacion = num_uno * num_dos;
    var division = (float)num_uno / num_dos; // Convertimos uno de los números a float para obtener el resultado decimal



    Console.WriteLine($"La suma de {num_uno} + {num_dos} es: {suma}");
    Console.WriteLine($"La resta de {num_uno} - {num_dos} es: {resta}");
    Console.WriteLine($"La multiplicación de {num_uno} X {num_dos} es: {multiplicacion}");
    Console.WriteLine($"La división de {num_uno} / {num_dos} es: {division}");
    Console.ReadKey();
}





    
