using System;

namespace ExercicioLampada
{
    class Program
    {
        static void Main(string[] args)
        {
            Lampada LampadaDeCorAmarela = new Lampada();
            Lampada LampadaDeCorBranca = new Lampada();

            LampadaDeCorAmarela.acende();
            LampadaDeCorAmarela.mostraEstado();
            LampadaDeCorAmarela.apaga();
            LampadaDeCorAmarela.mostraEstado();

            Console.WriteLine("\n");

            LampadaDeCorBranca.acende();
            LampadaDeCorBranca.mostraEstado();
            LampadaDeCorBranca.apaga();
            LampadaDeCorBranca.mostraEstado();

            Console.ReadKey();
        }
    }
}
