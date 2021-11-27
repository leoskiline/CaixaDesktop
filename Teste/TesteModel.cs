using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    class TesteModel
    {
        private string statusCaixa;
        private string tipo;
        private double valor;
        private string motivo;

        public TesteModel(string statusCaixa, string tipo, double valor, string motivo)
        {
            this.StatusCaixa = statusCaixa;
            this.Tipo = tipo;
            this.Valor = valor;
            this.Motivo = motivo;
        }

        public string StatusCaixa { get => statusCaixa; set => statusCaixa = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public double Valor { get => valor; set => valor = value; }
        public string Motivo { get => motivo; set => motivo = value; }
    }
}
