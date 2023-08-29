using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjPromedio
{
    internal class ClPromedio
    {
        public String estudiante { set; get; }
        public double nota1 { set; get; }

        public double nota2 { set; get; }
        public double nota3 { set; get; }
        public double nota4 { set; get; }

        double promedio = 0;

        public double NotaMinima()
        {
            double minima = 0;
            if (nota1 < nota2 && nota1 < nota3 && nota1 < nota4)
            {
                minima = nota1;
            }
            else if (nota2 < nota1 && nota2 < nota3 && nota2 < nota4)
            {
                minima = nota2;
            }
            else if (nota3 < nota1 && nota3 < nota2 && nota3 < nota4)
            {
                minima = nota3;
            }
            else if (nota4 < nota2 && nota4 < nota3 && nota4 < nota1)
            {
                minima = nota4;
            }

            return minima;
        }

        public double PromedioNota()
        {


            if (nota1 < nota2 && nota1 < nota3 && nota1 < nota4)
            {
                promedio = (nota2 + nota3 + nota4) / 3;
            }
            else if (nota2 < nota1 && nota2 < nota3 && nota2 < nota4)
            {
                promedio = (nota1 + nota3 + nota4) / 3;
            }
            else if (nota3 < nota1 && nota3 < nota2 && nota3 < nota4)
            {
                promedio = (nota1 + nota2 + nota4) / 3;
            }
            else if (nota4 < nota2 && nota4 < nota3 && nota4 < nota1)
            {
                promedio = (nota1 + nota2 + nota3) / 3;
            }

            return promedio;
        }

        public string CondicionNota()
        {
            string condicion = "";

            if (promedio > 90)
            {
                condicion = "Excelente";
            }
            else if (promedio > 80 || promedio <= 90)
            {
                condicion = "Muy bueno";
            }
            else if (promedio > 70 || promedio <= 80)
            {
                condicion = "Bueno";

            }
            else if (promedio > 60 || promedio <= 70)
            {
                condicion = "Regular";

            }
            else if (promedio <= 60)
            {
                condicion = "Reprobado";
            }


            return condicion;
        }
       
    }
}
