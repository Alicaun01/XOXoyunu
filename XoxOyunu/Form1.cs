using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XoxOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int tiklamasayisi = 0;
        string[] karakterxo = { "O", "X" };
        int sayac1 = 0, sayac2 = 0;

        void kazanmadurumu()
        {
            //1. 2. 3. satır karakter tamlamaları
            if (button1.Text == karakterxo[1] && button2.Text == karakterxo[1] && button3.Text == karakterxo[1] || button1.Text == karakterxo[0] && button2.Text == karakterxo[0] && button3.Text == karakterxo[0])
            {
                tuslarikitle();
                button1.BackColor = Color.LimeGreen;
                button2.BackColor = Color.LimeGreen;
                button3.BackColor = Color.LimeGreen;
                if (button1.Text == karakterxo[1])
                {
                    sayac1 += 1;
                    lblOyuncu1.Text = sayac1.ToString();
                }
                else
                {
                    sayac2 += 1;
                    lblOyuncu2.Text = sayac2.ToString();
                }
            }
            else if (button4.Text == karakterxo[1] && button5.Text == karakterxo[1] && button6.Text == karakterxo[1] || button4.Text == karakterxo[0] && button5.Text == karakterxo[0] && button6.Text == karakterxo[0])
            {
                tuslarikitle();
                button4.BackColor = Color.LimeGreen;
                button5.BackColor = Color.LimeGreen;
                button6.BackColor = Color.LimeGreen;
                if (button4.Text == karakterxo[1])
                {
                    sayac1 += 1;
                    lblOyuncu1.Text = sayac1.ToString();
                }
                else
                {
                    sayac2 += 1;
                    lblOyuncu2.Text = sayac2.ToString();
                }
            }
            else if (button7.Text == karakterxo[1] && button8.Text == karakterxo[1] && button9.Text == karakterxo[1] || button7.Text == karakterxo[0] && button8.Text == karakterxo[0] && button9.Text == karakterxo[0])
            {
                tuslarikitle();
                button7.BackColor = Color.LimeGreen;
                button8.BackColor = Color.LimeGreen;
                button9.BackColor = Color.LimeGreen;
                if (button7.Text == karakterxo[1])
                {
                    sayac1 += 1;
                    lblOyuncu1.Text = sayac1.ToString();
                }
                else
                {
                    sayac2 += 1;
                    lblOyuncu2.Text = sayac2.ToString();
                }
            }
            //1. 2. 3. sütun karakter tamlamaları
            if (button1.Text == karakterxo[1] && button4.Text == karakterxo[1] && button7.Text == karakterxo[1] || button1.Text == karakterxo[0] && button4.Text == karakterxo[0] && button7.Text == karakterxo[0])
            {
                tuslarikitle();
                button1.BackColor = Color.LimeGreen;
                button4.BackColor = Color.LimeGreen;
                button7.BackColor = Color.LimeGreen;
                if (button1.Text == karakterxo[1])
                {
                    sayac1 += 1;
                    lblOyuncu1.Text = sayac1.ToString();
                }
                else
                {
                    sayac2 += 1;
                    lblOyuncu2.Text = sayac2.ToString();
                }
            }
            else if (button2.Text == karakterxo[1] && button5.Text == karakterxo[1] && button8.Text == karakterxo[1] || button2.Text == karakterxo[0] && button5.Text == karakterxo[0] && button8.Text == karakterxo[0])
            {
                tuslarikitle();
                button2.BackColor = Color.LimeGreen;
                button5.BackColor = Color.LimeGreen;
                button8.BackColor = Color.LimeGreen;
                if (button2.Text == karakterxo[1])
                {
                    sayac1 += 1;
                    lblOyuncu1.Text = sayac1.ToString();
                }
                else
                {
                    sayac2 += 1;
                    lblOyuncu2.Text = sayac2.ToString();
                }
            }
            else if (button3.Text == karakterxo[1] && button6.Text == karakterxo[1] && button9.Text == karakterxo[1] || button3.Text == karakterxo[0] && button6.Text == karakterxo[0] && button9.Text == karakterxo[0])
            {
                tuslarikitle();
                button3.BackColor = Color.LimeGreen;
                button6.BackColor = Color.LimeGreen;
                button9.BackColor = Color.LimeGreen;
                if (button3.Text == karakterxo[1])
                {
                    sayac1 += 1;
                    lblOyuncu1.Text = sayac1.ToString();
                }
                else
                {
                    sayac2 += 1;
                    lblOyuncu2.Text = sayac2.ToString();
                }
            }
            //çapraz karakter tamlamaları
            if (button1.Text == karakterxo[1] && button5.Text == karakterxo[1] && button9.Text == karakterxo[1] || button1.Text == karakterxo[0] && button5.Text == karakterxo[0] && button9.Text == karakterxo[0])
            {
                tuslarikitle();
                button1.BackColor = Color.LimeGreen;
                button5.BackColor = Color.LimeGreen;
                button9.BackColor = Color.LimeGreen;
                if (button1.Text == karakterxo[1])
                {
                    sayac1 += 1;
                    lblOyuncu1.Text = sayac1.ToString();
                }
                else
                {
                    sayac2 += 1;
                    lblOyuncu2.Text = sayac2.ToString();
                }
            }
            else if (button3.Text == karakterxo[1] && button5.Text == karakterxo[1] && button7.Text == karakterxo[1] || button3.Text == karakterxo[0] && button5.Text == karakterxo[0] && button7.Text == karakterxo[0])
            {
                tuslarikitle();
                button3.BackColor = Color.LimeGreen;
                button5.BackColor = Color.LimeGreen;
                button7.BackColor = Color.LimeGreen;
                if (button3.Text == karakterxo[1])
                {
                    sayac1 += 1;
                    lblOyuncu1.Text = sayac1.ToString();
                }
                else
                {
                    sayac2 += 1;
                    lblOyuncu2.Text = sayac2.ToString();
                }
            }
        }

        void say()
        {                 
            tiklamasayisi++;
            if (tiklamasayisi==2)
            {
                tiklamasayisi = 0;
            }    
        }
        void tuslarikitle()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            say();
            if (tiklamasayisi==0)
            {
                button1.Text = karakterxo[0];
            }
            else
            {
                button1.Text = karakterxo[1];
            }
            button1.Enabled = false;
            kazanmadurumu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             say();
            if (tiklamasayisi == 0)
            {
                button2.Text = karakterxo[0];
            }
            else
            {
                button2.Text = karakterxo[1];
            }
            button2.Enabled = false;
            kazanmadurumu();
        }

        private void button3_Click(object sender, EventArgs e)
        {   
            say();
            if (tiklamasayisi == 0)
            {
                button3.Text = karakterxo[0];
            }
            else
            {
                button3.Text = karakterxo[1];
            }
            button3.Enabled = false;
            kazanmadurumu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            say();
            if (tiklamasayisi == 0)
            {
                button4.Text = karakterxo[0];
            }
            else
            {
                button4.Text = karakterxo[1];
            }
            button4.Enabled = false;
            kazanmadurumu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            say();
            if (tiklamasayisi == 0)
            {
                button5.Text = karakterxo[0];
            }
            else
            {
                button5.Text = karakterxo[1];
            }
            button5.Enabled = false;
            kazanmadurumu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            say();
            if (tiklamasayisi == 0)
            {
                button6.Text = karakterxo[0];
            }
            else
            {
                button6.Text = karakterxo[1];
            }
            button6.Enabled = false;
            kazanmadurumu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            say();
            if (tiklamasayisi == 0)
            {
                button7.Text = karakterxo[0];
            }
            else
            {
                button7.Text = karakterxo[1];
            }
            button7.Enabled = false;
            kazanmadurumu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            say();
            if (tiklamasayisi == 0)
            {
                button8.Text = karakterxo[0];
            }
            else
            {
                button8.Text = karakterxo[1];
            }
            button8.Enabled = false;
            kazanmadurumu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            say();
            if (tiklamasayisi == 0)
            {
                button9.Text = karakterxo[0];
            }
            else
            {
                button9.Text = karakterxo[1];
            }
            button9.Enabled = false;
            kazanmadurumu();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string takas1 = lblOyuncu1.Text, takas2 =lblOyuncu2.Text ;
            lblOyuncu1.Text = takas2;
            lblOyuncu2.Text = takas1;
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;

            tiklamasayisi = 0;
        }
    }
}