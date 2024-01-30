Console.WriteLine("EL MAYOR DE DOS NUMEROS");
int x, y;

Console.WriteLine("Digitar el primer número del 1 al 1000");
x = int.Parse(Console.ReadLine());
Console.WriteLine("Digitar el segundo número del 1 al 1000");
y = int.Parse(Console.ReadLine());

if (x > y)
    {
    Console.WriteLine("\nEl numero {0} es mayor que {1}", x, y); // verdadero
    }
else
    {
    Console.WriteLine("\nEl numero {0} es mayor que {1}", y, x); // falso
    }

Console.WriteLine("\n----->Fin del programa");

//Console.ReadKey(); esto no lo veo tan necesario

int Numero;
Console.Title = "VERIFICANDO NUMEROS PARES";
Console.Write("\nIngrese un numero:");
Numero = int.Parse(Console.ReadLine());
if (Numero < 0)
    {
    Console.Write("\n\tNumero Negativo...Ingrese un numero positivo");
    }
else if (Numero % 2 == 0)
{
    Console.Write("\n\tEl numero (" + Numero + ") es par.");
    if (Numero >= 10 && Numero <= 100)
        {
        Console.Write("\n\tEl numero (" + Numero + ") se encuentra en el rango [10-100]");
        }
    else
        {
        Console.Write("\n\tEl numero (" + Numero + ") NO esta en el rango [10-00]");
        }
} 
else
{
    Console.Write("\n\tEl numero ingresado es impar...");
}

//  tercero

Double a, b, z, w;
Console.Title = "CONDICIONALES";
Console.WriteLine("\tDigitar primer numero:");
a = Double.Parse(Console.ReadLine());

Console.WriteLine("\tDigitar segundo numero:");
b = Double.Parse(Console.ReadLine());
if (a > b)
    {
    z = a + b;
    w = a - b;
    Console.WriteLine("\tMOSTRANDO RESULTADOS");
    Console.WriteLine("\tSUMA: " + z);
    Console.WriteLine("\tRESTA: " + w);
    }
else
    {
    z = a * b;
    if (b == 0)
        {
        Console.WriteLine("\tNo se puede dividir entre CERO");
        }
    else
        {
        w = a / b;
        Console.WriteLine("\tMOSTRANDO RESULTADOS");
        Console.WriteLine("\tMULTIPLICACION: " + z);
        Console.WriteLine("\tDIVISION: " + w);
        }
    }

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
        Console.WriteLine("No hay soluciones reales");
    }
    else
    {
        x1 = (-B + (Math.Sqrt(dis))) / 2 * A;
        x2 = (-B - (Math.Sqrt(dis))) / 2 * A;

        Console.WriteLine("La primera solucion es: " + x1);
        Console.WriteLine("La segunda solucion es: " + x2);
    }
}
else
{
    Console.WriteLine("El coeficiente cuadratico debe ser diferente de cero");
}
