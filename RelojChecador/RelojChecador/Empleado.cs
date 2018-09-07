using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelojChecador
{
     class Empleado : Persona
    {
        public enum Turno { M, V, N };
        public Turno turno;
        public enum Puesto { intendecia, maestro, asistente, rector, velador};
        public Puesto puesto;
        public Empleado()
        {

        }
        public Empleado(string nom, string emp, string cel, Turno t, Puesto p = Puesto.maestro)
        {
            this.nombre = nom;
            this.empleado = emp;
            this.celular = emp;
            this.turno = t;
            this.puesto = p;
        }

        public bool nuevo(Turno t, Puesto p = Puesto.maestro)
        {
            bool res = false;
            try
            {
                Console.WriteLine("Ingrese el tuno: ");
                string turno = t.ToString();
                turno = Console.ReadLine();
                Console.WriteLine("Ingrese el puesto: ");
                string puesto = p.ToString();
                puesto = Console.ReadLine();


            }
            catch (Exception ex)
            {
                Console.WriteLine("No fue posible realizar el registro: "+ex.Message);
            }
            return res;
        }
        public bool modificar (Turno t, Puesto p)
        {
            bool res = false;
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine("No fue posible modificar el registro: "+ex.Message);
            }

            return res;
        }
        //public Empleado consulta (string criterio)
        //{
        //    Empleado empleado ;
        //    Console.WriteLine("Ingrese el número de empleado: ");
        //    criterio = Console.ReadLine();
            

        //    return empleado;
        //}
    }
}
