using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;
using MIPP.CommonClasses;

namespace MIPP
{
    class MIPPOracle
    {
        ConnectionOracle OC = new ConnectionOracle();

        public IDataReader Test()
        {
            try
            {
                OC.Connect.Open();
                OC.cmd.CommandText = "SELECT p.descreduzida AS DESCRICAO, pc.codacesso AS CODIGOINTERNO, pe.nrodepartamento AS NRODEPARTAMENTO, pe.seqproduto AS SEQPRODUTO " +
                "FROM MAP_PRODCODIGO pc JOIN MAP_PRODUTO p ON p.seqproduto = pc.seqproduto "+ 
                "JOIN MRL_PRODUTOEMPRESA pe ON pe.seqproduto = pc.seqproduto "+
                "WHERE TIPCODIGO = 'B' AND pe.nroempresa = 1 AND pc.codacesso = 1";

                OC.cmd.CommandType = CommandType.Text; 
                OracleDataReader Reader = OC.cmd.ExecuteReader();
                
                var DT = new DataTable();
                DT.Load(Reader);
                return DT.CreateDataReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                OC.Connect.Close();
                OC.Connect.Dispose(); 
            }
        }
    }
}
