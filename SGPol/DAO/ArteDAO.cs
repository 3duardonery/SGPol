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
            string Sql = "INSERT INTO tb_arte(id_pedido_arte,prazo_arte,data_elab,prioridade,status,obs) "
                + "VALUES(@id_pedido,@prazo,@dt_elab,@prioridade,@status,@obs)";
            try
            {
                _sCom = new SqlCommand(Sql, _sConn);
                _sCom.Parameters.AddWithValue("@id_pedido", arte.Id_pedido);
                _sCom.Parameters.AddWithValue("@prazo", arte.Prazo_arte);
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


    }
}
