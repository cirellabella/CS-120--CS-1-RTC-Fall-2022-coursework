using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroToForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //This is an event
        //This event fires whenever the button is clicked
         private void btnShowPopup_Click(object sender, EventArgs e)
        {
            //One of the ways you can communicate with the user
            //in windows forms 
            MessageBox.Show("You clicked the button");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //this method fires when they click the button
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            //test to see if working
            //MessageBox.Show($"UserName: {userName} Password: {password}");
            if(userName == "" || password == "")
            {
                MessageBox.Show("Please enter both a username and password");
                //exit the method
                return;
            }
            //if i make it down here we know they must have typed something in
            lblLoggedIn.Text = "Hello " + userName;
        }
    }
}
