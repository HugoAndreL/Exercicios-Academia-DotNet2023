using System.Data.SqlClient;

namespace Teste_ADONET
{
    internal class Pessoa
    {
        public int id;
        public string nome;
        public int idade;

        public bool Add()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.OpenCon();

            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = tran;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT INTO Pessoas VALUES (@nome, @idade);";
            cmd.Parameters.Add("@nome", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@idade", System.Data.SqlDbType.Int);
            cmd.Parameters[0].Value = nome;
            cmd.Parameters[1].Value = idade;

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
            }
            finally
            {
                bd.CloseCon();
            }
        }
    }
}
