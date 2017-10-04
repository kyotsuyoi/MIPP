using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MIPP.CommonClasses;

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

        public Boolean Update(int ID, string Description, int ID_Depart)
        {

            try
            {
                C.Connect.Open();
                C.cmd = new MySqlCommand("UPDATE produto SET descricao = '" + Description + "', " + "id_depto = '" + ID_Depart + "'" +
                                         "WHERE id = '" + ID + "'", C.Connect);
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
                C.DA = new MySqlDataAdapter("SELECT * FROM produto", C.Connect);
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
                C.Connect.Close();
                C.Connect.Open();

                C.DA = new MySqlDataAdapter("SELECT * FROM produto WHERE id = " + ID, C.Connect);
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

        public DataSet LoadGrid_SearchDesciption(string Description)
        {
            try
            {
                C.Connect.Close();
                C.Connect.Open();

                C.DA = new MySqlDataAdapter("SELECT * FROM produto WHERE descricao LIKE '%" + Description + "%'", C.Connect);
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

        public DataSet LoadGrid_SearchDepart(int Depart)
        {
            try
            {
                C.Connect.Close();
                C.Connect.Open();

                C.DA = new MySqlDataAdapter("SELECT * FROM produto WHERE id_depto = " + Depart, C.Connect);
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
        }
    } 

