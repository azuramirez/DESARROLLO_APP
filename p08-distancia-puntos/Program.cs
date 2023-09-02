//Calcular la distancia entre dos puntos, dadas las coordenadas del punto A y el punto B

double ax=0, ay=0, bx=0, by=0;
double distancia=0;

Console.Write("Coordenada ax ? "); 
ax = double.Parse(Console.ReadLine());
Console.Write("Coordenada ay ? "); 
ay = double.Parse(Console.ReadLine());
Console.Write("Coordenada bx ? "); 
bx = double.Parse(Console.ReadLine());
Console.Write("Coordenada by ? "); 
by = double.Parse(Console.ReadLine());

distancia=Math.Sqrt((Math.Pow((ax-bx),2))+(Math.Pow((ay-by),2)));

Console.WriteLine($"La distancia entre los dos puntos es: {distancia:f3}");