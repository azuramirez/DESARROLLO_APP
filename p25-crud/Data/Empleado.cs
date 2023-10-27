using System.ComponentModel.DataAnnotations;
public class Empleado {
    [Key]
    public int Id {get; set;}
    [Required]
    [MinLength(3), MaxLength(35)]
    public string Nombre {get; set;}
    [RegularExpression(@"[ÑA-Z]{3,4}[0-9]{6}[0-9A-Z]{3}$")]
    public string Rfc {get; set;}
    [Range(18,35)]
    public int Edad {get; set;}
    public string Genero {get; set;}
    [EmailAddress]
    public string Correo {get; set;}
    public double Salario {get; set;}
}