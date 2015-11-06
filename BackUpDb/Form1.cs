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
       
        StringBuilder connectstring;
        ConnectToServer conser = new ConnectToServer();
        private void connectButton_Click(object sender, EventArgs e)
        { 
            
            {
                connectstring = new StringBuilder();
                if (hostnametextbox.Text != "")
                {//prepei na dwsei hostname
                    conser.setHostname(hostnametextbox.Text, porttextbox.Text);
                }
                else
                {
                    MessageBox.Show("Insert Hostname to Continue");//msgbox an den dwsei host
                }
                if (usernametextbox.Text != "")
                {//prepei na dwsei username 
                    conser.setUsername(usernametextbox.Text);
                }
                else
                {
                    MessageBox.Show("Insert username to Continue");//msgbox an den dwsei username
                }
                if (passwordtextbox.Text != "")
                {// prepei na dwsei pass
                    conser.setPassword(passwordtextbox.Text);
                }
                else
                {
                    MessageBox.Show("Insert password to Continue");//msgbox an den dwsei pass
                }
                Console.WriteLine(conser);       
            }

        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            
        Application.Exit();
        }
    }
}
