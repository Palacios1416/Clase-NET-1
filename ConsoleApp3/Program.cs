
// cuarto


Console.WriteLine("PROGRAMA DE ECUACION CUADRATICA");
Double A, B, C, dis, x1, x2;

Console.WriteLine("Ingrese el valor de A: ");
A = Double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el valor de B: ");
B = Double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el valor de C: ");
C = Double.Parse(Console.ReadLine());

dis = (Math.Pow(B, 2) - 4 * A * C);

if (A != 0)
{
    if (dis < 0)
    {
        Console.WriteLine("Tiene raices imaginarias");
    }
    else
    {
        x1 = (-B + (Math.Sqrt(dis))) / 2 * A;
        x2 = (-B - (Math.Sqrt(dis))) / 2 * A;

        Console.WriteLine("X1 = " + Math.Round(x1, 3) + " X2 = " + Math.Round(x2, 3));
        
    }
}
else
{
    Console.WriteLine("El coeficiente cuadratico debe ser diferente de cero");
}




