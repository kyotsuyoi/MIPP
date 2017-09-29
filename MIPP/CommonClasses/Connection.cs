using MySql.Data.MySqlClient;

namespace MIPP.CommonClasses
{
    class Connection
    {
        public MySqlConnection Connect = new MySqlConnection("server=192.168.0.221; user id=admin; password=admin; database=mipp");
        public MySqlCommand cmd = new MySqlCommand();
        public MySqlDataAdapter DA = new MySqlDataAdapter();
    }
}
