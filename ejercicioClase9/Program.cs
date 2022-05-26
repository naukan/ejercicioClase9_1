//1)      Pedir al usuario la longitud de un vector
//2)      Crear el vector del tamaño ingresado.
//3)      Llenar el mismo con datos aleatorios
//4)      Mostrar el vector por pantalla
//5)      Invertir el vector, de manera que el primer elemento quede al último y el útimo en el primero; el segundo en anteúltimo, el anteúltimo en el segundo y así sucesivamente. En otra palabras si el vector es de 5 posiciones y el usuario ingresó: 10, 20, 30, 40, 50, una vez invertido, el vector debe quedar así: 50, 40, 30, 20, 10.
//Se debe usar solo lo visto en clase hasta ahora y no los métodos que trae C# para estas cuestiones. Tampoco se debe crear un vector nuevo o auxiliar para realizar el ejercicio. 
//6)      Mostrar el vector nuevamente.

Console.WriteLine("Ingrese longitud del vector: ");

int longitud = int.Parse(Console.ReadLine());   

int[] vector = new int[longitud];

Random random = new Random();

Console.WriteLine();
Console.WriteLine("Los valores aleatorios son: ");
Console.WriteLine();

for (int i = 0; i < vector.Length; i++)
{
    vector[i] = random.Next(100);
}

foreach (int i in vector)
{
    Console.WriteLine(i);
}

Console.WriteLine();
Console.WriteLine("El orden invertido es: ");
Console.WriteLine();

for (int i = vector.Length - 1; i >= 0; i--)
{
    Console.WriteLine(vector[i]);
}
