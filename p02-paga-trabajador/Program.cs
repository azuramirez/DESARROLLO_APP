//Cálcula la paga de un trabajador, considerando las horas extra
string nombre="";
int horas, hextra=0;
float paga, pagaextra=0, pagabruta, paganeta, impuesto, tasa;

Console.Clear();

//Entrada
Console.WriteLine("Calculando la paga de un trabajador \n");
Console.Write("Nombre ? "); 
nombre = Console.ReadLine();
Console.Write("Horas trabajadas ? "); 
horas = int.Parse(Console.ReadLine());
Console.Write("Paga por hora ? "); 
paga = float.Parse(Console.ReadLine());
tasa = 0.03f;

//Cálculos
if(horas>40) {
    hextra = horas - 40;
    pagaextra = 2*paga*hextra;
    pagabruta = 40 * paga + (pagaextra);
} else
    pagabruta = horas * paga;

impuesto = pagabruta * tasa;
paganeta = pagabruta - impuesto;

//Salida
Console.WriteLine($"Resumen de pagos del trabajador {nombre}: \n");
Console.WriteLine($"Horas trabajadas {horas} de las cuales {hextra} son extra, paga {paga}, se asume una tasa de impuesto de {tasa:p2}");
Console.WriteLine($"Paga extra: {pagaextra,12:c2}");
Console.WriteLine($"Paga bruta: {pagabruta,12:c2}");
Console.WriteLine($"Impuesto: {impuesto,12:c2}");
Console.WriteLine($"Paga neta: {paganeta,12:c2}");
