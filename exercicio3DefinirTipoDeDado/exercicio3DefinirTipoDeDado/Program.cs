using System;

namespace exercicio3DefinirTipoDeDado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Entre com um valor numerico: ");
            var valorDigitadoEhInteiro = long.TryParse(Console.ReadLine(), out long valorDigitado);

            if (valorDigitadoEhInteiro)
            {
                Console.WriteLine(" O Valor Digitado está certo: {0} \n O valor digitado foi: {1}", valorDigitadoEhInteiro, valorDigitado);

                if (valorDigitado <= sbyte.MaxValue && valorDigitado >= sbyte.MinValue)
                {
                    Console.WriteLine(" O melhor tipo de armazenamento do valor digitado é SBYTE");
                }

                else if (valorDigitado <= short.MaxValue && valorDigitado >= short.MinValue)
                {
                    Console.WriteLine(" O melhor tipo de armazenamento do valor digitado é SHORT");
                }


                else if (valorDigitado <= int.MaxValue && valorDigitado >= int.MinValue)
                {
                    Console.WriteLine(" O melhor tipo de armazenamento do valor digitado é INT");
                }


                else if (valorDigitado <= long.MaxValue && valorDigitado >= long.MinValue)
                {
                    Console.WriteLine(" O melhor tipo de armazenamento do valor digitado é LONG");
                }


            }
            else
            {
                Console.WriteLine(" O valor é digitado é INVALIDO! ");
            }

            Console.ReadKey();
        }
    }
}
