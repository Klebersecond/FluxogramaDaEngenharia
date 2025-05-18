Console.Write("Fluxograma da engenharia");
Console.BackgroundColor = ConsoleColor.Green;
Console.ForegroundColor = ConsoleColor.Black;
Console.ResetColor();

Console.Write($"Está se movendo (S/N)?:");
string estamovendo = Console.ReadLine()!.Trim().ToUpper();

Console.Write("Deveria (S/N) ?:");
string deveria = Console.ReadLine()!.Trim().ToUpper();

if (estamovendo == "S" && deveria == "N")

{
    Console.WriteLine("Use silver tape");
}

else if (estamovendo == "N" && deveria == "S")

{
    Console.WriteLine("Use WD-40");
}

else
{
    Console.WriteLine("Òtimo!");
}




