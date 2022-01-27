using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SimChat
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureLogo_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://simchat.it/");
            Process.Start(sInfo);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void linkLabelRun_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 Form1 = new Form1();    //Create the New Form Object
            this.Hide();    //Hide the Old Form
            Form1.ShowDialog();    //Show the New Form
            this.Close();    //Close the Old Form
        }
    }
}
