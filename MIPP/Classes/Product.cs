using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MIPP.CommonClasses;
using System.Drawing;

namespace MIPP.Forms
{
    class Product
    {
        Connection C = new Connection();

        public Boolean Insert(int ID, string Description, int ID_Depart)
        {
            try
            {
                C.Connect.Open();
                C.cmd = new MySqlCommand("INSERT INTO produto (id, descricao, id_depto) " +
                                    "VALUES ('" + ID + "', '" + Description + "', '" + ID_Depart + "')", C.Connect);

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

        public Boolean Update(int ID, string Description, int ID_Depart, Image Photo)
        {

            try
            {
                C.Connect.Open();
                C.cmd = new MySqlCommand("UPDATE produto SET descricao = '" + Description + "', " + "id_depto = '" + ID_Depart + "', " + "foto = @blob " +
                                         "WHERE id = '" + ID + "'", C.Connect);
                byte[] b;

                b = (byte[])new ImageConverter().ConvertTo(Photo, typeof(byte[]));

                C.cmd.Parameters.AddWithValue("@blob", b);
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

        public Boolean Delete(int ID)
        {
            try
            {
                C.Connect.Open();
                C.cmd = new MySqlCommand("DELETE FROM produto " +
                                    "WHERE `id`='" + ID + "' ", C.Connect);
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

        public DataSet LoadGrid()
        {
            try
            {
                C.Connect.Open();
                C.DA = new MySqlDataAdapter("SELECT id, descricao, id_depto FROM produto", C.Connect);
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

        public DataSet LoadGrid(int ID)
        {
            try
            {
                C.Connect.Open();
                C.DA = new MySqlDataAdapter("SELECT id, descricao, id_depto, preco FROM produto " +
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
    }
}
