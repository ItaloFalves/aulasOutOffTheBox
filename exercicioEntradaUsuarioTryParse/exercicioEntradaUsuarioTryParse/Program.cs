using System;

namespace exercicioEntradaUsuarioTryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com um valor numerico: ");
            var valorDigitadoEhInteiro = int.TryParse(Console.ReadLine(), out int valorDigitado);

            if (valorDigitadoEhInteiro)
            {
                Console.WriteLine("O Valor Digitado está certo: {0} \n O valor digitado foi: {1}", valorDigitadoEhInteiro, valorDigitado);
            }
            else
            {
                Console.WriteLine(" O valor digitado está incorreto.");
            }

            Console.ReadKey();

        }
    }
}
