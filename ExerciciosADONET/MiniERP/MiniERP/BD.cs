using System.Data;
using System.Data.SqlClient;

namespace MiniERP
{
    internal class BD
    {
        private SqlConnection cn;
        private string strCon = @"Data Source=HGNOTEBOOK; Initial Catalog=dboMiniERP; User ID=MiniERP; Password=MiniERP123; Language=Portuguese;";

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
