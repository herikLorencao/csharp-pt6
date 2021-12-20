using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ExtratorValorDeArgumentosURL
    {
        private readonly string _argumentos;
        public string URL { get; }

        public ExtratorValorDeArgumentosURL(string url)
        {
            if (string.IsNullOrEmpty(url))
                throw new ArgumentException("O Argumento url não pode ser nulo ou vazio", nameof(url));

            URL = url;
            int indiceInterrogacao = url.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogacao + 1);
        }

        public string GetValor(string nomeParametro)
        {
            nomeParametro = nomeParametro.ToUpper();
            string argumentoCaixaAlta = _argumentos.ToUpper();

            string termo = nomeParametro + "=";
            int indiceTermo = argumentoCaixaAlta.IndexOf(termo);

            int posicaoValorTermo = indiceTermo + termo.Length;
            string resultado = _argumentos.Substring(posicaoValorTermo);
            int indiceECommercial = resultado.IndexOf('&');

            if (indiceECommercial == -1)
                return resultado;

            return resultado.Remove(indiceECommercial);
        }
    }
}
