using System.ComponentModel.DataAnnotations;

public class Reservacion {
    public int ReservacionId {get; set;}
    public int HabitacionId {get; set;} //llave secundaria relacion muchos a uno, tabla curso
    public int ClienteId {get; set;} //llave secundaria relacion muchos a uno, tabla estudiante

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString="{0:yyyy-MM-dd}", ApplyFormatInEditMode=true)]
    public DateTime InicioReserva {get; set;}

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString="{0:yyyy-MM-dd}", ApplyFormatInEditMode=true)]
    public DateTime FinReserva {get; set;}

    public int DiasReserva => (FinReserva - InicioReserva).Days;
    

    public Habitacion Habitacion {get; set;} //Detalle de la relacion muchos a uno
    public Cliente Cliente {get; set;} //Detalle de la relacion muchos a uno

}