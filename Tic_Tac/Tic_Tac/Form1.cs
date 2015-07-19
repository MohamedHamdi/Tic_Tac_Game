using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tic_Tac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void Clear()
        {
            Lb1.Text = "";
            Lb2.Text = "";
            Lb3.Text = "";
            Lb4.Text = "";
            Lb5.Text = "";
            Lb6.Text = "";
            Lb7.Text = "";
            Lb8.Text = "";
            Lb9.Text = "";
            rB1.Checked = false;
            rB2.Checked = false;
            rB1.Show();
            rB2.Show();
            Lb10.Show();
            Lb11.Show();
           
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void check()
        {
            if (Lb1.Text!=""&&Lb2.Text!=""&&Lb3.Text!="")
            {
                if (Lb1.Text==Lb2.Text && Lb2.Text==Lb3.Text)
                {
                    if (Lb1.Text=="O")
                    {
                        
                        MessageBox.Show("Player" + " O " + "the winer","Warning" );
                        k++;
                        textBox2.Text = Convert.ToString(k);
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Player" + " X " + "the winer", "Warning");
                        b++;
                        textBox1.Text = Convert.ToString(b);
                        Clear();
                    }
                }
            }
            if (Lb4.Text != "" && Lb5.Text != "" && Lb6.Text != "")
            {
                if (Lb4.Text == Lb5.Text && Lb5.Text == Lb6.Text)
                {
                    if (Lb4.Text == "O")
                    {
                        MessageBox.Show("Player" + " O " + "the winer", "Warning");
                        k++;
                        textBox2.Text = Convert.ToString(k);
                        Clear();

                    }
                    else
                    {
                        MessageBox.Show("Player" + " X " + "the winer", "Warning");
                        b++;
                        textBox1.Text = Convert.ToString(b);
                        Clear();
                    }
                }
            }
             if (Lb7.Text != "" && Lb8.Text != "" && Lb9.Text != "")
            {
                if (Lb7.Text == Lb8.Text && Lb8.Text == Lb9.Text)
                {
                    if (Lb7.Text == "O")
                    {
                        MessageBox.Show("Player" + " O " + "the winer", "Warning");
                        k++;
                        textBox2.Text = Convert.ToString(k);
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Player" + " X " + "the winer", "Warning");
                        b++;
                        textBox1.Text = Convert.ToString(b);
                        Clear();
                    }
                }
            }
             if (Lb1.Text != "" && Lb4.Text != "" && Lb7.Text != "")
            {
                if (Lb1.Text == Lb4.Text && Lb4.Text == Lb7.Text)
                {
                    if (Lb1.Text == "O")
                    {
                        MessageBox.Show("Player" + " O " + "the winer", "Warning");
                        k++;
                        textBox2.Text = Convert.ToString(k);
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Player" + " X " + "the winer", "Warning");
                        b++;
                        textBox1.Text = Convert.ToString(b);
                        Clear();
                    }
                }
            }
             if (Lb2.Text != "" && Lb5.Text != "" && Lb8.Text != "")
            {
                if (Lb2.Text == Lb5.Text && Lb5.Text == Lb8.Text)
                {
                    if (Lb2.Text == "O")
                    {
                        MessageBox.Show("Player" + " O " + "the winer", "Warning");
                        k++;
                        textBox2.Text = Convert.ToString(k);
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Player" + " X " + "the winer", "Warning");
                        b++;
                        textBox1.Text = Convert.ToString(b);
                        Clear();
                    }
                }
            }
            if (Lb3.Text != "" && Lb6.Text != "" && Lb9.Text != "")
            {
                if (Lb3.Text == Lb6.Text && Lb6.Text == Lb9.Text)
                {
                    if (Lb3.Text == "O")
                    {
                        MessageBox.Show("Player" + " O " + "the winer", "Warning");
                        k++;
                        textBox2.Text = Convert.ToString(k);
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Player" + " X " + "the winer", "Warning");
                        b++;
                        textBox1.Text = Convert.ToString(b);
                        Clear();
                    }
                }
            }
            if (Lb1.Text != "" && Lb5.Text != "" && Lb9.Text != "")
            {
                if (Lb1.Text == Lb5.Text && Lb5.Text == Lb9.Text)
                {
                    if (Lb1.Text == "O")
                    {
                        MessageBox.Show("Player" + " O " + "the winer", "Warning");
                        k++;
                        textBox2.Text = Convert.ToString(k);
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Player" + " X " + "the winer", "Warning");
                        b++;
                        textBox1.Text = Convert.ToString(b);
                        Clear();
                    }
                }
            }
            if (Lb3.Text != "" && Lb5.Text != "" && Lb7.Text != "")
            {
                if (Lb3.Text == Lb5.Text && Lb5.Text == Lb7.Text)
                {
                    if (Lb3.Text == "O")
                    {
                        MessageBox.Show("Player" + " O " + "the winer", "Warning");
                        k++;
                        textBox2.Text = Convert.ToString(k);
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Player" + " X " + "the winer", "Warning");
                        b++;
                        textBox1.Text = Convert.ToString(b);
                        Clear();
                    }
                }
            }
            if (Lb1.Text!="" && Lb2.Text!="" &&Lb3.Text!="" &&Lb4.Text!="" &&Lb5.Text!="" &&Lb6.Text!="" &&Lb7.Text!="" &&Lb8.Text!="" &&Lb9.Text!="" )
            {
                if (Lb1.Text != Lb2.Text && Lb2.Text != Lb3.Text)
                {
                    MessageBox.Show("Eqilance !!", "Warning");
                    Clear();
                }
                if (Lb4.Text != Lb5.Text && Lb5.Text != Lb6.Text)
                {
                    MessageBox.Show("Eqilance !!", "Warning");
                    Clear();
                }
                if (Lb7.Text != Lb8.Text && Lb8.Text != Lb9.Text)
                {
                    MessageBox.Show("Eqilance !!", "Warning");
                    Clear();
                }
                if (Lb1.Text != Lb4.Text && Lb4.Text != Lb7.Text)
                {
                    MessageBox.Show("Eqilance !!", "Warning");
                    Clear();
                }
                if (Lb2.Text != Lb5.Text && Lb5.Text != Lb8.Text)
                {
                    MessageBox.Show("Eqilance !!", "Warning");
                    Clear();
                }
                if (Lb3.Text != Lb6.Text && Lb6.Text != Lb9.Text)
                {
                    MessageBox.Show("Eqilance !!", "Warning");
                    Clear();
                }
                if (Lb1.Text != Lb5.Text && Lb5.Text != Lb9.Text)
                {
                    MessageBox.Show("Eqilance !!", "Warning");
                    Clear();
                }
                if (Lb3.Text != Lb5.Text && Lb5.Text != Lb7.Text)
                {
                    MessageBox.Show("Eqilance !!", "Warning");
                    Clear();
                }
            }
         

        }

        
        int k = 0, b = 0;
        bool x;
        public void labClick(object sender, EventArgs e)
        {
            
            Label h = (Label)sender;
            if (rB1.Checked==false&&rB2.Checked==false)
            {
                MessageBox.Show("Who first ^_^", "Warning");
            }
            else if (h.Text=="X"||h.Text=="O")
                {
                    MessageBox.Show("M7bktsh y3ni tl3b hna :D", "Warning");
                }
                else if (h.Text=="")
                {
                    if (x==true)
                    {

                        h.ForeColor = System.Drawing.Color.Blue;
                        h.Text = "X";
                        x = false;
                        check();
                    }
                    else
                    {
                        h.ForeColor = System.Drawing.Color.Red;
                        h.Text = "O";
                        x = true;
                        check();
                    }
                }

            }

        

        private void rB1_CheckedChanged(object sender, EventArgs e)
        {
            x = false;
            rB1.Hide();
            rB2.Hide();
            Lb10.Hide();
            Lb11.Hide();
        }

        private void rB2_CheckedChanged(object sender, EventArgs e)
        {
            x = true;
            rB2.Hide();
            rB1.Hide();
            Lb10.Hide();
            Lb11.Hide();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            rB1.Checked = false;
            rB2.Checked = false;
            rB1.Show();
            rB2.Show();
            Lb10.Show();
            Lb11.Show();
            Lb1.Text = "";
            Lb2.Text = "";
            Lb3.Text = "";
            Lb4.Text = "";
            Lb5.Text = "";
            Lb6.Text = "";
            Lb7.Text = "";
            Lb8.Text = "";
            Lb9.Text = "";
            textBox2.Text = "0";
            textBox1.Text = "0";
            k = 0;
            b = 0;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}

