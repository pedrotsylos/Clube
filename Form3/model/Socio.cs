using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form3
{
    class Socio : Pessoa
    {
        private int numero_cartao_socio;
        private string endereco;
        private string telefone;

        public int Numero_cartao_socio { get => numero_cartao_socio; set => numero_cartao_socio = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Telefone { get => telefone; set => telefone = value; }
    }
}
