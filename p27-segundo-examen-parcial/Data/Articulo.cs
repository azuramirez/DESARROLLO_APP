using System.ComponentModel.DataAnnotations;
public class Articulo {
    [Key]
    public int Id {get; set;}
    [Required]
    [MinLength(3), MaxLength(25)]
    public string Descripcion {get; set;}
    [Range(typeof(DateTime),"1/1/2023","31/12/2024")]
    public DateTime FechaAlta {get; set;}
    [Range(1,100)]
    public int Cantidad {get; set;}
    [Range(1,2500)]
    public double Precio {get; set;}
    public string UdeMedida {get; set;}
}