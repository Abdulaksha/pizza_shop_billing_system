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
    public partial class Form3 : Form
    {
        public static int total;
        public static int temp;
        public static int price;
        public static int just;
        public static string size;
        public static string crusted;
        public static string toppings;
        public static string stuffed;
        public static int i;
        public static string veg;
        public static string nonveg;
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (radioButton1.Checked || radioButton2.Checked)
            {
                comboBox1.Enabled = true;
            }
            else
            {
                comboBox1.Enabled = false;
            }

           



            if (comboBox1.Text != "")
            {
                groupBox1.Enabled = true;
                radioButton3.Enabled = true;
                radioButton4.Enabled = true;
                radioButton5.Enabled = true;
               
            }
            else
            {
                groupBox1.Enabled = false;
            }
            if (comboBox1.Text != "")
            {
                string c = comboBox1.SelectedItem.ToString();
                if (c == "PEPPY STUFF")
                {
                    comboBox1.Enabled = false;
                    temp = 0;
                    stuffed = c;
                    price = 30;
                    listBox1.Items.Add("\t" + stuffed + " COST: " + price + "\t");
                    temp += price;
                    radioButton2.Enabled = false;
                }
                
                if (c == "CARROT STUFF")
                {
                    listBox1.Items.Remove(c);
                    temp = 0;
                    comboBox1.Enabled = false;
                    stuffed = c;
                    price = 50;

                    listBox1.Items.Add("\t" + stuffed + " COST: " + price + "\t");
                    temp += price;
                    comboBox1.Enabled = false;
                    radioButton2.Enabled = false;
                }

                if (c == "TOMATO STUFF")
                {
                    temp = 0;
                    stuffed = c;
                    price = 45;

                    listBox1.Items.Add("\t" + stuffed + " COST: " + price + "\t");
                    temp += price;
                    comboBox1.Enabled = false;
                    radioButton2.Enabled = false;
                }
                if (c == "CHICKEN STUFF")
                {
                    temp = 0;
                    price = 100;
                    stuffed = c;

                    listBox1.Items.Add("\t" + stuffed + " COST: " + price + "\t");
                    temp += price;
                    comboBox1.Enabled = false;
                    radioButton1.Enabled = false;
                }

                if (c == "MUTTON STUFF")
                {
                    temp = 0;
                    stuffed = c;

                    price = 200;
                    listBox1.Items.Add("\t" + stuffed + " COST: " + price + "\t");
                    temp += price;
                    comboBox1.Enabled = false;
                    radioButton1.Enabled = false;
                }

                if (c == "EGG STUFF")
                {
                    temp = 0;
                    stuffed = c;

                    price = 50;
                    listBox1.Items.Add("\t" + stuffed + " COST: " + price + "\t");
                    temp += price;
                    comboBox1.Enabled = false;
                    radioButton1.Enabled = false;
                }

            }
        }

        private void Form3_Load(object sender, EventArgs e)
           
        {
            listBox1.Items.Add("    WELCOME  TO  AKSA'S  PIZZA  CORNER   ");
            veg = radioButton1.Text;
            nonveg = radioButton2.Text;
            i = 0;
            string[] ar1 = File.ReadAllLines("E:\\fdetails\\food.txt");
            string[] ar2 = ar1[0].ToString().Split('|');

            groupBox1.Text = ar2[0];
            radioButton3.Text = ar2[1];
            radioButton4.Text = ar2[2];
            radioButton5.Text = ar2[3];
            numericUpDown1.Enabled = false;


        }
        private void button3_Click(object sender, EventArgs e)
        {

            if (i == 2)
            {
                if (radioButton3.Checked)
                {
                    toppings = radioButton3.Text;
                }
                if (radioButton4.Checked)
                {
                    toppings = radioButton4.Text;
                }
                if (radioButton5.Checked)
                {
                    toppings = radioButton5.Text;
                }
                if (toppings == radioButton3.Text)
                {
                    price = 50;
                    temp += price;
                    listBox1.Items.Add("\t"+toppings + " TOPPINGS COST: " + price + "\t");
                }
                if (toppings == radioButton4.Text)
                {
                    price = 80;
                    temp += price;
                    listBox1.Items.Add("\t" + toppings + " TOPPINGS COST: " + price + "\t");
                }
                if (toppings == radioButton5.Text)
                {
                    price = 100;
                    temp += price;
                    listBox1.Items.Add("\t" + toppings + "  TOPPINGS COST: " + price + "\t");
                }
                total = temp;


                button1.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                radioButton5.Enabled = false;

            }





            i = 0;
            string[] ar1 = File.ReadAllLines("E:\\fdetails\\food.txt");
            string[] ar2 = ar1[0].ToString().Split('|');

            groupBox1.Text = ar2[0];
            radioButton3.Text = ar2[1];
            radioButton4.Text = ar2[2];
            radioButton5.Text = ar2[3];
            numericUpDown1.Enabled = false;
            if (numericUpDown1.Value != 0)
            {
                button3.Enabled = true;
            }
            else
            {
                button3.Enabled = false;
            }

            int tem=(int)numericUpDown1.Value;
            int quantity = tem;
           
            listBox1.Items.Add("\t" + " QUANTITY :" + quantity + "\t");
            listBox1.Items.Add("\t" + " PRICE    :"+ total * quantity+"\t" );
            just += total*quantity;
            listBox1.Items.Add("\t" + "TOTAL =" + just+"\t" );
           
            product p = new product();
            p.Productname = stuffed;
            p.Quantity = quantity ;
            p.Price = total * quantity ;
            p.Pizzasize = size;
            p.Toppings = toppings;
            p.Crusted = crusted;
            p.Total = just;
            StreamWriter sw = new StreamWriter("E:\\username\\" + Form1.user + ".txt", true);
            sw.WriteLine("STUFFED="+p.Productname);
            sw.WriteLine("QUANTITY="+p.Quantity);
            sw.WriteLine("PRICE="+p.Price);
            sw.WriteLine("SIZE="+p.Pizzasize);
            sw.WriteLine("TOPPINGS="+p.Toppings);
            sw.WriteLine("CRUSTED="+p.Crusted);
            sw.WriteLine("TOTAL="+p.Total);
            sw.Close();

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            numericUpDown1.Value = 0;
            numericUpDown1.Enabled = false;
            temp = 0;
            button2.Enabled = true;
            comboBox1.Text = null;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (i == 0)
            {
                if (radioButton3.Checked)
                {
                    size = radioButton3.Text;
                    radioButton1.Enabled = false;
                    radioButton2.Enabled = false;
                }
                if (radioButton4.Checked)
                {
                    size = radioButton4.Text;
                    radioButton1.Enabled = false;
                    radioButton2.Enabled = false;
                }
                if (radioButton5.Checked)
                {
                    size = radioButton5.Text;
                    radioButton1.Enabled = false;
                    radioButton2.Enabled = false;
                }
                if (size == radioButton3.Text)
                {
                    price = 30;
                    temp += price;
                    listBox1.Items.Add("\t" + size + " SIZE COST: " + price + "\t");
                }
                if (size == radioButton4.Text)
                {
                    price = 50;
                    temp += price;
                    listBox1.Items.Add("\t" + size + " SIZE COST: " + price + "\t");

                }
                if (size == radioButton5.Text)
                {
                    price = 70;
                    temp += price;
                    listBox1.Items.Add("\t" + size + " SIZE  COST: " + price + "\t");

                }
                total = temp;
            }

            if (i == 1)
            {
                if (radioButton3.Checked)
                {
                    crusted = radioButton3.Text;
                }
                if (radioButton4.Checked)
                {
                    crusted = radioButton4.Text;
                }
                if (radioButton5.Checked)
                {
                    crusted = radioButton5.Text;
                }
                if (crusted == radioButton3.Text)
                {
                    price = 70;
                    temp += price;
                    listBox1.Items.Add("\t" +crusted +" CRUSTED  COST: " + price + "\t");

                }
                if (crusted == radioButton4.Text)
                {
                    price = 90;
                    temp += price;
                    listBox1.Items.Add("\t" + crusted + " CRUSTED  COST: " + price + "\t");

                }
                if (crusted == radioButton5.Text)
                {
                    price = 110;
                    temp += price;
                    listBox1.Items.Add("\t" + crusted + " CRUSTED  COST: " + price + "\t");
                }
                total = temp;
            }

            if (i == 3)
            {
                button1.Enabled = false;
            }

                    string[] ar1 = File.ReadAllLines("E:\\fdetails\\food.txt");
                    string[] ar2 = ar1[++i].ToString().Split('|');
                    groupBox1.Text = ar2[0];
                    radioButton3.Text = ar2[1];
                    radioButton4.Text = ar2[2];
                    radioButton5.Text = ar2[3];
                    if (groupBox1.Enabled == true)
                    {
                        button1.Enabled = true;
                    }
                    else
                    {
                        button1.Enabled = false;
                    }
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    button1.Enabled = false;
                  
                }
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            comboBox1.Items.Clear();
            string[] ar1 = File.ReadAllLines("E:\\fdetails\\fd.txt");
            string[] ar2 = ar1[0].ToString().Split('|');
            if (radioButton1.Checked)
            {
                comboBox1.Text = null;
                comboBox1.Items.Clear();
                comboBox1.Items.Add(ar2[0]);
                comboBox1.Items.Add(ar2[1]);
                comboBox1.Items.Add(ar2[2]);
                button2.Enabled = true;
               
            }
            else if (radioButton1.Checked == false)
            {
                comboBox1.SelectedIndex = -1;
            }
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                comboBox1.Enabled = true;
                comboBox1.Text = null;
                string[] ar1 = File.ReadAllLines("E:\\fdetails\\fd.txt");
                string[] ar2 = ar1[1].ToString().Split('|');
                comboBox1.Items.Clear();
                comboBox1.Items.Add(ar2[0]);
                comboBox1.Items.Add(ar2[1]);
                comboBox1.Items.Add(ar2[2]);
                button2.Enabled = true;
            }
            else if (radioButton1.Checked == false)
            {
                comboBox1.SelectedIndex = -1;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                groupBox1.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = false;
            }
           
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                button1.Enabled = true;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
            }
            else
            {
                button1.Enabled = false;
            }

            if (i == 2)
            {
                if (radioButton3.Checked || radioButton4.Checked || radioButton5.Checked)
                {
                    button1.Enabled = false;
                    if (button1.Enabled == false)
                    {
                        numericUpDown1.Enabled = true;
                    }
                }
            } 

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                button1.Enabled = true;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
            }
            else
            {
                button1.Enabled = false;
            }

            if (i == 2)
            {
                if (radioButton3.Checked || radioButton4.Checked || radioButton5.Checked)
                {
                    button1.Enabled = false;
                    if (button1.Enabled == false)
                    {
                        numericUpDown1.Enabled = true;
                    }
                }
            } 
           
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                button1.Enabled = true;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
            }
            else
            {
                button1.Enabled = false;
            }

            if (i == 2)
            {
                if (radioButton3.Checked || radioButton4.Checked || radioButton5.Checked)
                {
                    button1.Enabled = false;
                    if (button1.Enabled == false)
                    {
                        numericUpDown1.Enabled = true;
                    }
                }
            } 
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value != 0)
            {
                button3.Enabled = true;
            }
            else
            {
                button3.Enabled = false;
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i = 0;
            string[] ar1 = File.ReadAllLines("E:\\fdetails\\food.txt");
            string[] ar2 = ar1[0].ToString().Split('|');
            groupBox1.Text = ar2[0];
            radioButton3.Text = ar2[1];
            radioButton4.Text = ar2[2];
            radioButton5.Text = ar2[3];

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            listBox1.Items.Clear();
            StreamWriter sw = new StreamWriter("E:\\username\\" + Form1.user + ".txt", true);
            sw.WriteLine(DateTime.Now);
            sw.WriteLine("\n");
            sw.WriteLine("\n");
            sw.Close();
            just = 0;
            button2.Enabled = false;
            comboBox1.Text = null;
            listBox1.Items.Add("    WELCOME  TO  AKSA'S  PIZZA  CORNER   ");
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
