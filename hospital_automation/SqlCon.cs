using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace hospital_automation
{
     class SqlCon
    {
       public SqlConnection connect()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-DB18UJA;Initial Catalog=db_Hastane;Integrated Security=True");
            conn.Open();
            return conn;

        }


    }
}
