using System;

namespace ExercicioRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulomMenor = new Retangulo();


            Retangulo retanguloPequeno = new Retangulo(0.4, 3.0);
            Retangulo retanguloMedio = new Retangulo(3.0, 7.0);
            Retangulo retanguloMaior = new Retangulo( 7.0 , 14.0);

            Console.WriteLine(" O retangulo pequeno tem a seguinte informação: Sua altura é " + retanguloPequeno.altura + ", sua largura "+ retanguloPequeno.largura + ", sua area é " + retanguloPequeno.calculaArea() + " e seu perimetro é " + retanguloPequeno.calculaPerimetro());
            Console.WriteLine(" O retangulo medio tem a seguinte informação: Sua altura é " + retanguloMedio.altura + ", sua largura " + retanguloMedio.largura + ", sua area é " + retanguloMedio.calculaArea() + " e seu perimetro é " + retanguloMedio.calculaPerimetro());
            Console.WriteLine(" O retangulo maior tem a seguinte informação: Sua altura é " + retanguloMaior.altura + ", sua largura " + retanguloMaior.largura + ", sua area é " + retanguloMaior.calculaArea() + " e seu perimetro é " + retanguloMaior.calculaPerimetro());

            Console.ReadKey();
        }
    }
}
