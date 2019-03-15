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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int x, y, str, str2,crp, gecici,r;
        string matris;
        int[,] a;
        int[,] agecici;
        void yazdir(int[,] a)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    textBox2.Text = textBox2.Text + " " + a[i, j].ToString();
                }
                textBox2.Text = textBox2.Text + "\r\n";
            }
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = textBox2.Enabled = false;
            groupBox1.Enabled = groupBox2.Enabled = button1.Enabled = false;  
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            if (comboBox4.SelectedItem != null && comboBox3.SelectedItem != null)
            {
                x = Convert.ToInt32(comboBox1.SelectedItem);
                y = Convert.ToInt32(comboBox2.SelectedItem);
                agecici = new int[x, y];
                str = Convert.ToInt32(comboBox3.SelectedItem);
                str2 = Convert.ToInt32(comboBox4.SelectedItem);
                if (str > x || str2 > x) MessageBox.Show("Girdiğiniz satır mevcut değil!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    for (int i = 0; i < x; i++)
                    {
                        for (int j = 0; j < y; j++)
                        {
                            agecici[i, j] = a[i, j];
                        }
                    }
                    for (int j = 0; j < y; j++)
                    {
                        gecici = agecici[(str - 1), j];
                        agecici[(str - 1), j] = agecici[(str2 - 1), j];
                        agecici[(str2 - 1), j] = gecici;
                    }
                    yazdir(agecici);
                }
            }
            else MessageBox.Show("Lütfen değiştirmek istediğiniz satır ve sütünu giriniz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            if (comboBox4.SelectedItem != null && comboBox3.SelectedItem != null)
            {
                x = Convert.ToInt32(comboBox1.SelectedItem);
                y = Convert.ToInt32(comboBox2.SelectedItem);
                agecici = new int[x, y];
                str = Convert.ToInt32(comboBox3.SelectedItem);
                str2 = Convert.ToInt32(comboBox4.SelectedItem);
                if (str > y || str2 > y) MessageBox.Show("Girdiğiniz sütun mevcut değil!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    for (int i = 0; i < x; i++)
                    {
                        for (int j = 0; j < y; j++)
                        {
                            agecici[i, j] = a[i, j];
                        }
                        gecici = agecici[i, str - 1];
                        agecici[i, (str - 1)] = agecici[i, (str2 - 1)];
                        agecici[i, (str2 - 1)] = gecici;
                    }
                    yazdir(agecici);
                }
            }
            else MessageBox.Show("Lütfen değiştirmek istediğiniz satır ve sütünu giriniz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            label8.Text = comboBox5.SelectedItem.ToString() + ". Satırı " + textBox4.Text + " İle Çarp";
            label9.Text = comboBox5.SelectedItem.ToString() + ". Sütunu " + textBox4.Text + " İle Çarp";
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedItem != null)
            {

                label8.Text = comboBox5.SelectedItem.ToString() + ". Satırı " + textBox4.Text + " İle Çarp";
                label9.Text = comboBox5.SelectedItem.ToString() + ". Sütunu " + textBox4.Text + " İle Çarp";
            }
            else
            {
                label8.Text = " . Satırı " + textBox4.Text + " İle Çarp";
                label9.Text = " . Sütunu " + textBox4.Text + " İle Çarp";  
            }
                
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            label8.Text = comboBox5.SelectedItem.ToString() + ". Satırı " + textBox4.Text + " İle Çarp";
            label9.Text = comboBox5.SelectedItem.ToString() + ". Sütunu " + textBox4.Text + " İle Çarp";           
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            if (comboBox5.SelectedItem != null)
            {
                x = Convert.ToInt32(comboBox1.SelectedItem);
                y = Convert.ToInt32(comboBox2.SelectedItem);
                crp = Convert.ToInt32(comboBox5.SelectedItem);
                agecici = new int[x, y];
                if (crp > x) MessageBox.Show("Girdiğiniz satır mevcut değil!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (Form1.IsNumeric(textBox4.Text) && textBox4.Text != "0")
                    {
                        r = Convert.ToInt32(textBox4.Text);
                        for (int i = 0; i < x; i++)
                        {
                            for (int j = 0; j < y; j++)
                            {
                                agecici[i, j] = a[i, j];

                            }

                        }
                        for (int j = 0; j < y; j++)
                        {
                            agecici[(crp - 1), j] *= r;
                        }
                        yazdir(agecici);
                    }
                    else MessageBox.Show("Geçerli bir sayı giriniz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Lütfen bir satır veya sütün giriniz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            if (comboBox5.SelectedItem != null)
            {
                x = Convert.ToInt32(comboBox1.SelectedItem);
                y = Convert.ToInt32(comboBox2.SelectedItem);
                crp = Convert.ToInt32(comboBox5.SelectedItem);
                agecici = new int[x, y];
                if (crp > y) MessageBox.Show("Girdiğiniz sütun mevcut değil!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (Form1.IsNumeric(textBox4.Text) && textBox4.Text != "0")
                    {
                        r = Convert.ToInt32(textBox4.Text);
                        for (int i = 0; i < x; i++)
                        {
                            for (int j = 0; j < y; j++)
                            {
                                agecici[i, j] = a[i, j];

                            }
                            agecici[i, (crp - 1)] *= r;
                        }
                        yazdir(agecici);
                    }
                    else MessageBox.Show("Geçerli bir sayı giriniz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Lütfen bir satır veya sütün giriniz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
       
        }

        

        private void sifirla_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); textBox2.Clear(); textBox4.Text=""; comboBox3.SelectedItem = ""; comboBox4.SelectedItem = ""; comboBox5.SelectedItem = "";
            groupBox1.Enabled = groupBox2.Enabled = false;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null) button1.Enabled = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null) button1.Enabled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); textBox2.Clear();
            x = Convert.ToInt32(comboBox1.SelectedItem);
            y = Convert.ToInt32(comboBox2.SelectedItem);
                a = new int[x, y];
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        do
                        {
                            matris = Interaction.InputBox((i + 1) + "x" + (j + 1) + ". elemanı giriniz..", "Matris");
                            if (matris.Length == 0) break;
                        } while (!Form1.IsNumeric(matris));
                        if (matris.Length == 0) break;
                        a[i, j] = Convert.ToInt32(matris);
                        textBox1.Text = textBox1.Text + " " + a[i, j].ToString();
                    }
                    if (matris.Length == 0) { textBox1.Clear(); break; }
                    textBox1.Text = textBox1.Text + "\r\n";
                }
                if (textBox1.TextLength > 0) { groupBox1.Enabled = groupBox2.Enabled = button1.Enabled = true;  }

            comboBox3.Items.Clear(); comboBox4.Items.Clear(); comboBox5.Items.Clear();
            if (x > y)
            {
                for (int i = 0; i < x; i++)
                {
                    comboBox3.Items.Add((i + 1));
                    comboBox4.Items.Add((i + 1));
                    comboBox5.Items.Add((i + 1));
                }
            }
            else
            {
                for (int i = 0; i < y; i++)
                {
                    comboBox3.Items.Add((i + 1));
                    comboBox4.Items.Add((i + 1));
                    comboBox5.Items.Add((i + 1));             
                }
            }
        }
    }
}
