using Oracle.ManagedDataAccess.Client;

namespace MIPP.CommonClasses
{

    class ConnectionOracle
    {
        public OracleConnection Connect = new OracleConnection("Data Source=(DESCRIPTION="
        + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.0.191)(PORT=1521)))"
        + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=ORCL)));"
        + "User Id=consinco;Password=c5_4854;");
        public OracleCommand cmd = new OracleCommand();
    }

}
