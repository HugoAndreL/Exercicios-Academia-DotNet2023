using System.Data.SqlClient;
using System.Data;
using System;

namespace MiniERP
{
    internal class Produto
    {
        public int id;
        public string nome;
        public int forn;
        public decimal preco;
        public string desc;

        public BD bd = new();

        public bool Add()
        {
            SqlConnection cn = bd.OpenCon();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand cmd = new();

            cmd.Connection = cn;
            cmd.Transaction = tran;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Produtos VALUES (@nome, @forn, @preco, @desc);";

            cmd.Parameters.Add("@nome", SqlDbType.VarChar);
            cmd.Parameters.Add("@forn", SqlDbType.Int);
            cmd.Parameters.Add("@preco", SqlDbType.Decimal);
            cmd.Parameters.Add("@desc", SqlDbType.VarChar);

            cmd.Parameters[0].Value = nome;
            cmd.Parameters[1].Value = forn;
            cmd.Parameters[2].Value = preco;
            cmd.Parameters[3].Value = desc;

            try
            {
                cmd.ExecuteNonQuery();
                tran.Commit();

                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                throw ex;
            }
            finally
            {
                bd.CloseCon();
            }
        }

        public Produto Search(int id)
        {
            try
            {
                SqlConnection cn = bd.OpenCon();
                SqlCommand command = new SqlCommand("SELECT * FROM Produtos", cn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetInt32(0) == id)
                    {
                        this.id = reader.GetInt32(0);
                        nome = reader.GetString(1);
                        forn = reader.GetInt32(2);
                        preco = reader.GetDecimal(3);
                        desc = reader.GetString(4);

                        return this;
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                bd.CloseCon();
            }
        }

        public bool Update()
        {
            SqlConnection cn = bd.OpenCon();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand cmd = new();

            cmd.Connection = cn;
            cmd.Transaction = tran;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Produtos SET nome = @nome, fk_forn = @forn, preco = @preco, descricao = @desc WHERE id = @id;";

            cmd.Parameters.Add("@nome", SqlDbType.VarChar);
            cmd.Parameters.Add("@forn", SqlDbType.Int);
            cmd.Parameters.Add("@preco", SqlDbType.Decimal);
            cmd.Parameters.Add("@desc", SqlDbType.VarChar);

            cmd.Parameters.Add("@id", SqlDbType.Int);

            cmd.Parameters[0].Value = nome;
            cmd.Parameters[1].Value = forn;
            cmd.Parameters[2].Value = preco;
            cmd.Parameters[3].Value = desc;
            cmd.Parameters[4].Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                tran.Commit();

                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                throw ex;
                return false;
            }
            finally
            {
                bd.CloseCon();
            }
        }

        public bool Delete()
        {
            SqlConnection cn = bd.OpenCon();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand cmd = new();

            cmd.Connection = cn;
            cmd.Transaction = tran;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Produtos WHERE id = @id;";

            cmd.Parameters.Add("@id", SqlDbType.Int);

            cmd.Parameters[0].Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                tran.Commit();

                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
                throw ex;
            }
            finally
            {
                bd.CloseCon();
            }
        }
    }
}
