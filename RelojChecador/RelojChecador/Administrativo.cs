using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelojChecador
{
    class Administrativo : Persona
    {
        public string hEntrada;
        public string hSalida;
        public enum Puesto {SecDeFinanzas, SecRh, secAcademico}
        Puesto puesto;

        public Administrativo()
        {

        }
        public Administrativo (string nom, string emp, string cel, string hE, string hS, Puesto p = Puesto.SecRh)
        {
            this.nombre = nom;
            this.empleado = emp;
            this.celular = cel;
            this.hEntrada = hE;
            this.hSalida = hS;
            this.puesto = p;
        }
        public bool nuevo (Puesto p)
        {
            bool res = false;
            try
            {
                Console.WriteLine("Ingrese hora de entrada: ");
                string puesto = p.ToString();
                puesto = Console.ReadLine();

            }catch (Exception ex)
            {
                Console.WriteLine("No fue posible llevar acabo el registro: "+ex.Message);
            }
            return res;
        }
        public bool modificar (string hE, string hS, Puesto p)
        {
            bool res = false;
            Console.WriteLine("Ingrese la nueva entrada: ");
            hE = Console.ReadLine();
            Console.WriteLine("Ingrese la nueva salida: ");
            hS = Console.ReadLine();
            Console.WriteLine("Ingrese el nuevo puesto: ");
            string puesto = p.ToString();
            puesto = Console.ReadLine();

            return res;
        }
    }
}
