using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MIPP.CommonClasses;

namespace MIPP
{
    class MIPP
    {
        Connection C = new Connection();

        public IDataReader LoadShop()
        {
            try
            {
                MySqlDataReader reader;
                C.Connect.Open();
                C.cmd = new MySqlCommand("SELECT id " +
                                         "FROM loja " +
                                         "WHERE ativo = '1'", C.Connect);
                reader = C.cmd.ExecuteReader();

                var DT = new DataTable();
                DT.Load(reader);
                return DT.CreateDataReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                C.Connect.Dispose();
                C.Connect.Close();
            }
        }
    }
}
