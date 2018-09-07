using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelojChecador
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Administrativo admin = new Administrativo();
            Empleado emp = new Empleado();
            Persona pe = new Empleado();
            Persona pa = new Administrativo();
            Type t = typeof(object);
            
            if (pe is Empleado)
            {
                
            }
            else if (pa is Administrativo)
            {

            }
            else if (t == typeof(Persona))
            {

            }else if(t == typeof(Empleado))
            {

            }
            
        }
    }
}
