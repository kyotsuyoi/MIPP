using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MIPP.CommonClasses;

namespace MIPP.Forms
{
    public class Screen
    {

        Connection C = new Connection();

        public DataSet LoadGrid_Prod(int Loja_ID, int Depart_ID, int Screen_ID) {
            try
            {
                C.Connect.Close();
                C.Connect.Open();
                
                C.DA = new MySqlDataAdapter("SELECT p.id, p.descricao, pl.preco FROM (produto AS p JOIN preco_loja AS pl ON pl.id_prod = p.id) " +
                                            "LEFT JOIN(SELECT * FROM produto_tela WHERE idTela = '" + Screen_ID + "' AND idLoja = '" + Loja_ID + "' AND idDepto = '" + Depart_ID + "') AS pt ON pt.idProduto = p.id " +
                                            "WHERE pl.id_loja = '" + Loja_ID + "' AND p.id_depto = '" + Depart_ID + "' AND pt.idProduto is null", C.Connect);
                DataSet DS = new DataSet();
                C.DA.Fill(DS);
                return DS;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public DataSet LoadGrid_ProdScreen(int Loja_ID, int Depart_ID, int Sceen_ID) {
            try
            {
                C.Connect.Close();
                C.Connect.Open();
                C.DA = new MySqlDataAdapter("SELECT posicao, produto.id, descricao, preco " +
                                            "FROM produto " +
                                            "INNER JOIN preco_loja ON preco_loja.id_prod = produto.id " +
                                            "INNER JOIN produto_tela ON produto_tela.idProduto = produto.id " +
                                            "INNER JOIN departamento ON departamento.id = produto.id_depto " +
                                            "WHERE produto_tela.idLoja = " + Loja_ID + " " +
                                            "AND preco_loja.id_loja = " + Loja_ID + " " +
                                            "AND departamento.id = " + Depart_ID + " " +
                                            "AND produto_tela.idTela = " + Sceen_ID + " " +
                                            "ORDER BY posicao", C.Connect);
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

        public MySqlDataReader LoadCombo_Loja()
        {
            try
            {
                MySqlDataReader reader;
                C.Connect.Close();
                C.Connect.Open();
                C.cmd = new MySqlCommand("SELECT id " +
                                         "FROM loja " +
                                         "WHERE ativo = '1'", C.Connect);
                reader = C.cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            
        }

        public MySqlDataReader LoadCombo_Departamento()
        {
            try
            {
                MySqlDataReader reader;
                C.Connect.Close();
                C.Connect.Open();
                C.cmd = new MySqlCommand("SELECT id " +
                                         "FROM departamento " +
                                         "WHERE ativo = '1'", C.Connect);
                reader = C.cmd.ExecuteReader();
                return reader;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            
        }

        public MySqlDataReader LoadCombo_Screen(int Loja_ID, int Depart_ID) {

            try
            {
                MySqlDataReader reader;
                C.Connect.Close();
                C.Connect.Open();
                C.cmd = new MySqlCommand("SELECT id " +
                                         "FROM tela " +
                                         "WHERE id_loja = '" + Loja_ID + "' " +
                                         "AND id_depart = '" + Depart_ID + "' " +
                                         "GROUP BY id", C.Connect);
                reader = C.cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public DataSet LoadGrid_Image(int Sceen_ID)
        {
            try
            {
                DataSet DS = new DataSet();
                C.Connect.Close();
                C.Connect.Open();
                C.DA = new MySqlDataAdapter("SELECT imagem " +
                                            "FROM tela " +
                                            "WHERE id = " + Sceen_ID, C.Connect);
                C.DA.Fill(DS);
                return DS;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public Image LoadImage_BackgroundScreen(int Depart_ID)
        {
            Image image;
            try
            {

                MySqlDataReader reader;
                C.Connect.Close();
                C.Connect.Open();
                C.cmd = new MySqlCommand("SELECT i.img AS background " +
                                         "FROM departamento AS d " +
                                         "JOIN imagem AS i ON d.background = i.id " +
                                         "WHERE d.id = " + Depart_ID, C.Connect);

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

        }

        public Boolean UpdateImage_Screen(int ID, int Loja_ID, int Depart_ID, int ImagemID)
        {
            try
            {
                C.Connect.Close();
                C.Connect.Open();
                C.cmd = new MySqlCommand("UPDATE tela SET id_imagem = '" + ImagemID + "'" +
                                         "WHERE id = " + ID + " " +
                                         "AND id_loja = " + Loja_ID + " " +
                                         "AND id_depart = " + Depart_ID, C.Connect);
                C.cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public Image LoadImage_Screen(int Sceen_ID, int Shop_ID, int Depart_ID)
        {
            Image image;
            try { 
                MySqlDataReader reader;
                C.Connect.Close();
                C.Connect.Open();
                C.cmd = new MySqlCommand("SELECT i.img AS imagem " +
                                         "FROM tela AS t " +
                                         "JOIN imagem AS i ON i.id = id_imagem " +
                                         "WHERE t.id = " + Sceen_ID + " " +
                                         "AND id_loja = " + Shop_ID + " " +
                                         "AND t.id_depart = " + Depart_ID, C.Connect);

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

        public byte[] LoadVIdeo_Screen(int Sceen_ID, int Shop_ID, int Depart_ID)
        {
            byte[] video;
            try
            {
                MySqlDataReader reader;
                C.Connect.Close();
                C.Connect.Open();
                C.cmd = new MySqlCommand("SELECT i.img AS imagem " +
                                         "FROM tela AS t " +
                                         "JOIN imagem AS i ON i.id = id_imagem " +
                                         "WHERE t.id = " + Sceen_ID + " " +
                                         "AND id_loja = " + Shop_ID + " " +
                                         "AND t.id_depart = " + Depart_ID, C.Connect);

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
        }

        public int LoadType_Screen(int Sceen_ID, int Shop_ID, int Depart_ID)
        {
            int type;
            try
            {
                MySqlDataReader reader;
                C.Connect.Close();
                C.Connect.Open();
                C.cmd = new MySqlCommand("SELECT i.tipo AS imagem " +
                                         "FROM tela AS t " +
                                         "JOIN imagem AS i ON i.id = id_imagem " +
                                         "WHERE t.id = " + Sceen_ID + " " +
                                         "AND id_loja = " + Shop_ID + " " +
                                         "AND t.id_depart = " + Depart_ID, C.Connect);

                reader = C.cmd.ExecuteReader();
                reader.Read();
                String s = (reader.GetValue(0)).ToString();
                type = int.Parse(s);

                return type;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }

        public Boolean InsertP(int Shop_ID, int Depart_ID, int Screen_ID, int Prod_ID, int Pos)
        {
            try
            {
                C.Connect.Close();
                C.Connect.Open();
                C.cmd.CommandText = "INSERT INTO produto_tela (idLoja, idDepto, idTela, idProduto, posicao) " +
                                    "VALUES ('" + Shop_ID + "', '" + Depart_ID + "', '" + Screen_ID + "', '" + Prod_ID + "', '" + Pos + "')";
                C.cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public Boolean UpdateP(int Shop_ID, int Depart_ID, int Screen_ID, int Prod_ID, int Pos)
        {
            try
            {
                C.Connect.Close();
                C.Connect.Open();
               
                C.cmd = new MySqlCommand("UPDATE produto_tela SET posicao = '" + Pos + "'" +
                                         "WHERE idLoja = " + Shop_ID + " " +
                                         "AND idDepto = " + Depart_ID + " " +
                                         "AND idTela = " + Screen_ID + " " +
                                         "AND idProduto = " + Prod_ID, C.Connect);
                C.cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public Boolean DeleteP(int Loja_ID, int Depart_ID, int Screen_ID, int Prod_ID, int Pos)
        {
            try
            {
                C.Connect.Close();
                C.Connect.Open();
                C.cmd.CommandText = "DELETE FROM `mipp`.`produto_tela` " +
                                    "WHERE `idProduto`='" + Prod_ID + "' " +
                                    "AND `idTela`='" + Screen_ID + "' " +
                                    "AND `idLoja`='" + Loja_ID + "' " +
                                    "AND `idDepto`='" + Depart_ID  + "' " +
                                    "AND `posicao`='" + Pos + "'";
                C.cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public Boolean UpdateTimer(int ID, int Loja_ID, int Depart_ID, int timer)
        {
            try
            {
                C.Connect.Close();
                C.Connect.Open();
                C.cmd = new MySqlCommand("UPDATE tela SET timer = '" + timer + "'" +
                                         "WHERE id = " + ID + " " +
                                         "AND id_loja = " + Loja_ID + " " +
                                         "AND id_depart = " + Depart_ID, C.Connect);
                C.cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public Boolean UpdateListColor(int ID, int Loja_ID, int Depart_ID, string ListColor)
        {
            try
            {
                C.Connect.Close();
                C.Connect.Open();
                //cor_prod_promo
                C.cmd = new MySqlCommand("UPDATE tela SET cor_prod_normal = '" + ListColor + "'" +
                                         "WHERE id = " + ID + " " +
                                         "AND id_loja = " + Loja_ID + " " +
                                         "AND id_depart = " + Depart_ID, C.Connect);
                C.cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public Boolean UpdatePromoListColor(int ID, int Loja_ID, int Depart_ID, string ListColor)
        {
            try
            {
                C.Connect.Close();
                C.Connect.Open();
                //cor_prod_promo
                C.cmd = new MySqlCommand("UPDATE tela SET cor_prod_promo = '" + ListColor + "'" +
                                         "WHERE id = " + ID + " " +
                                         "AND id_loja = " + Loja_ID + " " +
                                         "AND id_depart = " + Depart_ID, C.Connect);
                C.cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public int LoadTimer(int ID, int Loja_ID, int Depart_ID)
        {
            try
            {
                MySqlDataReader reader;
                C.Connect.Close();
                C.Connect.Open();
                C.cmd.CommandText = "SELECT timer " +
                                         "FROM tela " +
                                         "WHERE id = " + ID + " " +
                                         "AND id_loja = " + Loja_ID + " " +
                                         "AND id_depart = " + Depart_ID;

                reader = C.cmd.ExecuteReader();
                reader.Read();

                return (int)reader.GetValue(0); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel carregar o timer! " + ex.Message);
                return 0;
            }
        }

        public string LoadListColor(int ID, int Loja_ID, int Depart_ID)
        {
            try
            {
                MySqlDataReader reader;
                C.Connect.Close();
                C.Connect.Open();
                C.cmd.CommandText = "SELECT cor_prod_normal " +
                                         "FROM tela " +
                                         "WHERE id = " + ID + " " +
                                         "AND id_loja = " + Loja_ID + " " +
                                         "AND id_depart = " + Depart_ID;

                reader = C.cmd.ExecuteReader();
                reader.Read();

                return (string)reader.GetValue(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel carregar a cor! " + ex.Message);
                return "";
            }
        }

        public string LoadPromoListColor(int ID, int Loja_ID, int Depart_ID)
        {
            try
            {
                MySqlDataReader reader;
                C.Connect.Close();
                C.Connect.Open();
                C.cmd.CommandText = "SELECT cor_prod_promo " +
                                         "FROM tela " +
                                         "WHERE id = " + ID + " " +
                                         "AND id_loja = " + Loja_ID + " " +
                                         "AND id_depart = " + Depart_ID;

                reader = C.cmd.ExecuteReader();
                reader.Read();

                return (string)reader.GetValue(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel carregar a cor! " + ex.Message);
                return "";
            }
        }

        public Boolean InsertScreen(int Screen_ID, int Loja_ID, int Depart_ID, int ImageID, int vTimer)
        {
            try
            {
                C.Connect.Close();
                C.Connect.Open();
                
                C.cmd.CommandText = "INSERT INTO tela (id, id_loja, id_depart, id_imagem, timer) " +
                                    "VALUES ('" + Screen_ID + "', '" + Loja_ID + "', '" + Depart_ID + "', '" + ImageID + "', '" + vTimer + "')";
                C.cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public Boolean DeleteScreen(int Screen_ID, int Loja_ID, int Depart_ID)
        {
            try
            {
                C.Connect.Close();
                C.Connect.Open();

                C.cmd.CommandText = "DELETE FROM tela " +
                                    "WHERE id = '" + Screen_ID + "' AND id_loja = '" + Loja_ID + "' AND id_depart = '" + Depart_ID + "'";

                C.cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
