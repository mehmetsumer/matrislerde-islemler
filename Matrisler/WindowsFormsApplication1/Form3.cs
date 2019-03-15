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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        
        int[,] a;
        int[,] A1;
        int [] b;
        int x, y;
        double deta;
        string matris;
        double kok;
        void yenile()
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    A1[i, j] = a[i, j];
                }
            }
        }
        void temizle()
        {
            textBox1.Clear(); textBox2.Clear(); listBox1.Items.Clear();
            button2.Enabled = button3.Enabled = false;
        }
        public void Cramer(int[,] a, int[] b)
        {
            x = Convert.ToInt32(comboBox1.SelectedItem);
            y = Convert.ToInt32(comboBox2.SelectedItem);
            for (int k = 0; k < x; k++)
            {
                yenile();
                for (int i = 0; i < x; i++)
                {
                    A1[i, k] = b[i];
                }
                kok = Form1.DeterminantHesap(A1) / deta;
                listBox1.Items.Add("x(" + (k + 1) + ")= " + kok);
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            Color renk = this.BackColor;
            button4.Enabled = textBox1.Enabled = textBox2.Enabled = listBox1.Enabled = button2.Enabled = button3.Enabled = false;
            listBox1.BackColor = renk;
            comboBox2.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            temizle();
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
                if (comboBox1.SelectedIndex != -1 && textBox1.Text != "") button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
             x = Convert.ToInt32(comboBox1.SelectedItem);
             if (comboBox2.SelectedItem != null)
             {
                 b = new int[x];
                 for (int i = 0; i < x; i++)
                 {
                     for (int j = 0; j < 1; j++)
                     {
                         do
                         {
                             matris = Interaction.InputBox((i + 1) + "x" + (j + 1) + ". elemanı giriniz..", "Matris");
                             if (matris.Length <= 0) { textBox2.Clear(); break; }
                         } while (!Form1.IsNumeric(matris));
                         if (matris.Length <= 0) { textBox2.Clear(); break; }
                         b[i] = Convert.ToInt32(matris);
                         textBox2.Text = textBox2.Text + " " + b[i].ToString();
                     }
                     if (matris.Length <= 0) { textBox2.Clear(); break; }
                     textBox2.Text = textBox2.Text + "\r\n";
                 }
             }
             if (textBox2.Text != "") button3.Enabled = true;
        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Clear();
            A1 = new int[x, y];
            deta = Form1.DeterminantHesap(a);
            if (deta != 0)
            {
                 Cramer(a,b);
            }
            else
            {
                for(int i=0;i<y;i++)
                {
                    listBox1.Items.Add("x("+(i+1)+")= Hesaplanamıyor");
                }
            }

        }

        private void sifirla_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button4.Enabled = true;
            comboBox2.SelectedItem = comboBox1.SelectedItem;
        }
    }
}
