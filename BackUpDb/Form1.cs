using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackUpDb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Boolean flag;
        ConnectionToMySql conMySqlObject = new ConnectionToMySql(); // antikeimeno MYSQLbashs
        ConnectionToOracle conOracleObject = new ConnectionToOracle();
        StringBuilder connectstring;
        private void connectButton_Click(object sender, EventArgs e)
        {
            //GIA ORACLE MHN TO PIRAZETE 

            if (OracleRadionButton.Checked)
            {
                connectstring = new StringBuilder();
                if (usernametextbox.Text != "")
                {//prepei na dwsei username 
                    conOracleObject.setUsername(usernametextbox.Text);
                }
                else
                {
                    MessageBox.Show("Insert username to Continue");//msgbox an den dwsei username
                }
                if (passwordtextbox.Text != "")
                {// prepei na dwsei pass
                    conOracleObject.setPassword(passwordtextbox.Text);
                }
                else
                {
                    MessageBox.Show("Insert password to Continue");//msgbox an den dwsei pass
                }
                if (hostnametextbox.Text != "")
                {//prepei na dwsei hostname
                    conOracleObject.setHostname(hostnametextbox.Text, porttextbox.Text);
                }
                else
                {
                    MessageBox.Show("Insert Hostname to Continue");//msgbox an den dwsei host
                }
                if (databasename.Text != "")
                {//prepei na dwsei database 
                    conOracleObject.setDatabaseName(databasename.Text);
                }
                else
                {
                    MessageBox.Show("Insert Database to Continue");//msgbox an den dwsei database
                }
                MessageBox.Show("Oracle");
                conOracleObject.ConToDB(); //kleish ths methodou gia sundesh sth bash
                if (conOracleObject.isConnected()) // elenxos an exei ginei to connect sthn bash gia na emfanisw to epomeno parathyro
                {
                    this.Visible = false;
                    Form2 cp = new Form2();
                    
                    cp.Show();
                }
                else
                {
                    hostnametextbox.Text = null;
                    porttextbox.Text = "3306";
                    databasename.Text = null;
                    usernametextbox.Text = null;
                    passwordtextbox.Text = null;
                }
            }

            //GIA SQL PALI MHN TO PEIRAZETE
            if (MySQLRadiobutton.Checked)
            {
                connectstring = new StringBuilder();
                if (hostnametextbox.Text != "")
                {//prepei na dwsei hostname
                    conMySqlObject.setHostname(hostnametextbox.Text, porttextbox.Text);
                }
                else
                {
                    MessageBox.Show("Insert Hostname to Continue");//msgbox an den dwsei host
                }
                if (usernametextbox.Text != "")
                {//prepei na dwsei username 
                    conMySqlObject.setUsername(usernametextbox.Text);
                }
                else
                {
                    MessageBox.Show("Insert username to Continue");//msgbox an den dwsei username
                }
                if (passwordtextbox.Text != "")
                {// prepei na dwsei pass
                    conMySqlObject.setPassword(passwordtextbox.Text);
                }
                else
                {
                    MessageBox.Show("Insert password to Continue");//msgbox an den dwsei pass
                }
                if (databasename.Text != "")
                {//prepei na dwsei database 
                    conMySqlObject.setDatabaseName(databasename.Text);
                }
                else
                {
                    MessageBox.Show("Insert Database to Continue");//msgbox an den dwsei database
                }
                MessageBox.Show("MYSQL");

               
                conMySqlObject.ConToDB(); //kleish ths methodou gia sundesh sth bash
                if (conMySqlObject.isConnected()) // elenxos an exei ginei to connect sthn bash gia na emfanisw to epomeno parathyro
                {
                    flag = conMySqlObject.isConnected();
                    Console.WriteLine(flag);
                    this.Visible = false;
                    Form2 cp = new Form2(); 
                    cp.Show();
                
 
                }
                else
                {
                    hostnametextbox.Text = null;
                    porttextbox.Text = "3306";
                    databasename.Text = null;
                    usernametextbox.Text = null;
                    passwordtextbox.Text = null;
                }

                
            }

        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (conMySqlObject.isConnected())
            {
                conMySqlObject.CloseDB();
            }
            if (conOracleObject.isConnected())
            {
                conOracleObject.CloseDB();
            }
        Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usernametextbox.Text = Convert.ToString(conMySqlObject.isConnected());
        }
        public Boolean Isconnected()
        {
            return flag;
        }
    }
}
