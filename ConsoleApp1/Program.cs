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

////// quinto

Console.Title = " El sexo de una persona";
Int32 edad;
String nombre, sexo;
Console.WriteLine("Digitar tu nombre");
nombre = Console.ReadLine();
Console.WriteLine("Digitar tu edad");
edad = Int32.Parse(Console.ReadLine());
Console.WriteLine("Digitar tu sexo ( Hombre=M y Mujer=F )");
sexo = Console.ReadLine();
if (sexo == "M" || sexo == "m") // instruccion lógica OR
{
    Console.WriteLine("\nEl Sr {0} ha sido registrado", nombre); // v
}
else
{
    Console.WriteLine("\nLa Sra {0} ha sido registrada", nombre); // f
}
Console.WriteLine("\n\n");
Console.WriteLine("\n----->Fin del programa");

/////// sexto



int op;
Double X, Y, Z;
Console.WriteLine("\nDigitar el primer numero:");

x = Double.Parse(Console.ReadLine());
Console.WriteLine("\nDigitar el segundo numero:");
y = Double.Parse(Console.ReadLine());
Console.Title = "SWITCH CASE";
Console.WriteLine("\n\tOPERACIONES MATEMATICAS");
Console.WriteLine("\n\t1. SUMAR");
Console.WriteLine("\n\t2. RESTAR");
Console.WriteLine("\n\t3. MULTIPLICAR");
Console.WriteLine("\n\t4. DIVIDIR");
Console.WriteLine("\n\t5. RAIZ CUADRADA");
Console.WriteLine("\n\t6. POTENCIACION");
Console.WriteLine("\n\t7. SALIR DEL PROGRAMA");
Console.WriteLine("\n\n\t Digite su opcion: ");
op = int.Parse(Console.ReadLine());
switch (op)
{
    case 1:
        z = x + y;
        Console.WriteLine("\t El resultado de la suma es: " + z);
        break;
    case 2:
        z = x - y;
        Console.WriteLine("\t El resultado de la resta es: " + z);
        29 break;
        30 case 3:
        31 z = x * y;
        32 Console.WriteLine("\t El resultado de la multiplicacion es: " + z);
        33 break;
        34 case 4:
        35 if (y == 0)
            36 {
            37 Console.WriteLine("\t Division Invalida...");
            38 }
        39 else
            40 {
            41 z = x / y;
            42 Console.WriteLine("\t El resultado de la division es: " + z);
            43 }
        44 break;
        45 case 5:
        46 z = Math.Sqrt(x);
        47 Console.WriteLine("\t La raiz cuadrada del primer numero es " + z);
        48 break;
        49 case 6:
        50 z = Math.Pow(y, 2);
        51 Console.WriteLine("\t El cuadrado del segundo numero es " + z);
        52 break;
        53 case 7:
        54 Environment.Exit(0);
        55 break;
        56 default:
        57 Console.WriteLine("\t Opcion no definida.. intente de nuevo");
        58 break;
        59 }
60 Console.ReadKey();
61 }
62 }
63 }