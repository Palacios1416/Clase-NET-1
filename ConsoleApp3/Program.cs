int Ndia, Nmes, MDA = 0;
Console.WriteLine("CALCULADOR DE DIAS");

Console.WriteLine("Ingrese el dia: ");
Ndia = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el mes: ");
Nmes = int.Parse(Console.ReadLine());
if ((Ndia < 1 || Ndia > 31) || (Nmes < 1 || Nmes > 12))
{
    Console.WriteLine("Los datos introducidos son incorrectos");
}
else
{
    switch (Nmes)
    {
        case 1:
            MDA = Ndia;
            break;
        case 2:
            MDA = Ndia + 31;
            break;
        case 3:
            MDA = Ndia + 59;
            break;
        case 4:
            MDA = Ndia + 90;
            break;
        case 5:
            MDA = Ndia + 120;
            break;
        case 6:
            MDA = Ndia + 151;
            break;
        case 7:
            MDA = Ndia + 181;
            break;
        case 8:
            MDA = Ndia + 212;
            break;
        case 9:
            MDA = Ndia + 243;
            break;
        case 10:
            MDA = Ndia + 273;
            break;
        case 11:
            MDA = Ndia + 304;
            break;
        case 12:
            MDA = Ndia + 334;
            break;

        default:

            break;
    }
    Console.WriteLine("El " + Ndia + " del " + Nmes + " es el dia " + MDA + " del año");
}

