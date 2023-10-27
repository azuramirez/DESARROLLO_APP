using System.ComponentModel.DataAnnotations;
public class Jugador {
    [Key]
    public int Id {get; set;}
    [Required, MinLength(3,ErrorMessage="Minimo 3"), MaxLength(30, ErrorMessage="Maximo 30")]
    public string Nombre {get; set;}
    [Range(typeof(DateTime),"1/1/2000","31/12/2024",ErrorMessage="Solo nacidos 2000-2024")]
    public DateTime FechaNac {get; set;}
    [Range(1,20, ErrorMessage="Numeros disponibles del 1 al 20")]
    public int NoPlayera {get; set;}
    public string Posición {get; set;}
    public int Apariciones {get; set;}
    public int Goles {get; set;}
}