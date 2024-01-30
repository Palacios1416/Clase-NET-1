//Ejercicios principales

Double precio, descuento, preciofinal;
Console.WriteLine("DESCUENTO");
Console.WriteLine("Ingrese el precio del producto: ");
precio = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el descuento del producto: ");
descuento = double.Parse(Console.ReadLine());

preciofinal = precio - (precio * (descuento/100));
Console.WriteLine("El precio con descuento es: "+ preciofinal);

/////////////////////////////////////////////

Double lado1, lado2, area, perimetro;
Console.WriteLine("RECTANGULO");
Console.WriteLine("Ingrese el tamaño del lado 1 del rectangulo");
lado1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el tamaño del lado 2 del rectangulo");
lado2 = double.Parse(Console.ReadLine());

perimetro = lado1 + lado2;
area = lado1 * lado2;
Console.WriteLine("El perimetro es: "+ perimetro);
Console.WriteLine("El area es: " + area);

//////////////////////////////////////////////

Double CantDolares, Euros;
Console.WriteLine("DOLARES A EUROS");
Console.WriteLine("Ingrese la cantidad de dolares: ");
CantDolares = double.Parse(Console.ReadLine());

Euros = 1.33250 * CantDolares;

Console.WriteLine("Convertidos a euros es: "+ Euros);

////////////////////////////////////////////

Double Radio, Area, Volumen, Perimetro;
const double pi = 3.1416;
Console.WriteLine("EJERCICIO DE PI");
Console.WriteLine("Ingrese el radio: ");
Radio = double.Parse(Console.ReadLine());

Area = pi * Radio*2;
Perimetro = 2 * pi * Radio;
Volumen = (4 * (pi) * Radio * 3) / 3;

Console.WriteLine("El area es: "+Area);
Console.WriteLine("El perimetro es: " + Perimetro);
Console.WriteLine("El volumen es: " + Volumen);
