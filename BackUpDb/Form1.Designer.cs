﻿namespace BackUpDb
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.hostnametextbox = new System.Windows.Forms.TextBox();
            this.usernametextbox = new System.Windows.Forms.TextBox();
            this.passwordtextbox = new System.Windows.Forms.TextBox();
            this.porttextbox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.MySQLRadiobutton = new System.Windows.Forms.RadioButton();
            this.OracleRadionButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hostname :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Port :";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(488, 176);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 4;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(488, 216);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // hostnametextbox
            // 
            this.hostnametextbox.Location = new System.Drawing.Point(104, 71);
            this.hostnametextbox.Name = "hostnametextbox";
            this.hostnametextbox.Size = new System.Drawing.Size(217, 20);
            this.hostnametextbox.TabIndex = 6;
            this.hostnametextbox.Text = "127.0.0.1";
            // 
            // usernametextbox
            // 
            this.usernametextbox.Location = new System.Drawing.Point(104, 111);
            this.usernametextbox.Name = "usernametextbox";
            this.usernametextbox.Size = new System.Drawing.Size(361, 20);
            this.usernametextbox.TabIndex = 7;
            this.usernametextbox.Text = "root";
            // 
            // passwordtextbox
            // 
            this.passwordtextbox.Location = new System.Drawing.Point(104, 150);
            this.passwordtextbox.Name = "passwordtextbox";
            this.passwordtextbox.PasswordChar = '*';
            this.passwordtextbox.Size = new System.Drawing.Size(361, 20);
            this.passwordtextbox.TabIndex = 8;
            // 
            // porttextbox
            // 
            this.porttextbox.Location = new System.Drawing.Point(365, 68);
            this.porttextbox.Name = "porttextbox";
            this.porttextbox.Size = new System.Drawing.Size(100, 20);
            this.porttextbox.TabIndex = 9;
            this.porttextbox.Text = "3306";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(16, 195);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Remember Me";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // MySQLRadiobutton
            // 
            this.MySQLRadiobutton.AutoSize = true;
            this.MySQLRadiobutton.Checked = true;
            this.MySQLRadiobutton.Location = new System.Drawing.Point(499, 13);
            this.MySQLRadiobutton.Name = "MySQLRadiobutton";
            this.MySQLRadiobutton.Size = new System.Drawing.Size(60, 17);
            this.MySQLRadiobutton.TabIndex = 13;
            this.MySQLRadiobutton.TabStop = true;
            this.MySQLRadiobutton.Text = "MySQL";
            this.MySQLRadiobutton.UseVisualStyleBackColor = true;
            // 
            // OracleRadionButton
            // 
            this.OracleRadionButton.AutoSize = true;
            this.OracleRadionButton.Location = new System.Drawing.Point(499, 37);
            this.OracleRadionButton.Name = "OracleRadionButton";
            this.OracleRadionButton.Size = new System.Drawing.Size(56, 17);
            this.OracleRadionButton.TabIndex = 14;
            this.OracleRadionButton.Text = "Oracle";
            this.OracleRadionButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 251);
            this.Controls.Add(this.OracleRadionButton);
            this.Controls.Add(this.MySQLRadiobutton);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.porttextbox);
            this.Controls.Add(this.passwordtextbox);
            this.Controls.Add(this.usernametextbox);
            this.Controls.Add(this.hostnametextbox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Back Up For You";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox hostnametextbox;
        private System.Windows.Forms.TextBox usernametextbox;
        private System.Windows.Forms.TextBox passwordtextbox;
        private System.Windows.Forms.TextBox porttextbox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton MySQLRadiobutton;
        private System.Windows.Forms.RadioButton OracleRadionButton;
    }

}

