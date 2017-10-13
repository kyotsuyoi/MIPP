using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MIPP.CommonClasses;
using System.Drawing;

namespace MIPP.Forms
{
    class BIPP
    {
        Connection C = new Connection();

        public Boolean Insert()
        {
            try
            {
                C.Connect.Open();
                C.cmd = new MySqlCommand("INSERT INTO bipp_prod_equival (id_prod, id_loja) " +
                    "", C.Connect);

                C.cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                C.Connect.Close();
                C.Connect.Dispose();
            }
        }

        public Boolean Update(int ProdID, int ProdID1, int ProdID2, int ProdID3, int ShopID)
        {

            try
            {
                C.Connect.Open();
                C.cmd = new MySqlCommand("UPDATE bipp SET id_prod1 = '" + ProdID1 + "', id_prod2 = '" + ProdID2 + "', id_prod3" + ProdID3 +  
                                         "WHERE id_prod = '" + ProdID + "'", C.Connect);
                
                C.cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                C.Connect.Close();
                C.Connect.Dispose();
            }
        }

        public Boolean Delete(int ProdID)
        {
            try
            {
                C.Connect.Open();
                C.cmd = new MySqlCommand("DELETE FROM bipp " +
                                    "WHERE `id_prod`='" + ProdID + "' ", C.Connect);
                C.cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                C.Connect.Close();
                C.Connect.Dispose();
            }
        }

        public DataSet LoadGrid(int ID)
        {
            try
            {
                C.Connect.Open();
                C.DA = new MySqlDataAdapter("SELECT p.id AS `Código`, p.descricao AS `Descrição`" +
                    " FROM mipp.bipp_prod_equival b JOIN produto p ON p.id = b.id_prod JOIN preco_loja pl ON pl.id_prod = p.id " +
                    "WHERE b.id_prod = 8846 AND pl.id_loja = " + ID, C.Connect);
                DataSet DS = new DataSet();
                C.DA.Fill(DS);
                return DS;
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

        public DataSet LoadGrid_SearchID(int ID)
        {
            try
            {
                C.Connect.Open();
                C.DA = new MySqlDataAdapter("SELECT id, descricao, id_depto FROM produto WHERE id = " + ID, C.Connect);
                DataSet DS = new DataSet();
                C.DA.Fill(DS);
                return DS;
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

        public DataSet LoadGrid_SearchDesciption(string Description)
        {
            try
            {
                C.Connect.Open();
                C.DA = new MySqlDataAdapter("SELECT id, descricao, id_depto FROM produto WHERE descricao LIKE '%" + Description + "%'", C.Connect);
                DataSet DS = new DataSet();
                C.DA.Fill(DS);
                return DS;
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

        public DataSet LoadGrid_SearchDepart(int Depart)
        {
            try
            {
                C.Connect.Open();
                C.DA = new MySqlDataAdapter("SELECT ID, descricao, id_depto FROM produto WHERE id_depto = " + Depart, C.Connect);
                DataSet DS = new DataSet();
                C.DA.Fill(DS);
                return DS;
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

        public Image LoadImage(int ID)
        {
            Image image;
            try
            {

                MySqlDataReader reader;
                C.Connect.Open();
                C.cmd = new MySqlCommand("SELECT foto " +
                                         "FROM produto " +
                                         "WHERE id = '" + ID + "' ", C.Connect);

                reader = C.cmd.ExecuteReader();
                reader.Read();
                image = (Bitmap)new ImageConverter().ConvertFrom(reader.GetValue(0));

                return image;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return image = null;
            }
            finally
            {
                C.Connect.Close();
                C.Connect.Dispose();
            }
        }

        public string LoadDescription(int ID)
        {
            string S;
            try
            {
                MySqlDataReader reader;
                C.cmd = new MySqlCommand("SELECT descricao " +
                                         "FROM produto " +
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

        public Double LoadPrice(int ID, int ShopID)
        {
            Double S;
            try
            {
                MySqlDataReader reader;
                C.cmd = new MySqlCommand("SELECT preco " +
                                         "FROM preco_loja " +
                                         "WHERE id_prod = " + ID + " AND id_loja = " + ShopID, C.Connect);

                C.Connect.Open();
                reader = C.cmd.ExecuteReader();
                reader.Read();
                S = (Double)reader.GetValue(0);

                return S;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            finally
            {
                C.Connect.Dispose();
                C.Connect.Close();
            }
        }

        public int LoadDepartament(int ID)
        {
            int I;
            try
            {
                MySqlDataReader reader;
                C.cmd = new MySqlCommand("SELECT id_depto " +
                                         "FROM produto " +
                                         "WHERE id = '" + ID + "'", C.Connect);

                C.Connect.Open();
                reader = C.cmd.ExecuteReader();
                reader.Read();
                I = (int)reader.GetValue(0);

                return I;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            finally
            {
                C.Connect.Dispose();
                C.Connect.Close();
            }
        }

    }
}

