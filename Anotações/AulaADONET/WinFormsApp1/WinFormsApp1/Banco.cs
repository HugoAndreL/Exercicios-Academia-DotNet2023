using System.Data;
using System.Data.SqlClient;

namespace Teste_ADONET
{
    internal class Banco
    {
        public string strCon = @"Data Source=HGNOTEBOOK\ATOSMSSQSLSERVER;" +
            "Initial Catalog=Teste_ADONET;" + 
            "User ID=TesteADONET;" + 
            "Password=senha12345;" +
            "Language=Portuguese;";

        private SqlConnection cn;

        private void con()
        {
            cn = new SqlConnection(strCon);
        }

        public SqlConnection OpenCon()
        {
            try
            {
                con();
                cn.Open();

                return cn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CloseCon()
        {
            try
            {
                cn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ConsultarTabela(string sql)
        {
            try
            {
                // Aberta
                OpenCon();
                // comando sql
                SqlCommand cmd = new SqlCommand(sql, cn);
                // Executa o comando
                cmd.ExecuteNonQuery();
                // Cria a tabela para o banco
                DataTable dt = new DataTable();
                // Adapta o comando e preenche na tabela
                SqlDataAdapter ad = new(cmd);
                ad.Fill(dt);
                // Fecha a tabela
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseCon();
            }
        }
    }
}
