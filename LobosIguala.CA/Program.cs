using LobosIguala.Data;
using LobosIguala.Domain.Entities;

//using (LobosIgualaDbContext db = new LobosIgualaDbContext())
//{
//    db.Database.EnsureCreated();

//}
Console.WriteLine("Hello, World!");

//AgregarHorario();
//AgregarEntrenador();
//AgregarCategoria();
//AgregarRoles();
//AgregarUsuario();
//AgregarAlumno();
//AgregarPago();


















/************************************** METHODS ********** arriba metodos ****** abajo metodo main **************************/


//void AgregarHorario()
//{
//    //1. crear contexto de datos
//    using var db = new LobosIgualaDbContext();
//    //2. Crear nuevo horario
//    Horario nuevo = new Horario
//    {
//        Hora = "20:00 PM"
//    };
//    //3. Agregar al contexto de datos
//    db.Horarios.Add(nuevo);
//    //4. Guardar Cambios en la DB
//    db.SaveChanges();
//    //5. Mensaje de notificacion de usuario
//    Console.WriteLine("Agregado exitosamente!");
//}

//void AgregarEntrenador()
//{
//    using var db = new LobosIgualaDbContext();
//    Entrenador nuevo = new Entrenador
//    {
//        Nombre="David Jahir",
//        Apellidos="Solis Aguilar",
//        Telefono="5542028510"
//    };
//    db.Entrenadores.Add(nuevo);
//    db.SaveChanges();
//    Console.WriteLine("Hecho!");
//}

//void AgregarCategoria()
//{
//    using var db = new LobosIgualaDbContext();
//    Categoria nuevo = new Categoria
//    {
//        Nombre="Juvenil",
//        HorarioId=3,
//        EntrenadorId=3

//    };
//    db.Categorias.Add(nuevo);
//    db.SaveChanges();
//    Console.WriteLine("Hecho!");
//}

//void AgregarRoles()
//{
//    using var db = new LobosIgualaDbContext();
//    Rol nuevo = new Rol
//    {
//        Nombre = "ENTRENADOR",
//        Descripcion = "Acceso con restricciones"
//    };
//    db.Roles.Add(nuevo);
//    db.SaveChanges();
//    Console.WriteLine("Hecho!");
//}

//void AgregarUsuario()
//{
//    using var db = new LobosIgualaDbContext();
//    Usuario nuevo = new Usuario
//    {
//        Nombre = "Bryan Alexis",
//        Apellidos = "Nava Nava",
//        RFC = "XXXXXXXXXX",
//        Correo = "bryanalexis88@gmail.com",
//        Contraseña = "12345",
//        Status = true,
//        Direccion="Av. Vicente Guerrero 24",
//        Colonia="Centro",
//        CodigoPostal="40000",
//        RolId=2

//    };
//    db.Usuarios.Add(nuevo);
//    db.SaveChanges();
//    Console.WriteLine("Hecho!");
//}

//void AgregarAlumno()
//{
//    using var db = new LobosIgualaDbContext();
//    Alumno nuevo = new Alumno
//    {
//        Nombre="Isai",
//        Apellidos="Ramirez Parra",
//        Curp="XXXXXXXXXXXXXXXXXX",
//        FechaDeNacimiento =new DateTime(2000, 09, 15),
//        CategoriaId=3,
//        NombreDelTutor="Arturo",
//        ApellidosDelTutor="Ocampo Solis",
//        Parentesco="Papá",
//        Telefono="5522018599",
//        Direccion="Calle Ignacio Maya 32",
//        Colonia="Centro",
//        CodigoPostal="40000"
        

//    };
//    db.Alumnos.Add(nuevo);
//    db.SaveChanges();
//    Console.WriteLine("Hecho!");

//}

//void AgregarPago()
//{
//    using var db = new LobosIgualaDbContext();
//    Pago nuevo = new Pago
//    {
//        AlumnoId=1,
//        Concepto="Pago de mantenimiento",
//        Importe=150.99M,
//        FechaDePago=new DateTime(2023, 07, 21)
     

//    };
//    db.Pagos.Add(nuevo);
//    db.SaveChanges();
//    Console.WriteLine("Hecho!");
//}