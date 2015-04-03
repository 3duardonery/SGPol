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
        private List<ViewArte> _list;
        private Arte _arte;
        private ViewArte _vArte;
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

        public List<ViewArte> ListaArte()
        {
            string Sql = "SELECT * FROM view_arte_pedido;";
            try
            {
                _list = new List<ViewArte>();
                _sCom = new SqlCommand(Sql, _sConn);
                _sConn.Open();
                _reader = _sCom.ExecuteReader();
                while (_reader.Read())
                {
                    _vArte = new ViewArte();
                    _vArte.Id_arte = int.Parse(_reader["id_arte"].ToString());
                    _vArte.Id_pedido = int.Parse(_reader["id_pedido"].ToString());
                    _vArte.Nome_cliente = _reader["nome_cliente"].ToString();
                    _vArte.Prazo_arte = _reader["prazo_arte"].ToString();
                    if (_reader["data_elab"].ToString().Equals("1900-01-01"))
                        _vArte.Data_elab = "//";
                    else
                        _vArte.Data_elab = _reader["data_elab"].ToString();
                    _vArte.Prioridade = int.Parse(_reader["prioridade"].ToString());
                    _vArte.Status = _reader["status"].ToString();
                    _vArte.Obs = _reader["obs"].ToString();
                    _list.Add(_vArte);
                    _vArte = null;
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
