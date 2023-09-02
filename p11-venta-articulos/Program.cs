//venta de articulos

int n=0;
int cantidad=0;
float precio=0;
float subtotal=0;
float total=0;
float iva=0.16f;
float valoriva;
float ivacob=0;
int siniva=0;
char resp;

do{
        Console.Clear();
        Console.Write("Articulos ?");
        n = int.Parse(Console.ReadLine());
        if(n!=000) {
           for(int i=n-1; i>=0; i--){
           Console.Write("\nCantidad ? ");
           cantidad = int.Parse(Console.ReadLine());
           Console.Write("Precio ? ");
           precio = float.Parse(Console.ReadLine());
           subtotal+=cantidad*precio;
        }
        valoriva=0;
        Console.WriteLine($"Subtotal: {subtotal:f2}");
        if(subtotal>=1200){
            Console.WriteLine($"Total de venta: {subtotal:2f}");
            Console.WriteLine($"IVA cobrado: {siniva:2f}");}
                else if(subtotal>=0 && subtotal<=1200) { 
                    valoriva=iva*subtotal;
                    subtotal=valoriva+subtotal;
                    ivacob=valoriva;
                    Console.WriteLine($"Total de venta: {subtotal}");
                    Console.WriteLine($"IVA cobrado: {ivacob}");}
        }
Console.WriteLine("\nDeseas capturar otra venta (S/N) ?");
resp = char.ToUpper(Console.ReadLine()[0]);
}while(resp!='N');
Console.WriteLine("Total de las ventas capturadas");
Console.WriteLine("Total de IVA");