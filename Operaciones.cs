using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreCarga_P2
{
    class Operaciones
    {
        //Metodos de la multiplicacion

        //Metodo con dos parametros
        public double Multiplicacion(double a, double b)
        {
            return a * b;
        }

        //Metodo con un solo parametro
        public double Multiplicacion(double a)
        {
            return a * 3;
        }

        //Metodo sin ningun parametro
        public double Multiplicacion()
        {
            return 5 * 4;
        }
    }
}
