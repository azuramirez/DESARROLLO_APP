//Emitir una calificacion con letra y un mensaje de acuerdo al promedio de un alumno

string nombre;
float promedio=0;

Console.Write("Nombre ? ");
nombre = Console.ReadLine();
Console.Write("Promedio (De 0 a 10)? ");
promedio = float.Parse(Console.ReadLine());

Console.WriteLine($"\nNombre del alumno: {nombre}");
Console.WriteLine("\nPromedio   Letra   Mensaje"); 

if(promedio>=0 && promedio<=5.9){
    Console.WriteLine($"  {promedio}      D       Andas mal "); }
    else if(promedio>=6 && promedio<=7.5) { 
        Console.WriteLine($"  {promedio}      C       Mucho mejor ");}
        else if(promedio>=7.6 && promedio<=8.5) { 
            Console.WriteLine($"  {promedio}      B       Muy bien ");}
            else if(promedio>=8.6 && promedio<=10) { 
                Console.WriteLine($"  {promedio}       A       Excelente ");}   
                else {Console.WriteLine("\nNOTA: Promedio invalido");}
