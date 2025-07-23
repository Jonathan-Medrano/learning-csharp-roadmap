// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un número:");
int number = int.Parse(Console.ReadLine());

if (number >= 100)
{
    Console.WriteLine("Número muy grande");
    Console.ReadKey();
}
else
{

    switch (number % 2)
    {
        case 0:
            Console.WriteLine("Es Par");
            break;
        case > 0:
            Console.WriteLine("Es Par");
            break;
    }
}