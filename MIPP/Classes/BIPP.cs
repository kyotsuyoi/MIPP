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

        public IDataReader LoadCombo_Department()
        {
            try
            {
                MySqlDataReader reader;
                C.Connect.Open();
                C.cmd = new MySqlCommand("SELECT id " +
                                         "FROM departamento " +
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

