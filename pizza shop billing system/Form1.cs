using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        public static string user;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

               

                try
                {
                    user = textBox1.Text;
                    string pass = textBox2.Text;
                    string[] ar1 = File.ReadAllLines("E:\\password\\" + pass + ".txt");
                    string[] ar2 = ar1[0].ToString().Split('|');
                    if (textBox1.Text == ar2[0] && textBox2.Text == ar2[1])
                    {
                        Form3 ab = new Form3();
                        ab.Show();
                    }
                    else
                    {
                        MessageBox.Show("INVALID USERNAME OR PASSWORD");
                    }
                }
                catch(FileNotFoundException )
                {
                    MessageBox.Show("INVALID USERNAME OR PASSWORD");
                }

               
               

            

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 ab = new Form2();
            ab.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
