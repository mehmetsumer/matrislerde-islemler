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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        int x, y; 
        string matris, matris2;
        double[,] a;
        double[] b;
        double[] dizi;

        private void Form5_Load(object sender, EventArgs e)
        {
            Color renk = this.BackColor;
            button1.Enabled = textBox1.Enabled = textBox2.Enabled = listBox1.Enabled = button2.Enabled = button3.Enabled=false;
            listBox1.BackColor = renk;
            comboBox2.Enabled = false;
        }

        void GaussJordan(double[,] matris, double[] deger, int boyut)
        {
            for (int i = 0; i < boyut; i++)
            {
                double geciciIlk = matris[i, i];
                for (int k = 0; k < boyut; k++)
                {
                    matris[i, k] /= geciciIlk;
                }
                deger[i] /= geciciIlk;


                for (int j = i + 1; j < boyut; j++)
                {
                    double carpim = matris[j, i] / matris[i, i];

                    for (int l = 0; l < boyut; l++)
                    {
                        matris[j, l] = matris[j, l] - (carpim * matris[i, l]);
                    }
                    deger[j] = deger[j] - (carpim * deger[i]);
                }
            }
            for (int i = boyut - 1; i > 0; i--)
            {

                for (int j = i - 1; j >= 0; j--)
                {
                    double carpim = matris[j, i] / matris[i, i];
                    for (int k = 0; k < x; k++)
                        matris[j, k] -= matris[i, k] * carpim;
                    deger[j] -= deger[i] * carpim;
                }
            }
            dizi = new double[boyut];
            
            for (int i = 0; i < boyut; i++)
                dizi[i]= deger[i];       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            GaussJordan(a, b, x);
            for (int i = 0; i < x; i++)
            {
                if(dizi[i].ToString()=="NaN") listBox1.Items.Add(("x(" + (i + 1) + ") = " + "Yok"));
                else listBox1.Items.Add(("x(" + (i + 1) + ") = " + dizi[i]));
            }
        }

        private void sifirla_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); textBox2.Clear(); listBox1.Items.Clear();
            button2.Enabled = button3.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            comboBox2.SelectedItem = comboBox1.SelectedItem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); textBox2.Clear(); listBox1.Items.Clear();
            button2.Enabled = button3.Enabled = false;
            x = Convert.ToInt32(comboBox1.SelectedItem);
            y = Convert.ToInt32(comboBox1.SelectedItem);
                if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null)
                {
                    a = new double[x, y];
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
                if(comboBox1.SelectedIndex!=-1 && textBox1.Text!="") button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            x = Convert.ToInt32(comboBox1.SelectedItem);
            if (comboBox2.SelectedItem != null)
            {
                b = new double[x];
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < 1; j++)
                    {
                        do
                        {
                            matris2 = Interaction.InputBox((i + 1) + "x" + (j + 1) + ". elemanı giriniz..", "Matris");
                            if (matris2.Length <= 0) { textBox2.Clear(); break; }
                        } while (!Form1.IsNumeric(matris2));
                        if (matris2.Length <= 0) { textBox2.Clear(); break; }
                        b[i] = Convert.ToDouble(matris2);
                        textBox2.Text = textBox2.Text + " " + b[i].ToString();
                    }
                    if (matris2.Length <= 0) { textBox2.Clear(); break; }
                    textBox2.Text = textBox2.Text + "\r\n";
                }
            }
            if (textBox2.Text != "") button3.Enabled = true;
        }
    }
}
