using Fantasias.Data;
using Conexao;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class ExemplaresRepo
    {
        #region Atributos
        private static StringBuilder sql;
        #endregion

        #region Metodos Statics

        public static List<Exemplares> Get()
        {
            sql = new StringBuilder();
            List<Exemplares> lista = new List<Exemplares>();

            sql.Append("SELECT * ");
            sql.Append("FROM exemplares ");
            sql.Append("ORDER BY id_exemplar ");

            MySqlDataReader dr = MinhaConexao.getLista(sql.ToString());
            {

                while (dr.Read())
                    lista.Add
                        (
                            new Exemplares
                            {
                                id_exemplar = (int)dr["id_exemplar"],
                                id_fantasia = (int)dr["id_fantasia"],
                                tamanho = (string)dr["tamanho"]
                            }
                        );
            }
            dr.Dispose();
            return lista;
        }


        public static void Create(Exemplares pExemplares)
        {
            sql = new StringBuilder();
            sql.Append("INSERT INTO exemplares (id_exemplar, id_fantasia, tamanho) ");
            sql.Append("VALUES (@id_exemplar, @id_fantasia, @tamanho) ");

            MySqlCommand cmm = new MySqlCommand();
            cmm.Parameters.AddWithValue("@id_exemplar", pExemplares.id_exemplar);
            cmm.Parameters.AddWithValue("@id_fantasia", pExemplares.id_fantasia);
            cmm.Parameters.AddWithValue("@tamanho", pExemplares.tamanho);

            cmm.CommandText = sql.ToString();
            MinhaConexao.CommandPersist(cmm);
        }


        public static void Edit(int pIdCliente, Exemplares pExemplares)
        {
            sql = new StringBuilder();

            sql.Append("update exemplares set id_exemplar=@id_exemplar, id_fantasia=@id_fantasia, tamanho=@tamanho ");
            sql.Append("where id_exemplar=@id_exemplar ");

            MySqlCommand cmm = new MySqlCommand();
            cmm.Parameters.AddWithValue("@id_exemplar", pExemplares.id_exemplar);
            cmm.Parameters.AddWithValue("@id_fantasia", pExemplares.id_fantasia);
            cmm.Parameters.AddWithValue("@tamanho", pExemplares.tamanho);

            cmm.CommandText = sql.ToString();
            MinhaConexao.CommandPersist(cmm);
        }


        public static void Delete(int pIdExemplar)
        {
            sql = new StringBuilder();
            sql.Append("delete from exemplares ");
            sql.Append("where id_exemplar=@id_exemplar ");

            MySqlCommand cmm = new MySqlCommand();
            cmm.Parameters.AddWithValue("@id_cliente", pIdExemplar);

            cmm.CommandText = sql.ToString();
            MinhaConexao.CommandPersist(cmm);
        }



        #endregion


    }

