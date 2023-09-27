public class Categoria {
    public string Nombre {get; set;}
    public string Rango {get; set;}

    public double Cantidad {get; set;}
    public double Costo {get; set;}

    public double Total {
        get {return Cantidad*Costo; }
    }

    public Categoria() {}
    public Categoria(string nombre,string rango,int cantidad,double costo) => (Nombre,Rango,Cantidad,Costo) = (nombre,rango,cantidad,costo);
    public override string ToString() => $"{Nombre,-20}{Rango,-20}{Cantidad,5:f2}{Costo,12:c2}{Total,12:c2}";
}