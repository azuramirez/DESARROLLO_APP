//Numeros en un arreglo

double[] elementos = {100,123,456,222,999,895,325,234,322,988};
double suma1=0;
double suma2=0;

Console.WriteLine($"Mostrar los elementos del arreglo");
Console.WriteLine($"Los elementos del arreglo son : {biblioteca.Imprime1(elementos)}\n");

Console.WriteLine($"Suma de los elementos");
suma1 = biblioteca.Suma1(elementos);
Console.WriteLine($"La suma de las calificaciones es: {suma1:f2}\n");

Console.WriteLine($"Dividir entre 2 cada elemento del arreglo y mostrar la suma");
suma2 = biblioteca.Suma2(elementos);
Console.WriteLine($"La suma de las calificaciones es: {suma2:f2}\n");

Console.WriteLine($"Mostrar los elementos del arreglo en orden inverso");
Console.WriteLine($"Los elementos del arreglo en orden inverso son : {biblioteca.Imprime2(elementos)}\n");




