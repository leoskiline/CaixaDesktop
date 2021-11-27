using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaDesktop.Modelo
{
    class MovimentoCaixa
    {
        private int idMovimentoCaixa;
        private int idCaixa;
        private double valor;
        private char tipo;
        private DateTime data;
        private ConnectionMySQL _conexao;

        public MovimentoCaixa(int idCaixa, double valor, char tipo, DateTime data, ConnectionMySQL conexao)
        {
            this.IdCaixa = idCaixa;
            this.Valor = valor;
            this.Tipo = tipo;
            this.Data = data;
            this._conexao = conexao;
        }

        public bool GravarMovimentoCaixa()
        {
            bool retorno = false;
            try
            {
                string sql = "INSERT INTO movimentoCaixa (idMovimentoCaixa, idCaixa, valor, tipo, data) VALUES(default, @idCaixa, @valor, @tipo, @data)";
                this._conexao.AbrirConexao();
                this._conexao.LimparParametros();
                this._conexao.AdicionarParametro("@idCaixa", this.idCaixa.ToString());
                this._conexao.AdicionarParametro("@valor", this.valor.ToString());
                this._conexao.AdicionarParametro("@tipo", this.tipo.ToString());
                this._conexao.AdicionarParametro("@data", this.data.ToString("yyyy-MM-dd H:mm:ss"));
                if (this._conexao.ExecutarNonQuery(sql) > 0)
                    retorno = true;
                this._conexao.FecharConexao();
            }
            catch (Exception error)
            {
                this._conexao.FecharConexao();
                Console.WriteLine(error);
            }
            return retorno;
        }

        public int IdMovimentoCaixa { get => idMovimentoCaixa; set => idMovimentoCaixa = value; }
        public int IdCaixa { get => idCaixa; set => idCaixa = value; }
        public double Valor { get => valor; set => valor = value; }
        public char Tipo { get => tipo; set => tipo = value; }
        public DateTime Data { get => data; set => data = value; }
    }
}
