using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelojChecador
{
    class Persona
    {
        protected string nombre;
        protected string empleado;
        protected string celular;
        
        public bool nuevo(string nombre, string empleado, string celular)
        {
            bool res = false;
            try
            {
                Console.WriteLine("Ingrese Número de empleado: ");
                empleado = Console.ReadLine();
                Console.WriteLine("Ingrese el nombre: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese Número de celular: ");
                celular = Console.ReadLine();
                res = true;
            }catch (Exception ex)
            {
                Console.WriteLine("No se pudo realizar el registro: " + ex.Message);
            }
            return res;
        }
        public bool modificar (string nombre, string empleado, string celular)
        {
            bool res = false;
            try
            {
                Console.WriteLine("Ingrese Número de empleado: ");
                empleado = Console.ReadLine();
                Console.WriteLine("Ingrese el nombre: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese Número de celular: ");
                celular = Console.ReadLine();
                res = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo modificar el registro: " + ex.Message);
            }

            return res;
        }
        public bool eliminar (string empleado)
        {
            bool res = false;
            try
            {
                Console.WriteLine("Ingrese el número del empleado a eliminar: ");
                empleado = Console.ReadLine();

            }catch(Exception ex)
            {
                Console.WriteLine("No fue posible eliminar el registro: "+ex.Message);
            }
            return res;
        }
        //public Persona consultar (string criterio)
        //{
        //    Persona per;
        //    try
        //    {
        //        Console.WriteLine("Ingrese el numero de expediente para realiar la consulta: ");
        //        criterio = Console.ReadLine();

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("No fue posible realizar la consulta: "+ex);
        //    }

        //    return per;
        //}
    }
}
