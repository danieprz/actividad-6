// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bienvenido, este programa necesita dos números para establecer su suma, resta, multiplicación y división.");
Console.WriteLine("Porfavor, introduzca un número");
var primernumero = Console.ReadLine();
int num1 = int.Parse(primernumero);
Console.WriteLine("Porfavor, introduzca otro número");
var segundonumero = Console.ReadLine();
int num2 = int.Parse(segundonumero);
Suma(num1,num2);
static int Suma(int sumando1, int sumando2)
{
    int resultado = sumando1 + sumando2;
    Console.WriteLine("La suma de " + sumando1 + " y " + sumando2 + " da lugar a: " + resultado);
    return resultado;
}
Resta(num1,num2);
static int Resta(int minuendo, int substraendo)
{
    int resultado = minuendo - substraendo;
    Console.WriteLine("La resta de " + minuendo + " y " + substraendo + " da lugar a: " + resultado);
    return resultado;
}
Producto(num1,num2);
static int Producto(int factor1, int factor2)
{
    int resultado = factor1 * factor2;
    Console.WriteLine("El producto de " + factor1 + " y " + factor2 + " da lugar a: " + resultado);
    return resultado;
}
Division(num1,num2);
static int Division(int dividendo, int divisor)
{
    int resultado = dividendo / divisor;
    Console.WriteLine("La división de " + dividendo + " y " + divisor + " da lugar a: " + resultado);
    return resultado;
}