using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using SGPol.Classes;


namespace SGPol.DAO
{
    class ArteDAO
    {
        private SqlConnection _sConn = SGPol.Util.Conexao.ObterConexao();
        private SqlCommand _sCom;
        private List<Arte> _list;
        private Arte _arte;
        private SqlDataReader _reader;
        private string msg;
        private const string msgSucesso = "Registro inserido com sucesso!";

        public string InserirArte(Arte arte)
        {
            string Sql = "INSERT INTO tb_arte(id_pedido_arte,prazo_arte,data_elab,prioridade,status,obs) VALUES(@id_pedido,@prazo,@dt_elab,@prioridade,@status,@obs)";
            try
            {
                _sCom = new SqlCommand(Sql, _sConn);
                _sCom.Parameters.AddWithValue("@id_pedido", arte.Id_pedido);
                _sCom.Parameters.AddWithValue("@prazo", arte.Prazo_arte);
                if(arte.Data_elab == null)
                    _sCom.Parameters.AddWithValue("@dt_elab", "");
                else
                    _sCom.Parameters.AddWithValue("@dt_elab", arte.Data_elab);
                _sCom.Parameters.AddWithValue("@prioridade", arte.Prioridade);
                _sCom.Parameters.AddWithValue("@status", arte.Status);
                _sCom.Parameters.AddWithValue("@obs", arte.Obs);
                _sConn.Open();
                int res = _sCom.ExecuteNonQuery();
                if (res > 0)
                    msg = msgSucesso;
                else
                    msg = "Erro ao inserir o registro!";

            }
            catch (SqlException sqlExc)
            {
                msg = sqlExc.Message;
            }
            finally
            {
                _sConn.Close();
            }

            return msg;
        }

        public List<Arte> ListaArte()
        {
            string Sql = "SELECT * FROM tb_arte;";
            try
            {
                _list = new List<Arte>();
                _sCom = new SqlCommand(Sql, _sConn);
                _sConn.Open();
                _reader = _sCom.ExecuteReader();
                while (_reader.Read())
                {
                    _arte = new Arte();
                    _arte.Id_arte = int.Parse(_reader["id_arte"].ToString());
                    _arte.Id_pedido = int.Parse(_reader["id_pedido"].ToString());
                    _arte.Prazo_arte = _reader["prazo_arte"].ToString();
                    if (_reader["data_elab"].ToString().Equals("1900-01-01"))
                        _arte.Data_elab = "//";
                    else
                        _arte.Data_elab = _reader["data_elab"].ToString();
                    _arte.Prioridade = int.Parse(_reader["prioridade"].ToString());
                    _arte.Status = _reader["status"].ToString();
                    _arte.Obs = _reader["obs"].ToString();
                    _list.Add(_arte);
                    _arte = null;
                }
            }
            catch (SqlException sqlExc)
            {

            }
            finally
            {
                _sConn.Close();
            }
            return _list;
        }
    }
}
