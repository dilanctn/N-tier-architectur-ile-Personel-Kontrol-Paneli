using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL_DataAccessLayer
{
    public class Baglantı
    {
        //Data Source=DESKTOP-7C53G4M\SQLEXPRESS;Initial Catalog=DbPersonel;Integrated Security=True
        public static SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-7C53G4M\SQLEXPRESS;Initial Catalog=DbPersonel;Integrated Security=True");

    }
}
