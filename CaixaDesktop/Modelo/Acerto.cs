using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaDesktop.Modelo
{
    public class Acerto
    {
        private int _id;
        private DateTime _dataAtual;
        private string _motivo;
        private double _valor;
        private char _tipo;
        private ConnectionMySQL _conexao;

        public Acerto(DateTime dataAtual, string motivo, double valor, char tipo, ConnectionMySQL conexao)
        {
          
            _dataAtual = dataAtual;
            _motivo = motivo;
            _valor = valor;
            _tipo = tipo;
            _conexao = conexao;
        }

        public bool Gravar()
        {
            bool retorno = false;
            try
            {
                string sql = "INSERT INTO acerto (data, motivo, valor, tipo) VALUES(@data_atual, @motivo, @valor, @tipo)";
                this._conexao.AbrirConexao();
                this._conexao.LimparParametros();
                this._conexao.AdicionarParametro("@data_atual", this._dataAtual.ToString("yyyy-MM-dd H:mm:ss"));
                this._conexao.AdicionarParametro("@motivo", this._motivo);
                this._conexao.AdicionarParametro("@valor", this._valor.ToString());
                this._conexao.AdicionarParametro("@tipo", this._tipo.ToString());
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
    }

    // PODEMOS USAR UMA PROCEDURE NO MYSQL PARA FAZER OS INSERTS TUDO DE UMA VEZ, MAS VOCÊS QUE SABEM, POR ISSO, NEM CRIEI O RESTANTE DAS CLASSES.
    // CASO QUEIRAM EXPERIMENTAR, DEIXEI UM LINK QUE FALA SOBRE ISSO LOGO ABAIXO.

    /* https://www.devmedia.com.br/stored-procedures-no-mysql/29030 */
}
