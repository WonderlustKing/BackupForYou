using System;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data.Odbc;

namespace BackUpDb
{
    class ConnectionToSql
    {
        //OdbcConnection cnn = null;
        StringBuilder connectstring = new StringBuilder();
        private String hostname = null;
        private String databasename = null;
        private String username = null;
        private String password = null;
        private String port = null;
        SqlConnection cnn = null;
        private Boolean flag = false;
        public void ConToDB()
        {
           cnn = new SqlConnection(Convert.ToString(@connectstring));
           //cnn= new OdbcConnection(Convert.ToString(connectstring));
            try

            {
                cnn.Open();
                MessageBox.Show("Connection Open! ");
                flag = true;
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection! ");
                connectstring = null;
                connectstring = new StringBuilder();
            }
        }
        public void setHostname(String hostname,String port)
        {
            this.hostname = hostname;
            this.port = port;
            connectstring.Append("Data Source=" + this.hostname +  ";");
        }
        public void setDatabaseName(String databasename)
        {
            this.databasename = databasename;
            connectstring.Append("Initial Catalog=" + this.databasename+ ";");
        }
        public void setUsername(String username)
        {
            this.username = username;
            connectstring.Append("User id=" + this.username + ";");
        }
        public void setPassword(String password)
        {
            this.password = password;
            connectstring.Append("Password=" + this.password + ";");
        }
        public Boolean isConnected()
        {
            return flag;
        }
        public String getHostname()
        {
            return this.hostname;
        }
        public String getPort()
        {
            return this.port;
        }
        public String getDatabaseName()
        {
            return this.databasename;
        }
        public String getUsername()
        {
            return this.username;
        }
        public String getPassword()
        {
            return this.password;
        }
        override
        public String ToString()
        {
            String str = Convert.ToString(connectstring);
            return str;
        }
    }
}