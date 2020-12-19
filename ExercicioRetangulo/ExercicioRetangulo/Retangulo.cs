using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioRetangulo
{
   public class Retangulo
    {
        public double largura;
        public double altura;

        public Retangulo()
        {
            largura = 1.0;
            altura = 1.0;
        }

        public Retangulo(double larguraDada,double alturaDada)
        {
            largura = larguraDada;
            altura = alturaDada;

            if (alturaDada <= 1.0 && alturaDada >= 20.0 || larguraDada <= 1.0 && larguraDada >= 20.0)
            {
                Console.WriteLine(" O valor não é valido ");
            }
           
        }

        public double calculaPerimetro ()
        {
           double perimetro = 2.0 * (largura + altura);
            return perimetro;

        }

        public double calculaArea ()
        {
            double area = 2.0 * (largura + altura);
            return area;
        }

    }

        
    }

