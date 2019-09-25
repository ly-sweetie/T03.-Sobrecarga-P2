using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreCarga_P2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciamos los datos y utilizar los metodos
            Datos d = new Datos();
            d.ObtenerDatos();
            Console.ReadKey();

            //Instanciamos clase operaciones

            Operaciones op = new Operaciones();
            op.Multiplicacion();

            //Otorgar valores
            double res1 = op.Multiplicacion(2, 3);
            Console.WriteLine("La respuesta es:" + res1);

            double res2 = op.Multiplicacion(5);
            Console.WriteLine("La respuesta es:" + res2);

            double res3 = op.Multiplicacion();
            Console.WriteLine("La respuesta es:" + res3);

            Console.ReadKey();
        
        }
        }
    }

