﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGPol.Classes;
using System.Data.SqlClient;

namespace SGPol.DAO
{
    class PedidoDAO
    {
        private SqlConnection sConn = Util.Conexao.ObterConexao();
        private SqlCommand sCom;
        private List<Pedido> listaPedido = null;
        private Pedido pedido;
        private SqlDataReader reader;

        #region INSERIR PEDIDO
        public void InserirPedido(Pedido pedido)
        {
            string Sql = "INSERT INTO tb_pedido(nome_cliente,mod_etiqueta,os,obs) VALUES(@nome,@etiqueta,@os,@obs);";
            try
            {
                
                sCom = new SqlCommand(Sql,sConn);
                sCom.Parameters.AddWithValue("@nome",pedido.Cliente);
                sCom.Parameters.AddWithValue("@etiqueta",pedido.Etiqueta);
                sCom.Parameters.AddWithValue("@os",pedido.Os);
                sCom.Parameters.AddWithValue("@obs",pedido.Obs);
                sConn.Open();
                sCom.ExecuteNonQuery();
                sConn.Close();
            }
            catch (SqlException sqlExc)
            {
                
            }
        }
        #endregion

        #region CONSULTAR PEDIDO
        public List<Pedido> ListaPedidos()
        {
            string Sql = "SELECT * FROM tb_pedido;";
            try
            {
                listaPedido = new List<Pedido>();
                sCom = new SqlCommand(Sql,sConn);
                sConn.Open();
                reader = sCom.ExecuteReader();
                while(reader.Read())
                {
                    pedido = new Pedido();
                    pedido.Id = int.Parse(reader["id_pedido"].ToString());
                    pedido.Cliente = reader["nome_cliente"].ToString();
                    pedido.Etiqueta = reader["mod_etiqueta"].ToString();
                    pedido.Os = reader["os"].ToString();
                    pedido.Obs = reader["obs"].ToString();
                    listaPedido.Add(pedido);
                    pedido = null;
                }
                sConn.Close();
            }
            catch (SqlException sqlExc)
            {
                
                
            }
            return listaPedido;
        }
        #endregion

        public void AtualizarPedido(Pedido pedido)
        {
            string Sql = "UPDATE tb_pedido SET nome_cliente = @nome, mod_etiqueta = @etiqueta, os = @os, obs = @obs WHERE id_pedido = @id";
            try
            {
                sCom = new SqlCommand(Sql,sConn);
                sCom.Parameters.AddWithValue("@id",pedido.Id);
                sCom.Parameters.AddWithValue("@nome",pedido.Cliente);
                sCom.Parameters.AddWithValue("@etiqueta",pedido.Etiqueta);
                sCom.Parameters.AddWithValue("@os",pedido.Os);
                sCom.Parameters.AddWithValue("@obs",pedido.Obs);
                sConn.Open();
                sCom.ExecuteNonQuery();
                sConn.Close();
            }
            catch (SqlException sqlExc)
            {
                
            }
        }
        

        public List<Pedido> BuscaNomeCliente(string cliente)
        {
            string Sql = "SELECT * FROM tb_pedido WHERE nome_cliente = @cliente";
            try
            {
                listaPedido = new List<Pedido>();
                sCom = new SqlCommand(Sql, sConn);
                sCom.Parameters.AddWithValue("@cliente",cliente);
                sConn.Open();
                reader = sCom.ExecuteReader();
                while (reader.Read())
                {
                    pedido = new Pedido();
                    pedido.Id = int.Parse(reader["id_pedido"].ToString());
                    pedido.Cliente = reader["nome_cliente"].ToString();
                    pedido.Etiqueta = reader["mod_etiqueta"].ToString();
                    pedido.Os = reader["os"].ToString();
                    pedido.Obs = reader["obs"].ToString();
                    listaPedido.Add(pedido);
                    pedido = null;
                }
                sConn.Close();
                
            }
            catch (SqlException sqlExc)
            {
                
                throw;
            }
            return listaPedido;
        }

        public void ExcluirPedido(int id)
        {
            try
            {

            }
            catch (SqlException sqlExc)
            {
                
            }
        }
    }
}
