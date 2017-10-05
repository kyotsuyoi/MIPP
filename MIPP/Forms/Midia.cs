using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MIPP.CommonClasses;

namespace MIPP.Forms
{
    class Midia
    {
        Connection C = new Connection();

        public Boolean Insert(int DepartID, string Description, int tipo, Image image, byte[] video)
        {
            
            try
            {
                C.Connect.Open();
                C.cmd = new MySqlCommand("INSERT INTO imagem (id_depto, descricao, tipo, img) " +
                                    "VALUES ('" + DepartID + "', '" + Description + "', '" + tipo + "', @blob)", C.Connect);
                byte[] b;
                if (image != null)
                {
                    b = (byte[])new ImageConverter().ConvertTo(image, typeof(byte[]));
                }
                else
                {
                    b = video;
                }

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
                C.Connect.Dispose();
                C.Connect.Close();
            }
        }

        public Boolean Update(int ID, int DepartID, string Description, int type, Image image, byte[] video)
        {
            try
            {
                C.Connect.Open();
                C.cmd = new MySqlCommand("UPDATE imagem SET id_depto = '"+ DepartID +"', descricao = '" + Description + "', " + "tipo = '" + type + "', " + "img = @blob " +
                                         "WHERE id = '" + ID + "'", C.Connect);
                byte[] b;
                if (image != null)
                {
                    b = (byte[])new ImageConverter().ConvertTo(image, typeof(byte[]));
                }
                else
                {
                    b = video;
                }

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
                C.Connect.Dispose();
                C.Connect.Close();
            }
        }
        
        public Boolean Delete(int ID)
        {
            try
            {
                C.Connect.Open();
                C.cmd = new MySqlCommand("DELETE FROM imagem " +
                                    "WHERE `id`='" + ID + "'", C.Connect);
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
                C.Connect.Dispose();
                C.Connect.Close();
            }
        }

        public DataSet LoadGrid()
        {
            try
            {
                C.Connect.Open();
                C.DA = new MySqlDataAdapter("SELECT i.id, id_depto, descricao, tipo FROM imagem AS i " +
                                            "JOIN departamento AS d ON i.id_depto = d.id " +
                                            "WHERE d.ativo = 1", C.Connect);
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

        public DataSet LoadGridByDepart(int ID)
        {
            try
            {
                C.Connect.Open();
                C.DA = new MySqlDataAdapter("SELECT id, id_depto, descricao, tipo FROM imagem WHERE id_depto ='" + ID + "'", C.Connect);
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

        public DataSet LoadImageScreenGridByDepart(int ID)
        {
            try
            {
                C.Connect.Open();
                C.DA = new MySqlDataAdapter("SELECT id, descricao FROM imagem WHERE id_depto ='" + ID + "' AND tipo = '0'", C.Connect);
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

        public DataSet LoadVideoScreenGridByDepart(int ID)
        {
            try
            {
                C.Connect.Open();
                C.DA = new MySqlDataAdapter("SELECT id, descricao FROM imagem WHERE id_depto ='" + ID + "' AND tipo = '2'", C.Connect);
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

        public DataSet LoadImageGridByDepart(int ID)
        {
            try
            {
                C.Connect.Open();
                C.DA = new MySqlDataAdapter("SELECT id, descricao FROM imagem WHERE id_depto ='" + ID + "' AND tipo = '1'", C.Connect);
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

        public Image LoadImage(int ID, int Depart_ID)
        {
            Image image;
            try
            {

                MySqlDataReader reader;
                C.Connect.Open();
                C.cmd = new MySqlCommand("SELECT img " +
                                         "FROM imagem " +
                                         "WHERE id = '" + ID + "' " +
                                         "AND id_depto = '" + Depart_ID + "'", C.Connect);

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

        public byte[] LoadVideo(int ID, int Depart_ID)
        {
            byte[] video = null;
            try
            {

                MySqlDataReader reader;
                C.Connect.Open();
                C.cmd = new MySqlCommand("SELECT img " +
                                         "FROM imagem " +
                                         "WHERE id = '" + ID + "' " +
                                         "AND id_depto = '" + Depart_ID + "'", C.Connect);

                reader = C.cmd.ExecuteReader();
                reader.Read();
                video = (byte[])reader.GetValue(0);

                return video;
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

        public Image LoadSpecificImage(int ID)
        {
            Image image;
            try
            {

                MySqlDataReader reader;
                C.Connect.Open();
                C.cmd = new MySqlCommand("SELECT img " +
                                         "FROM imagem " +
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

        public byte[] LoadSpecificVideo(int ID)
        {
            byte[] video;
            try
            {

                MySqlDataReader reader;
                C.Connect.Open();
                C.cmd = new MySqlCommand("SELECT img " +
                                         "FROM imagem " +
                                         "WHERE id = '" + ID + "' ", C.Connect);

                reader = C.cmd.ExecuteReader();
                reader.Read();
                video = (byte[])reader.GetValue(0);

                return video;
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

        public IDataReader LoadCombo_Department()
        {
            try
            {
                MySqlDataReader reader;
                C.Connect.Open();
                C.cmd = new MySqlCommand("SELECT id " +
                                         "FROM departamento ORDER BY id", C.Connect);
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
