using System.Data;
using System.Data.SqlClient;

namespace MiniERP
{
    internal class Fornecedores
    {
        public int id;
        public string nome;
        public int cnpj;
        public string func;
        public string datCriacao;

        public BD bd = new();

        public bool Add()
        {
            SqlConnection cn = bd.OpenCon();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand cmd = new();

            cmd.Connection = cn;
            cmd.Transaction = tran;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Fornecedores VALUES (@nome, @cnpj, @func, @datCriacao);";

            cmd.Parameters.Add("@nome", SqlDbType.VarChar);
            cmd.Parameters.Add("@cnpj", SqlDbType.VarChar);
            cmd.Parameters.Add("@func", SqlDbType.VarChar);
            cmd.Parameters.Add("@datCriacao", SqlDbType.VarChar);

            cmd.Parameters[0].Value = nome;
            cmd.Parameters[1].Value = cnpj;
            cmd.Parameters[2].Value = func;
            cmd.Parameters[3].Value = datCriacao;
            
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

        public Fornecedores Search(int id)
        {
            try
            {
                SqlConnection cn = bd.OpenCon();
                SqlCommand command = new SqlCommand("SELECT * FROM Fornecedores", cn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetInt32(0) == id)
                    {
                        this.id = reader.GetInt32(0);
                        nome = reader.GetString(1);
                        cnpj = reader.GetInt32(2);
                        func = reader.GetString(3);
                        datCriacao = reader.GetString(4);

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
            cmd.CommandText = "UPDATE Fornecedores SET nome = @nome, cnpj = @cnpj, funcao = @func, datCriacao = @datCriacao WHERE id = @id;";

            cmd.Parameters.Add("@nome", SqlDbType.VarChar);
            cmd.Parameters.Add("@cnpj", SqlDbType.VarChar);
            cmd.Parameters.Add("@func", SqlDbType.VarChar);
            cmd.Parameters.Add("@datCriacao", SqlDbType.VarChar);
            cmd.Parameters.Add("@id", SqlDbType.Int);

            cmd.Parameters[0].Value = nome;
            cmd.Parameters[1].Value = cnpj;
            cmd.Parameters[2].Value = func;
            cmd.Parameters[3].Value = datCriacao;
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
                return false;
                throw ex;
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
            cmd.CommandText = "DELETE FROM Fornecedores WHERE id = @id;";

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
