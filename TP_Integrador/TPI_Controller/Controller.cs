using System.Security.Cryptography.X509Certificates;

namespace TPI_Controller
{
    
    public class Controlador
    {
        
        
        List<Comision> comisiones = [];
        List<Plan> planes = [];
        List<Materia> materias = [];
        public Controlador()
        {

            

            

            comisiones.Add(new Comision(1, "1K01", 1));
            comisiones.Add(new Comision(2, "1K02", 1));
            comisiones.Add(new Comision(3, "1K03", 1));
            comisiones.Add(new Comision(4, "1C03", 2));
            comisiones.Add(new Comision(5, "1C03", 2));
            comisiones.Add(new Comision(6, "1C03", 3));
            // ID COMISION, NOMBRE COMISION, ID PLAN (puede hacer referencia a plan 2008 sistemas, 2023 sistemas, 2008 civil, etc...)

            planes.Add(new Plan(1, 2008, 1));
            planes.Add(new Plan(2, 2008, 2));
            planes.Add(new Plan(3, 2008, 3));
            planes.Add(new Plan(4, 2008, 4));
            planes.Add(new Plan(5, 2008, 5));
            planes.Add(new Plan(6, 2023, 1));
            planes.Add(new Plan(7, 2023, 2));
            planes.Add(new Plan(8, 2023, 3));
            // especialidad id no incluida en su clase aun

            materias.Add(new Materia(1, 4, 200, 1));
            materias.Add(new Materia(2, 4, 200, 1));
            materias.Add(new Materia(3, 3, 170, 7));
            materias.Add(new Materia(4, 8, 400, 3));
            materias.Add(new Materia(5, 5, 300, 4));
            materias.Add(new Materia(6, 6, 300, 2));
            materias.Add(new Materia(7, 8, 400, 2));
        }
        
        //0: Usuario Incorrecto 1: Validacion Correcta 2: Constraseña incorrecta

        

        



        public bool AddComision(int comId, string comNombre, int planId)
        {
            try
            {
                comisiones.Add(new Comision(comId, comNombre, planId));
            }
            catch (Exception ex)
            {
                // log ex?
                return false;
            }
            return true;
        }
        static void Main() { }
    }

    
}