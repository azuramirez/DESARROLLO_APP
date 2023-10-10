List<Estudiante> estudiantes = new List<Estudiante>();
estudiantes.Add(new Estudiante("1234","Juan Perez","Principal 123","Zacatecas",'H',21,true,new List<float>{97,92,81,60}));
estudiantes.Add(new Estudiante("2345","Maria Lopez","Principal 126","Fresnillo",'M',22,false,new List<float>{75,84,91,40}));
estudiantes.Add(new Estudiante("5678","Rodrigo Mata","Av Mexico 114","Rio Grande",'H',31,true,new List<float>{66,44,22,55}));
estudiantes.Add(new Estudiante("2356","Miguel Mejia","La Loma 666","Fresnillo",'H',31,true,new List<float>{90,42,71,65}));
estudiantes.Add(new Estudiante("6666","David Monreal","5 de Mayo 23","Rio Grande",'H',41,false,new List<float>{90,80,60,60}));
estudiantes.Add(new Estudiante("1345","Brenda Giron","Av Rayon 12","Zacatecas",'M',22,true,new List<float>{37,52,71,65}));
estudiantes.Add(new Estudiante("2265","Lili Morones","Sierra Madre 23","Rio Grande",'M',45,true,new List<float>{99,88,77,66}));
estudiantes.Add(new Estudiante("999","Bere Diaz","Sierra Madre 34","Fresnillo",'M',25,true,new List<float>{34,22,33,22}));
estudiantes.Add(new Estudiante("888","Rocio Bernal","Calle Amargura 66","Fresnillo",'M',25,true,new List<float>{77,66,33,22}));

Console.WriteLine("\nTodos los estudiantes en el Grupo:");
estudiantes.ForEach(e=>Console.WriteLine(e));
string num = "Fresnillo";
var estnum = (from e in estudiantes where e.Municipio==num select e).ToList();
Console.WriteLine($"\nEstudiantes que son de {num} - {estnum.Count()}");
estnum.ForEach(e=>Console.WriteLine(e));

float prom = 80f;
var estprom = (from e in estudiantes where e.Califs.Average() >= prom orderby e.Nombre select e).ToList();
Console.WriteLine($"\nEstudiantes con promedio >= {prom} - {estprom.Count()}");
estprom.ForEach(e=>Console.WriteLine(e));

var estprom1 = (from e in estudiantes select $"Nombre = {e.Nombre,-18} - Prom = {e.Califs.Average(),5:n2} Becado = {e.Becado}").ToList();
Console.WriteLine("\nLista de alumnos y promedios:");
estprom1.ForEach(e=>Console.WriteLine(e));

Console.WriteLine("\n\nSubtotales:");
var pedades = (from e in estudiantes select e.Edad).Average();
Console.WriteLine($"Promedio de edades = {pedades:n2}");
var pcalifs = (from e in estudiantes select e.Califs.Average()).Average();
Console.WriteLine($"Promedio de promedios = {pcalifs:n2}");
var totm = (from e in estudiantes where e.Sexo=='M' select e).Count();
Console.WriteLine($"Total de Mujeres = {totm}");
var toth = (from e in estudiantes where e.Sexo=='H' select e).Count();
Console.WriteLine($"Total de Hombres = {toth}");
var totb = (from e in estudiantes where e.Becado select e).Count();
Console.WriteLine($"Total de Becados = {totb}");
var totnb = (from e in estudiantes where e.Becado select e).Count();
Console.WriteLine($"Total de No Becados = {totnb}");
var totmb = (from e in estudiantes where e.Becado && e.Sexo=='M' select e).Count();
Console.WriteLine($"Total de Mujeres Becadas = {totmb}");

var gpoest = from e in estudiantes group e by e.Municipio;
Console.WriteLine("\nEstudiantes agrupados por municipio:");
foreach (var gpo in gpoest)
{
    Console.WriteLine($"\n {gpo.Key} : {gpo.Count()}");
    foreach (var est in gpo)
    {
        Console.WriteLine(est);
    }
}