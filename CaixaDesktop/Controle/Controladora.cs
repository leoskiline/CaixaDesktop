using CaixaDesktop.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaDesktop.Controle
{
    public class Controladora
    {
        private ConnectionMySQL _conexao;

        public Controladora()
        {
            this._conexao = new ConnectionMySQL();
        }

        public bool Gravar(double valor, string motivo, char tipo, DateTime dataAtual)
        {
            Acerto acerto = new Acerto(dataAtual, motivo, valor, tipo, _conexao);
            bool resposta = acerto.Gravar();
            if (resposta)
            {
                MovimentoCaixa movimento = new MovimentoCaixa(1, valor, tipo, dataAtual, _conexao);
                resposta = movimento.GravarMovimentoCaixa();
                if (resposta)
                {
                    Caixa caixa = new Caixa(_conexao);
                    caixa.ObterCaixa(1);
                    if (tipo == 'E') caixa.SaldoFinal += valor;
                    else caixa.SaldoFinal -= valor;
                    caixa.AtualizarCaixa();
                }
            }
            return resposta;
        }
    }
}
