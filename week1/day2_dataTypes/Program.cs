// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese su nombre:");
string username = Console.ReadLine();
Console.WriteLine("Ingrese su edad:");
int age = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese su estatura en centimetros:");
float height = float.Parse(Console.ReadLine());


Console.WriteLine($"Usted se llama {username}, tiene {age} años y mide {height / 100}mts.");
Console.ReadKey();
