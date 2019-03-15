using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int x, y, x1, y1;
        string matris, matris2;
        int[,] a;
        int[,] b;
        int[,] c;
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            x = Convert.ToInt32(comboBox1.SelectedItem);
            y = Convert.ToInt32(comboBox2.SelectedItem);
            if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null)
            {
                a = new int[x, y];
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        do
                        {
                            matris = Interaction.InputBox((i + 1) + "x" + (j + 1) + ". elemanı giriniz..", "Matris");
                            if (matris.Length <= 0) break;
                        } while (!Form1.IsNumeric(matris));
                        if (matris.Length <= 0) break;
                        a[i, j] = Convert.ToInt32(matris);
                        textBox1.Text = textBox1.Text + " " + a[i, j].ToString();
                    }
                    if (matris.Length <= 0) { textBox1.Clear(); break; }
                    textBox1.Text = textBox1.Text + "\r\n";
                }
                if (textBox1.Text != "" && textBox2.Text != "") { cikar.Enabled = topla.Enabled = carp.Enabled = true; }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            x1 = Convert.ToInt32(comboBox3.SelectedItem);
            y1 = Convert.ToInt32(comboBox4.SelectedItem);
            if (comboBox3.SelectedItem != null && comboBox4.SelectedItem != null)
            {
                b = new int[x1, y1];
                for (int i = 0; i < x1; i++)
                {
                    for (int j = 0; j < y1; j++)
                    {
                        do
                        {
                            matris2 = Interaction.InputBox((i + 1) + "x" + (j + 1) + ". elemanı giriniz..", "Matris");
                            if (matris2.Length <= 0) break;
                        } while (!Form1.IsNumeric(matris2));
                        if (matris2.Length <= 0) break;
                        b[i, j] = Convert.ToInt32(matris2);
                        textBox2.Text = textBox2.Text + " " + b[i, j].ToString();
                    }
                    if (matris2.Length <= 0) break;
                    textBox2.Text = textBox2.Text + "\r\n";
                }
               if (textBox1.Text != "" && textBox2.Text != "") cikar.Enabled = topla.Enabled = carp.Enabled = true;
            }
        }
        string carpim;
        int sayi;
        private void carp_Click(object sender, EventArgs e)
        {
            if (textBox4.Visible)
            {
                textBox3.Clear();
                carpim = textBox4.Text;
                if (!Form1.IsNumeric(carpim) || textBox1.Text == "") MessageBox.Show("Hatalı Giriş!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    sayi = Convert.ToInt32(carpim);
                    for (int i = 0; i < x; i++)
                    {
                        for (int j = 0; j < y; j++)
                        {
                            a[i, j] = a[i, j] * sayi;
                            textBox3.Text += " " + a[i, j].ToString();
                        }
                        textBox3.Text += "\r\n";
                    }
                }


            }
            else
            {
                textBox3.Clear();
                if (textBox1.Text == "" || textBox2.Text == "") MessageBox.Show("Matris girişi yapınız!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    x = Convert.ToInt32(comboBox1.SelectedItem);
                    y = Convert.ToInt32(comboBox2.SelectedItem);
                    x1 = Convert.ToInt32(comboBox3.SelectedItem);
                    y1 = Convert.ToInt32(comboBox4.SelectedItem);
                    c = new int[x, y1];
                    if (y != x1) MessageBox.Show("Bu matrisler ile çarpma işlemi yapılamaz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        for (int k = 0; k < y; k++)
                        {
                            for (int i = 0; i < x; i++)
                            {
                                for (int j = 0; j < y1; j++)
                                {
                                    c[i, j] = c[i,j] +(a[i, k] * b[k, j]);

                                }
                            }
                        }

                        for (int i = 0; i < x; i++)
                        {
                            for (int j = 0; j < y1; j++)
                            {
                                textBox3.Text += " " + c[i, j].ToString();

                            }
                            textBox3.Text += "\r\n";
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Sayı İle Çarp")
            {
                button3.Text = "Matris İle İşlem Yap";
                topla.Visible = cikar.Visible = label8.Visible = label5.Visible = label5.Visible = label6.Visible = comboBox3.Visible = comboBox4.Visible = button2.Visible = false;
                textBox2.Visible = false; textBox4.Visible = true;
            }
            else if (button3.Text == "Matris İle İşlem Yap")
            {
                button3.Text = "Sayı İle Çarp";
                topla.Visible = cikar.Visible = label8.Visible = label5.Visible = label5.Visible = label6.Visible = comboBox3.Visible = comboBox4.Visible = button2.Visible = true;
                textBox2.Visible = true; textBox4.Visible = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1) button1.Enabled = true;
            else button1.Enabled = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1) button1.Enabled = true;
            else button1.Enabled = false;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex != -1) button2.Enabled = true;
            else button2.Enabled = false;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex != -1) button2.Enabled = true;
            else button2.Enabled = false;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (Form1.IsNumeric(textBox4.Text) && textBox1.Text!="") carp.Enabled = true;
            else carp.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Visible)
            {
                if (textBox1.Text!="" && Form1.IsNumeric(textBox4.Text))
                {              
                    carp.Enabled = true; 
                }
            }
        }

        private void sifirla_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear();
            cikar.Enabled = topla.Enabled = carp.Enabled = false;
        }
        

        private void topla_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Matris girişi yapınız!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (comboBox1.SelectedItem == comboBox3.SelectedItem && comboBox2.SelectedItem == comboBox4.SelectedItem)
                {
                    x = Convert.ToInt32(comboBox1.SelectedItem);
                    y = Convert.ToInt32(comboBox2.SelectedItem);
                    c = new int[x, y];
                    if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null && comboBox3.SelectedItem != null && comboBox4.SelectedItem != null)
                    {
                        for (int i = 0; i < x; i++)
                        {
                            for (int j = 0; j < y; j++)
                            {
                                c[i, j] = a[i, j] + b[i, j];
                                textBox3.Text = textBox3.Text + " " + c[i, j].ToString();
                            }
                            textBox3.Text = textBox3.Text + "\r\n";
                        }
                    }
                    else MessageBox.Show("Matris girişi yapınız!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Bu matrisler ile toplama işlemi yapılamaz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cikar_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Matris girişi yapınız!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (comboBox1.SelectedItem == comboBox3.SelectedItem && comboBox2.SelectedItem == comboBox4.SelectedItem)
                {
                    x = Convert.ToInt32(comboBox1.SelectedItem);
                    y = Convert.ToInt32(comboBox2.SelectedItem);
                    c = new int[x, y];
                    if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null && comboBox3.SelectedItem != null && comboBox4.SelectedItem != null)
                    {
                        for (int i = 0; i < x; i++)
                        {
                            for (int j = 0; j < y; j++)
                            {
                                c[i, j] = a[i, j] - b[i, j];
                                textBox3.Text = textBox3.Text + " " + c[i, j].ToString();
                            }
                            textBox3.Text = textBox3.Text + "\r\n";
                        }
                    }
                    else MessageBox.Show("Matris girişi yapınız!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Bu matrisler ile çıkarma işlemi yapılamaz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cikar.Enabled = topla.Enabled = carp.Enabled = button1.Enabled = button2.Enabled = false;
            textBox4.Visible = textBox1.Enabled = textBox2.Enabled = textBox3.Enabled = false;
        }
    }
}
