
using Fantasias.Data;
using Conexao;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Fantasias.Repository
{
    public class FantasiasRepo
    {
        #region Atributos
        private static StringBuilder sql;
        #endregion

        #region Metodos Statics

        public static List<Data.Fantasias> Get()
        {
            sql = new StringBuilder();
            List<Data.Fantasias> lista = new List<Data.Fantasias>();

            sql.Append("SELECT * ");
            sql.Append("FROM fantasias ");
            sql.Append("ORDER BY id_fantasia ");

            MySqlDataReader dr = MinhaConexao.getLista(sql.ToString());
            {

                while (dr.Read())
                    lista.Add
                        (
                            new Data.Fantasias
                            {
                                id_fantasia = (int)dr["id_fantasia"],
                                descricao = (string)dr["descricao"],
                                id_categoria = (string)dr["id_categoria"]
                            }
                        );
            }
            dr.Dispose();
            return lista;
        }

        public static void Create(Data.Fantasias pFantasia)
        {
            sql = new StringBuilder();
            sql.Append("INSERT INTO fantasias (id_fantasia, descricao, id_categoria) ");
            sql.Append("VALUES (@idfant, @desc, @cat) ");

            MySqlCommand cmm = new MySqlCommand();
            cmm.Parameters.AddWithValue("@idfant", pFantasia.id_fantasia);
            cmm.Parameters.AddWithValue("@desc", pFantasia.descricao);
            cmm.Parameters.AddWithValue("@cat", pFantasia.id_categoria);

            cmm.CommandText = sql.ToString();
            MinhaConexao.CommandPersist(cmm);
        }

        public static void Edit(int pIdFantasia, Data.Fantasias pFantasia)
        {
            sql = new StringBuilder();

            sql.Append("update fantasias set descricao=@descricao, id_categoria=@id_categoria ");
            sql.Append("where id_fantasia=@id_fantasia ");

            MySqlCommand cmm = new MySqlCommand();
            cmm.Parameters.AddWithValue("@id_fantasia", pIdFantasia);
            cmm.Parameters.AddWithValue("@descricao", pFantasia.descricao);
            cmm.Parameters.AddWithValue("@id_categoria", pFantasia.id_categoria);

            cmm.CommandText = sql.ToString();
            MinhaConexao.CommandPersist(cmm);
        }


        public static void Delete(int pIdFantasia)
        {
            sql = new StringBuilder();
            sql.Append("delete from fantasias ");
            sql.Append("where id_fantasia=@id_fantasia ");

            MySqlCommand cmm = new MySqlCommand();
            cmm.Parameters.AddWithValue("@id_fantasia", pIdFantasia);

            cmm.CommandText = sql.ToString();
            MinhaConexao.CommandPersist(cmm);
        }
        #endregion
    }
}

