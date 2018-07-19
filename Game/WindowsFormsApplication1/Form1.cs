using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Find Charachter";
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            Image img = new Bitmap(@"C:\Users\H.S\Downloads\turtle.png");
            this.BackgroundImage = img;
            this.button1.Text = "Start Game";
            this.button2.Text = "Exit";
            this.button1.BackColor = Color.SlateGray;
            this.button2.BackColor = Color.SlateGray;
            this.button1.Font=new Font ("Times New Roman",25);
            this.button2.Font = new Font("Times New Roman", 25);
            this.button1.ForeColor = Color.White ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
