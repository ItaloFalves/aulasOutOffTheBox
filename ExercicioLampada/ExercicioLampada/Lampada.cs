using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioLampada
{
   public class Lampada
    {
        public string estado;

        public Lampada() // Isto é um construtor
        {
            estado = "Desligado"; // Sempre quando iniciado, vai ser carregado neste estado. 
        }
        public void acende()
        {
            estado = "Ligado";
        }

        public void apaga()
        {
            estado = "Desligada";
        }

        public void mostraEstado()
        {
            Console.WriteLine(" A lampada está " + estado); 
        }


    }
}
