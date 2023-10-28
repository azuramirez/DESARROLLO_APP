using System.ComponentModel.DataAnnotations;
public class Jugador {
    [Key]
    public int Id {get; set;}
    [Required]
    [MinLength(3), MaxLength(30)]
    public string Nombre {get; set;}
    [Range(typeof(DateTime),"1/1/2000","31/12/2024")]
    public DateTime FechaNac {get; set;}
    [Range(1,20)]
    public int NoPlayera {get; set;}
    public string Posicion {get; set;}
    public int Apariciones {get; set;}
    public int Goles {get; set;}
}