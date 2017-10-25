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

        public DataSet LoadGrid(int ID, int id_prod)
        {
            try
            {
                C.Connect.Open();
                C.DA = new MySqlDataAdapter("SELECT id_prod, id_equival, id_loja, descricao, equiv FROM bipp INNER JOIN produto ON produto.id = id_equival " +
                    "WHERE id_loja = " + ID + " AND id_prod = " + id_prod
                 , C.Connect);
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

        public DataSet LoadGrid1(int ID)
        {
            try
            {
                C.Connect.Open();
                C.DA = new MySqlDataAdapter("SELECT id `Código`, descricao `Descrição`, id_depto `Departamento`, preco `Preço` FROM produto " +
                    "INNER JOIN preco_loja ON preco_loja.id_prod = produto.id " +
                    "WHERE id_loja = " + ID, C.Connect);
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
                C.Connect.Close();
                C.Connect.Dispose();
            }
        }

        public DataSet LoadGrid2(int ID, int id_prod)
        {
            try
            {
                C.Connect.Open();
                C.DA = new MySqlDataAdapter("SELECT id Código, descricao Descrição, id_depto Departamento, preco Preço FROM produto p " +
         "INNER JOIN preco_loja pl ON pl.id_prod = p.id " +
         "LEFT JOIN bipp b ON b.id_prod = " + id_prod + " AND b.id_equival = p.id " +
         " WHERE pl.id_loja = " + ID + " AND p.id != " + id_prod + " AND id_equival IS NULL", C.Connect);
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
                C.Connect.Close();
                C.Connect.Dispose();
            }
        }

        public Boolean Insert(int ID, int id_equival, int id_loja)
        {
            try
            {
                C.Connect.Open();
                C.cmd = new MySqlCommand("CALL addEquivalence ("+ID +", "+id_equival+", "+id_loja+")", C.Connect);

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

        public Boolean Delete(int ID, int id_equival, int id_loja)
        {
            try
            {
                C.Connect.Open();
                C.cmd = new MySqlCommand("CALL removeEquivalence (" + ID + ", " + id_equival + ", " + id_loja + ")", C.Connect);

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
                                         "WHERE id_prod = " + ID + " AND  = " + ShopID, C.Connect);

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

        public DataSet LoadGrid_SearchID1(int ID)
        {
            try
            {
                C.Connect.Open();
                C.DA = new MySqlDataAdapter("SELECT id, descricao FROM produto WHERE id = " + ID, C.Connect);
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

        public DataSet LoadGrid_SearchDesciption1(string Description)
        {
            try
            {
                C.Connect.Open();
                C.DA = new MySqlDataAdapter("SELECT id, descricao FROM produto WHERE descricao LIKE '%" + Description + "%'", C.Connect);
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

        public DataSet LoadGrid_SearchDepart1(int Depart)
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

        public Image LoadImage1(int ID)
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

        public Boolean Update(int id_prod, int id_equival, int id_loja, bool equiv)
        {
            int b;
            if (equiv == true)
            {
                b = 0;

            }
            else
            {
                b = 1;
            }

            try
            {
                C.Connect.Open();
                C.cmd = new MySqlCommand("CALL toggleEquivalence(" + id_prod + ", " + id_equival + ", " + id_loja + ", " + equiv + ")", C.Connect);
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
    }
}

