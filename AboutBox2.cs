using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoxComm
{
    partial class AboutBox2 : Form

    {

        public string TextToDisplay { get; set; }

        public int IconSelect { get; set; }

        public AboutBox2()
        {
            InitializeComponent();
                    
        }

        private void AboutBox2_Load(object sender, EventArgs e)
        {
            BoxMessage.Text = this.TextToDisplay;

            if(IconSelect == 0)
            {
                pictureBox1.Show();
                pictureBox2.Hide();
            }

            if (IconSelect == 1)
            {
                pictureBox1.Hide();
                pictureBox2.Show();
            }

            button1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Close();

                e.Handled = true;
                e.SuppressKeyPress = true;


            }
        }
    }
}
