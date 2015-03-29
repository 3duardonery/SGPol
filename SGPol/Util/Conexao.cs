using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace SGPol.Util
{
     public class Conexao
     {

         #region VARIAVEIS DE CONEXÃO
         //VARIAVEL DO TIPO SQL CONNECTION
         private static SqlConnection sConn;
         //NOME DO SERVER
         public static string server = "EDUARDONERY-PC";
         //TIPO DA INSTANCIA
         public static string instance = "SQLSERVER";
         //USUARIO
         private static string user = "sa";
         //SENHA
         private static string pass = "12345678";
         //NOME DO BANDO
         public static string db = "sgpolimero";
         //STRING PARA A CONEXAO
         private static string caminho = string.Format("Server={0}\\{1};Database={2};User Id={3};" +
            "Password={4};",server,instance,db,user,pass);
         #endregion

         /*
          * METODO USADO PARA OBTER A CONEXÃO COM AS VARIAVEIS ACIMA
          * */
         public static SqlConnection ObterConexao()
         {
             sConn = new SqlConnection(caminho);
             return sConn;
         }

    }
}
