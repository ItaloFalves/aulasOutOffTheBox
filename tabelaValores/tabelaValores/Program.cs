using System;

namespace tabelaValores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Tabela mostrando o minimo e maximo dos valores \n ");
           
            sbyte valorMaximoDeUmSByte = sbyte.MaxValue;
            sbyte valorMinimoDeUmSByte = sbyte.MinValue;

            Console.WriteLine("Valor máximo de um sbyte: {0}", valorMaximoDeUmSByte);
            Console.WriteLine("Valor mínimo de um sbyte: {0}, \n ", valorMinimoDeUmSByte);

            short valorMaximoDeUmShort = short.MaxValue;
            short valorMínimoDeUmShort = short.MinValue;
            Console.WriteLine("Valor máximo de um short: {0}", valorMaximoDeUmShort);
            Console.WriteLine("Valor mínimo de um short: {0}, \n", valorMínimoDeUmShort);

            int valorMaximoDeUmInteiro = int.MaxValue;
            int valorMinimoDeUmInteiro = int.MinValue;
            Console.WriteLine("Valor máximo de um inteiro: {0}", valorMaximoDeUmInteiro);
            Console.WriteLine("Valor mínimo de um inteiro: {0}, \n", valorMinimoDeUmInteiro);



            long valorMaximoDeUmLong = long.MaxValue;
            long valorMinimoDeUmLong = long.MinValue;
            Console.WriteLine("Valor máximo de um long: {0}", valorMaximoDeUmLong);
            Console.WriteLine("Valor mínimo de um long: {0}, \n", valorMinimoDeUmLong);


            var valorMaximoInt64 = Int64.MaxValue;
            var valorMinimoInt64 = Int64.MinValue;
            Console.WriteLine("Valor Máximo de um Int64: {0}", valorMaximoInt64);
            Console.WriteLine("Valor Máximo de um Int64: {0}, \n", valorMinimoInt64);


            var valorMaximoDeUmByte = byte.MaxValue;
            var valorMinimoDeUmByte = byte.MinValue;
            Console.WriteLine("Valor máximo de um Byte: {0}", valorMaximoDeUmByte);
            Console.WriteLine("Valor mínimo de um Byte: {0}, \n", valorMinimoDeUmByte);


            var valorMaximoDeUmUShort = ushort.MaxValue;
            var valorMinimoDeUmUShort = ushort.MinValue;
            Console.WriteLine("Valor máximo de um ushort: {0}", valorMaximoDeUmUShort);
            Console.WriteLine("Valor Mínimo de um ushort: {0}, \n", valorMinimoDeUmUShort);

            var valorMaximoDeUmUInt = uint.MaxValue;
            var valorMinimoDeUmUInt = uint.MinValue;
            Console.WriteLine("Valor máximo de um uint: {0}", valorMaximoDeUmUInt);
            Console.WriteLine("Valor Mínimo de um uint: {0}, \n", valorMinimoDeUmUInt);

            var valorMaximoDeUmULong = ulong.MaxValue;
            var valorMinimoDeUmULong = ulong.MaxValue;
            Console.WriteLine("Valor máximo de um ulong: {0}", valorMaximoDeUmULong);
            Console.WriteLine("Valor Mínimo de um ulong: {0}, \n", valorMinimoDeUmULong);


            float valorMaximoFloat = float.MaxValue;
            float valorMinimoFloat = float.MinValue;
            Console.WriteLine("Valor Máximo de um float: {0}", valorMaximoFloat);
            Console.WriteLine("Valor Minimo de um float: {0}, \n", valorMinimoFloat);

            double valorMaximoDouble = double.MaxValue;
            double valorMinimoDouble = double.MinValue;
            Console.WriteLine("Valor Máximo de um double: {0}", valorMaximoDouble);
            Console.WriteLine("Valor Minimo de um double: {0}, \n", valorMinimoDouble);

          
    
            decimal valorMaximoDecimal = decimal.MaxValue;
            decimal valorMinimoDecimal = decimal.MinValue;
            Console.WriteLine($"Valor máximo de um decimal: {valorMaximoDecimal}");
            Console.WriteLine($"Valor minimo de um decimal: {valorMinimoDecimal} \n");


            var inteiroLiteral = 1;
            var hexaDecimaLiteral = 0x9809B84A1F8478F;
            var binarioLiteral = 0b_010101011111000111011;
            Console.WriteLine("Inteiro literal: {0}", inteiroLiteral);
            Console.WriteLine("hexadecimal literal: {0}", hexaDecimaLiteral);
            Console.WriteLine("binario literal: {0}, \n", binarioLiteral);

            Console.WriteLine(" FIM ");


            Console.ReadKey();
        }
    }
}
