using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaDesktop.Modelo
{
    public class ConnectionMySQL
    {
        private string strConn = "Server=leonardocds15.sytes.net;Database=caixa;Uid=engenharia;Pwd=Xi2!&Te7ta3t;SslMode=none;";
        private MySqlConnection _conexao;
        private MySqlCommand _comando;

        public ConnectionMySQL()
        {
            if (_conexao == null && _comando == null)
            {
                _conexao = new MySqlConnection(strConn);
                _comando = _conexao.CreateCommand();
            }
        }

        public void AbrirConexao()
        {

            if (_conexao.State != System.Data.ConnectionState.Open)
                _conexao.Open();

        }

        public void FecharConexao()
        {

            _conexao.Close();

        }

        public void LimparParametros()
        {
            _comando.Parameters.Clear();
        }

        /// <summary>
        /// Executa Insert,Delete ou Update
        /// </summary>
        public int ExecutarNonQuery(string sql, Dictionary<string, object> parametros = null)
        {
            _comando.CommandText = sql;
            if (parametros != null)
            {
                foreach (var item in parametros)
                {
                    _comando.Parameters.AddWithValue(item.Key, item.Value);
                }
            }
            int rows;
            try
            {
                rows = _comando.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                rows = 0;
            }
            return rows;
        }

        public void AdicionarParametro(string param, string valor)
        {
            _comando.Parameters.AddWithValue(param, valor);
        }

        public DataTable ExecutarSelect(string sql, Dictionary<string, object> parametros = null)
        {
            DataTable tabMemoria = new DataTable();
            _comando.CommandText = sql;
            if (parametros != null)
            {
                foreach (var item in parametros)
                {
                    _comando.Parameters.AddWithValue(item.Key, item.Value);
                }
            }
            tabMemoria.Load(_comando.ExecuteReader());
            return tabMemoria;
        }

        public object ExecutarConsultaSimples(string sql)
        {
            object valor = null;
            _comando.CommandText = sql;
            valor = _comando.ExecuteScalar();
            return valor;
        }

    }
}
