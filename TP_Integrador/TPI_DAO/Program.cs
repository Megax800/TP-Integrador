using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace TPI_DAO
{
    public class AcademiaContext : DbContext
    {
        private DbSet<DAOPersona> personas;
        private DbSet<DAOUsuario> usuarios;
        private DbSet<DAOMateria> materias;
        private DbSet<DAOCurso> cursos;
        private DbSet<DAOComision> comisiones;
        private DbSet<DAOEspecialidad> especialidades;
        private DbSet<DAOPlan> planes;

        public DbSet<DAOPersona> Personas { get => personas; set => personas = value; }
        public DbSet<DAOUsuario> Usuarios { get => usuarios; set => usuarios = value; }
        public DbSet<DAOMateria> Materias { get => materias; set => materias = value; }
        public DbSet<DAOCurso> Cursos { get => cursos; set => cursos = value; }
        public DbSet<DAOComision> Comisiones { get => comisiones; set => comisiones = value; }
        public DbSet<DAOEspecialidad> Especialidades { get => especialidades; set => especialidades = value; }
        public DbSet<DAOPlan> Planes { get => planes; set => planes = value; }

        public AcademiaContext()
        {
            this.Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS; Database=Academia; Integrated Security=True; TrustServerCertificate=True");
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
        }

        public static void Main()
        {
            using (var context = new AcademiaContext())
            {
                Console.WriteLine("Creando una persona y subiendola a la base de datos\n\n");
                var per = new DAOPersona();
                per.Nombre = "Carlos";
                per.Apellido = "Perez";
                per.Email = "email";
                per.Direccion = "direccion";
                per.TipoPersona = 3;
                per.IdPlan = 2;
                per.FechaNacimiento = DateTime.Today;
                per.Telefono = "4712920";
                context.Personas.Add(per);
                context.SaveChanges();
            }
        }
    }
}
