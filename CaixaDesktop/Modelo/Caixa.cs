using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace CaixaDesktop.Modelo
{
    class Caixa
    {
        private int idCaixa;
        private double saldoTotal;
        private double saldoFinal;
        private ConnectionMySQL conn;

        public Caixa(ConnectionMySQL conexao)
        {
            this.conn = conexao;
        }

        public Caixa(int idcaixa, double saldoTotal, double saldoFinal, ConnectionMySQL conn)
        {
            this.Idcaixa = idcaixa;
            this.SaldoTotal = saldoTotal;
            this.SaldoFinal = saldoFinal;
            this.Conn = conn;
        }

        public bool ObterCaixa(int idCaixa)
        {
            DataTable dados = null;
            bool resposta = false;
            try
            {
                string sql = "SELECT * FROM caixa.caixa WHERE (idCaixa=@idCaixa)";
                this.conn.AbrirConexao();
                this.conn.LimparParametros();
                this.conn.AdicionarParametro("@idCaixa", idCaixa.ToString());
                dados = this.conn.ExecutarSelect(sql);
                if (dados != null)
                {
                    this.Idcaixa = idCaixa;
                    this.SaldoTotal = (double)dados.Rows[0][1];
                    this.SaldoFinal = (double)dados.Rows[0][2];
                    resposta = true;
                }
                this.conn.FecharConexao();
            }
            catch (Exception error)
            {
                this.conn.FecharConexao();
                Console.WriteLine(error);
            }
            return resposta;
        }

        public bool AtualizarCaixa()
        {
            bool resposta = false;
            try
            {
                string sql = "UPDATE caixa.caixa SET saldoTotal = @saldoTotal, saldoFinal = @saldoFinal WHERE (idcaixa = @idCaixa)";
                this.Conn.AbrirConexao();
                this.Conn.LimparParametros();
                this.Conn.AdicionarParametro("@idCaixa", idCaixa.ToString());
                this.Conn.AdicionarParametro("@saldoTotal", saldoTotal.ToString());
                this.Conn.AdicionarParametro("@saldoFinal", saldoFinal.ToString());
                if (this.Conn.ExecutarNonQuery(sql) > 1)
                    resposta = true;
                this.Conn.FecharConexao();
            }
            catch (Exception error)
            {
                this.Conn.FecharConexao();
                Console.WriteLine(error);
            }
            return resposta;
        }

        public int Idcaixa { get => idCaixa; set => idCaixa = value; }
        public double SaldoTotal { get => saldoTotal; set => saldoTotal = value; }
        public double SaldoFinal { get => saldoFinal; set => saldoFinal = value; }
        public ConnectionMySQL Conn { get => conn; set => conn = value; }
    }
}
