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
        ConnectionToSql conobject = new ConnectionToSql(); // antikeimena ths klashs ConnectiontoDB gia na diaxeirhsh tou connection me bash
        private void connectButton_Click(object sender, EventArgs e)
        {
            StringBuilder connectstring = new StringBuilder();
            if (hostnametextbox.Text != "")
            {//prepei na dwsei hostname
                conobject.setHostname(hostnametextbox.Text, porttextbox.Text);
            }
            else
            {
                MessageBox.Show("Insert Hostname to Continue");//msgbox an den dwsei host
            }
            if (databasename.Text != "")
            {//prepei na dwsei database 
                conobject.setDatabaseName(databasename.Text);
            }
            else
            {
                MessageBox.Show("Insert Database to Continue");//msgbox an den dwsei database
            }
            if (usernametextbox.Text != "")
            {//prepei na dwsei username 
                conobject.setUsername(usernametextbox.Text);
            }
            else
            {
                MessageBox.Show("Insert username to Continue");//msgbox an den dwsei username
            }
            if (passwordtextbox.Text != "")
            {// prepei na dwsei pass
                conobject.setPassword(passwordtextbox.Text);
            }
            else
            {
                MessageBox.Show("Insert password to Continue");//msgbox an den dwsei pass
            }
            conobject.ConToDB(); //kleish ths methodou gia sundesh sth bash
            if (conobject.isConnected()) // elenxos an exei ginei to connect sthn bash gia na emfanisw to epomeno parathyro
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
    

        private void cancelButton_Click(object sender, EventArgs e)
        {
        Application.Exit();
        }
    }
}
