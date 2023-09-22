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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Username = textBox1.Text;
            StreamWriter sw = new StreamWriter("E:\\username\\"+textBox1.Text+".txt");
            
            sw.Close();
            l.Password = textBox2.Text;
            StreamWriter sa = new StreamWriter("E:\\password\\" + textBox2.Text + ".txt");
            sa.Write(l.ToString());
            sa.Close();
            MessageBox.Show("user creared successfully");
           

        }
    }
}
