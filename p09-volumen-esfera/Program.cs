//Calcular el volumen de la esfera, dado el radio de un circulo

double radio=0;
double volumen=0;

Console.Write("Radio ? ");
radio = double.Parse(Console.ReadLine());

volumen = ((double)4/3)*(Math.PI)*(Math.Pow(radio,3));

Console.WriteLine($"El volumen de la esfera es: {volumen:f3}");

