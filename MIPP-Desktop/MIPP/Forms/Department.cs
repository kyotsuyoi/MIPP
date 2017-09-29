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
                C.Connect.Close();
                C.Connect.Open();
                C.DA = new MySqlDataAdapter("SELECT id, nome, background, ativo " +
                                            "FROM departamento", C.Connect);
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


        public Boolean Insert(int ID, string Name, int ImageID, bool Activated)
        {
            try
            {
                C.Connect.Close();
                C.cmd = new MySqlCommand("INSERT INTO departamento (id, nome, background, ativo) " +
                                    "VALUES ('" + ID + "', '" + Name + "', '" + ImageID + "', '" + Activated + "')",C.Connect);
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

        public Boolean Update(int ID, string Name, int ImageID, bool Activated)
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
                C.cmd = new MySqlCommand ("UPDATE departamento SET nome = '" + Name + "', " + "background = '" + ImageID + "', " + "ativo = '" + activ + "' " +
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
        }

        public Boolean InsertBackground(int ID, Image image)
        {
            try
            {

                C.Connect.Close();
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
        }

        public Image LoadBackground(int ID)
        {
            Image image;
            try
            {
                MySqlDataReader reader;
                C.Connect.Close();
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
        }

    }
}
