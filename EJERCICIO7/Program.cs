// 7) Calcula la suma de los números pares en un rango especificado por el usuario. 



Console.WriteLine("Ingrese el rango de inicio:");
int desde = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el rango de fin:");
int hasta = int.Parse(Console.ReadLine());

int suma = 0;

for (int i = desde; i <= hasta; i++) 
{
    if (i % 2 ==0 ) 
    {
        suma += i;
    }
}
Console.WriteLine($"La suma de numeros pares en el rango de {desde} a {hasta} es: {suma}");