using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MIPP.CommonClasses;

namespace MIPP.Forms
{
    class Shop
    {
        Connection C = new Connection();

        public DataSet LoadGrid()
        {
            try
            {
                C.Connect.Close();
                C.Connect.Open();
                C.DA = new MySqlDataAdapter("SELECT id, nome, ativo " +
                                            "FROM loja", C.Connect);
                DataSet DS = new DataSet();
                C.DA.Fill(DS);
                return DS;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        public Boolean Insert(int ID, string Name, bool Activated)
        {
            try
            {
                C.Connect.Close();
                C.cmd = new MySqlCommand("INSERT INTO loja (id, nome, ativo) " +
                                    "VALUES ('" + ID + "', '" + Name + "', '" + Activated + "')", C.Connect);
                C.Connect.Open();
                C.cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public Boolean Update(int ID, string Name, bool Activated)
        {
            int activ;
            if (Activated == true)
            {
                activ = 1;
            }
            else
            {
                activ = 0;
            }

            try
            {
                C.Connect.Close();
                C.cmd = new MySqlCommand("UPDATE loja SET nome = '" + Name + "', " + "ativo = '" + activ + "'" +
                                         "WHERE id = '" + ID + "'", C.Connect);
                C.Connect.Open();
                C.cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public Boolean Delete(int ID)
        {
            try
            {
                C.Connect.Close();
                C.cmd = new MySqlCommand("DELETE FROM loja " +
                                    "WHERE `id`='" + ID + "' ", C.Connect);
                C.Connect.Open();
                C.cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public IDataReader LoadCombo_Shop()
        {
            try
            {
                MySqlDataReader reader;
                C.Connect.Open();
                C.cmd = new MySqlCommand("SELECT id " +
                                         "FROM loja ", C.Connect);
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

        public string LoadShop(int ID)
        {
            string S;
            try
            {
                MySqlDataReader reader;
                C.cmd = new MySqlCommand("SELECT nome " +
                                         "FROM loja " +
                                         "WHERE id = '" + ID + "'", C.Connect);

                C.Connect.Open();
                reader = C.cmd.ExecuteReader();
                reader.Read();
                S = (string)reader.GetValue(0);

                return S;
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
