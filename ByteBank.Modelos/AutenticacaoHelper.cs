using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    // Se não colocar modificador é considerado internal por default
    internal class AutenticacaoHelper
    {
        public bool CompararSenhas(string senhaOriginal, string senhaInformada)
        {
            return senhaOriginal == senhaInformada;
        }
    }
}
