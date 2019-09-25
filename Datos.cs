using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreCarga_P2
{
    class Datos
    {
        //Clase para ingresar datos
        public void ObtenerDatos()
        {
            Operaciones op = new Operaciones();
            Console.WriteLine( "Bienvenido" );

            Console.WriteLine("Ingrese 2 datos por favor");
            Console.WriteLine("Primer dato:");
            double cool = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Segundo dato:");
            double cool2 = Convert.ToDouble(Console.ReadLine());

            double res = op.Multiplicacion(cool, cool2);
            Console.WriteLine("El resultado es:" + res);
            
        }
    }
}
