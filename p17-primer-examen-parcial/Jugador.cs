public class Jugador {
    public string Nombre {get; set;}
    public int AñoNac {get; set;}
    public string Sexo {get; set;}
    public bool Becado {get; set;}

    public List<Categoria> Categorias {get; set;}

    public Jugador() => Categorias = new List<Categoria>();
    public Jugador(string nombre,int añonac,string sexo,bool becado) : this() => (Nombre,AñoNac,Sexo,Becado) = (nombre,añonac,sexo,becado);

    public void AgregarCategoria(Categoria categoria) => Categorias.Add(categoria);

    public double SubTotal() {
        double total=0;
        foreach(Categoria categoria in Categorias)
          total = total + categoria.Total;
        return total;
    }

    public override string ToString() => $"Nombre: {Nombre,-20} AñoNac: {AñoNac,5} Sexo: {Sexo,-30} Becado: {Becado,10}";
    
}