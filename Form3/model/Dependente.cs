using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form3
{
    class Dependente : Pessoa
    {
        private int numero_cartao_cliente;
        private string parentesco;

        public int Numero_cartao_cliente { get => numero_cartao_cliente; set => numero_cartao_cliente = value; }
        public string Parentesco { get => parentesco; set => parentesco = value; }
    }
}
