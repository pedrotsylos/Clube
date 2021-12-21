using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form3.model
{
    class Mensalidade
    {
        private int id;
        private double valor_mensalidade;
        private string data_pagamento;
        private string data_pago;
        private double juros;
        private double valor_pago;

        public int Id { get => id; set => id = value; }
        public double Valor_mensalidade { get => valor_mensalidade; set => valor_mensalidade = value; }
        public string Data_pagamento { get => data_pagamento; set => data_pagamento = value; }
        public string Data_pago { get => data_pago; set => data_pago = value; }
        public double Juros { get => juros; set => juros = value; }
        public double Valor_pago { get => valor_pago; set => valor_pago = value; }
    }
}
