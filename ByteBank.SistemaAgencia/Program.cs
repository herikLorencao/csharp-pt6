using ByteBank.Modelos;
using Humanizer;
using System;
using System.Text.RegularExpressions;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            string textoTeste = "Meu telefone é 1245-1245";
            Regex regex = new Regex("(\\d{4,5}).?(\\d{4})");

            Console.WriteLine(regex.Match(textoTeste));
            Console.ReadLine();

            string url = "pagina?arg1=a&arg2=b";
            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(url);

            string arg = extrator.GetValor("arg2");
            Console.WriteLine(arg);

            Console.ReadLine();
        }

        void testaInterpolacao()
        {
            string teste = $"valor {1 + 1}";
            Console.WriteLine();
        }

        void testaToString()
        {
            ContaCorrente conta = new ContaCorrente(1234, 12234);
            Console.WriteLine(conta.ToString());
        }

        void testaEquals()
        {
            Cliente cliente = new Cliente();
            Cliente cliente2 = new Cliente();

            if (cliente == cliente2)
                Console.WriteLine("São iguais");

        }
    }
}
