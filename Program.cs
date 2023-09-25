// See https://aka.ms/new-console-template for more information
string[] autos = new string[4];

Console.WriteLine("Top best autos");

for (int i = 0; i < 4; i++)
{
    Console.WriteLine($"Geef auto {i + 1}: ");

    autos[i] = Console.ReadLine();

}
Console.WriteLine();
Console.WriteLine("AUTOS:");

PrintArray( autos );


//****************************************************************************

Console.WriteLine("Voeg een andere auto");
string newvalue =  Console.ReadLine();

Array.Resize(ref autos, 5);

autos[4] = newvalue;

PrintArray( autos );



static void PrintArray(string[] autos)
{

    Console.Write("[");

    for (int i = 0; i < autos.Length; i++)
    {
        if (i < autos.Length - 1)
        {
            Console.Write(autos[i] + ", ");
        }
        else
        {
            Console.Write(autos[i] + "]\n");
        }
    }

}
