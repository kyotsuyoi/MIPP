using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MIPP.CommonClasses;

namespace MIPP.Forms
{
    class Department
    {
        Connection C = new Connection();

        public DataSet LoadGrid()
        {
            try
            {
                C.DA = new MySqlDataAdapter("SELECT id, nome, background, ativo " +
                                            "FROM departamento", C.Connect);
                C.Connect.Open();
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

        public Boolean Insert(int ID, string Name, int ImageID, bool Activated)
        {
            int b = 0;
            if (Activated == true)
            {
                b = 1;
            }
            else
            {
                b = 0;
            }
            try
            {
                C.cmd = new MySqlCommand("INSERT INTO departamento (id, nome, ativo) " +
                                    "VALUES ('" + ID + "', '" + Name + "', '" + b + "')", C.Connect);
                C.Connect.Open();
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

        public Boolean Update(int ID, string Name, int ImageID, bool Activated)
        {
            int b;
            if (Activated == true)
            {
                b = 1;
            }
            else
            {
                b = 0;
            }

            try
            {
                C.cmd = new MySqlCommand ("UPDATE departamento SET nome = '" + Name + "', " + "ativo = '" + b + "', " + "background = '" + ImageID + "' " +
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
                C.cmd = new MySqlCommand ("DELETE FROM departamento " +
                                    "WHERE `id`='" + ID + "' ",C.Connect);
                C.Connect.Open();
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

        public Boolean InsertBackground(int ID, Image image)
        {
            try
            {
                C.cmd = new MySqlCommand("UPDATE departamento SET background=@Photo " +
                                         "WHERE id = '" + ID + "'", C.Connect);

                byte[] b = (byte[])new ImageConverter().ConvertTo(image, typeof(byte[]));

                C.cmd.Parameters.AddWithValue("@Photo", b);

                C.Connect.Open();
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

        public Image LoadBackground(int ID)
        {
            Image image;
            try
            {
                MySqlDataReader reader;
                C.cmd = new MySqlCommand("SELECT background " +
                                         "FROM departamento " +
                                         "WHERE id = '" + ID + "'", C.Connect);

                C.Connect.Open();
                reader = C.cmd.ExecuteReader();
                reader.Read();
                image = (Bitmap)new ImageConverter().ConvertFrom(reader.GetValue(0));

                return image;
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

        public string LoadDepart(int ID)
        {
            string S;
            try
            {
                MySqlDataReader reader;
                C.cmd = new MySqlCommand("SELECT nome " +
                                         "FROM departamento " +
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

        public IDataReader LoadCombo_Department()
        {
            try
            {
                MySqlDataReader reader;
                C.Connect.Open();
                C.cmd = new MySqlCommand("SELECT id " +
                                         "FROM departamento ", C.Connect);
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
