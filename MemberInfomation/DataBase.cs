using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace MemberInfomation
{
    class DataBase
    {
        static public SqlConnection sqlc;
        void DateBase()
        {
            sqlc = new SqlConnection();
            sqlc.ConnectionString = "Addr=LAPTOP-Q6L7VHJH;Database=EmployeeInformation;uID=sa;Pwd=QQ123123";
        }
        static public void DBOpen()
        {
            try
            {

                sqlc = new SqlConnection();
                sqlc.ConnectionString = "Addr=LAPTOP-Q6L7VHJH;Database=EmployeeInformation;uID=sa;Pwd=QQ123123";
                sqlc.Open();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }
        static public void DBClose()
        {
            if(sqlc.State==System.Data.ConnectionState.Open)
            {
                sqlc.Close();
            }
        }


    }
}
