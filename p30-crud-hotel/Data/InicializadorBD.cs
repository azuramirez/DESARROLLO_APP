public class InicializadorBD {
    public static void Inicializar(ContextoDatos contexto) {
        if(contexto.Clientes.Any()) {
            return;
        }

        var clientes = new List<Cliente> {
            new Cliente { Nombre = "Rosario", Apellido = "Correa", Genero='M', FechaCumple = DateTime.Parse("1971-12-01"), Correo="chayo@msn.com", Telefono="4923456786", Edad=51},
            new Cliente { Nombre = "Carlos", Apellido = "Gonzalez", Genero='H', FechaCumple = DateTime.Parse("1975-05-05"), Correo="charly@gmail.com", Telefono="4941245677", Edad=48},
            new Cliente { Nombre = "Miroslava", Apellido = "Aguirre", Genero='M', FechaCumple = DateTime.Parse("1981-04-03"), Correo="mirosag@yahoo.com.mx", Telefono="4441234567", Edad=42},
            new Cliente { Nombre = "Fatima", Apellido = "Delgado", Genero='M', FechaCumple = DateTime.Parse("2000-04-04"), Correo="fdelgado@bimbo.com.mx", Telefono="4921063456", Edad=23},
            new Cliente { Nombre = "Leonardo", Apellido = "Ovalle", Genero='H', FechaCumple = DateTime.Parse("1999-08-08"), Correo="ovalleleo@gmc.com.mx", Telefono="4941245677", Edad=24},
            new Cliente { Nombre = "Hector", Apellido = "Ramirez", Genero='H', FechaCumple = DateTime.Parse("1959-10-11"), Correo="hramirez@gmail.com", Telefono="4923456786", Edad=64},
            new Cliente { Nombre = "Carlos", Apellido = "Ramirez", Genero='H', FechaCumple = DateTime.Parse("1971-12-02"), Correo="castr@uaz.edu.mx", Telefono="4928920917", Edad=51},
        }; 
        contexto.Clientes.AddRange(clientes); 
        contexto.SaveChanges();

        var habitaciones = new List<Habitacion> {
            new Habitacion {HabitacionId=1, NoHab=12, Tipo="Individual", Piso=1, Costo=1234.00},
            new Habitacion {HabitacionId=2, NoHab=5, Tipo="Doble", Piso=2, Costo=2500.00},
            new Habitacion {HabitacionId=3, NoHab=7, Tipo="Triple", Piso=2, Costo=2800.00},
            new Habitacion {HabitacionId=4, NoHab=10, Tipo="Individual", Piso=4, Costo=1500.00},
            new Habitacion {HabitacionId=5, NoHab=8, Tipo="Doble", Piso=1, Costo=2464.00},
            new Habitacion {HabitacionId=6, NoHab=15, Tipo="Triple", Piso=2, Costo=3200.00},
            
        };
        contexto.Habitaciones.AddRange(habitaciones);
        contexto.SaveChanges();

        var reservaciones = new List<Reservacion> {
            new Reservacion { ClienteId = clientes.Single(s => s.Apellido == "Correa").Id, HabitacionId = habitaciones.Single(c => c.Tipo == "Individual" ).HabitacionId, InicioReserva = DateTime.Parse("2022-10-11"), FinReserva = DateTime.Parse("2022-10-12")},
            new Reservacion { ClienteId = clientes.Single(s => s.Apellido == "Gonzalez").Id, HabitacionId = habitaciones.Single(c => c.Tipo == "Doble" ).HabitacionId, InicioReserva = DateTime.Parse("2021-05-05"), FinReserva = DateTime.Parse("2021-05-08")},
            new Reservacion { ClienteId = clientes.Single(s => s.Apellido == "Ramirez").Id, HabitacionId = habitaciones.Single(c => c.Tipo == "Triple" ).HabitacionId, InicioReserva = DateTime.Parse("2022-04-01"), FinReserva = DateTime.Parse("2022-05-01")},
            new Reservacion { ClienteId = clientes.Single(s => s.Apellido == "Ovalle").Id, HabitacionId = habitaciones.Single(c => c.Tipo == "Triple" ).HabitacionId, InicioReserva = DateTime.Parse("2020-04-01"), FinReserva = DateTime.Parse("2020-05-01")},
            new Reservacion { ClienteId = clientes.Single(s => s.Apellido == "Ramirez").Id, HabitacionId = habitaciones.Single(c => c.Tipo == "Triple" ).HabitacionId, InicioReserva = DateTime.Parse("2023-11-04"), FinReserva = DateTime.Parse("2023-11-05")}
        };
            contexto.Reservaciones.AddRange(reservaciones);
            contexto.SaveChanges();
        }
}