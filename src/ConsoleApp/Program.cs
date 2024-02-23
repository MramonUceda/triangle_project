// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


double ladoA = 10;
double ladoC = 10;
double ladoB = 20;

double altura = 15;


double perimetro = Application.Triangulo.perimetro(ladoA,ladoB,ladoC);
double area = Application.Triangulo.area(ladoB,altura);
double volumen = Application.Triangulo.volumen(area,altura);


Console.WriteLine($"El perímetro de un triangulo de lado A {ladoA}cm, lado B Base {ladoB}cm y lado C {ladoC}cm es de {perimetro}cm");
Console.WriteLine($"El área de un triangulo con base = {ladoB}cm y altura h = {altura}cm es de  {area}cm. ");
Console.WriteLine($"El volumen de un triangulo es de  {volumen}cm. ");
