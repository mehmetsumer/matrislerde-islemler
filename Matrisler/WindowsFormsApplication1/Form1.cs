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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x, y,det;
        int birim ,sıfır, skaler, kosegen, sim, ters, ust, alt;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null) button1.Enabled = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null) button1.Enabled = true;
        }

        string matris;
        int[,] a;
        //*****************************************************************************************
        public static double DeterminantHesap(int[,] a)
        {
            int boyut = Convert.ToInt32(Math.Sqrt(a.Length));
            int isaret = 1;
            double toplam = 0;
            if (boyut == 1) return a[0, 0];
            for (int k = 0; k < boyut; k++)
            {
                int[,] altMatris = new int[boyut - 1, boyut - 1];
                for (int i = 1; i < boyut; i++)
                {
                    for (int j = 0; j < boyut; j++)
                    {
                        if (j < k) altMatris[i - 1, j] = a[i, j];
                        else if (j > k) altMatris[i - 1, j - 1] = a[i, j];
                    }
                }
                if (k % 2 == 0)
                    isaret = 1;
                else
                    isaret = -1;
                toplam += isaret * a[0, k] * (DeterminantHesap(altMatris));
            }
            return toplam;
        }
        //*****************************************************************************************
        public static bool IsNumeric(string a)
        {
            int test;
            return int.TryParse(a, out test);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            satirm.Enabled = birimm.Enabled = sifirm.Enabled = kosegenm.Enabled = simm.Enabled = terssimm.Enabled = altm.Enabled = skalerm.Enabled = false;
            button1.Enabled = textBox1.Enabled = textBox2.Enabled = button2.Enabled = label5.Visible = label3.Visible = ustm.Enabled = false;
            karem.Enabled = sutunm.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null && textBox1.TextLength > 0)
            {
                textBox2.Clear();
                    for (int i = 0; i <y; i++)//transpozesi
                    {
                        for (int j = 0; j <x; j++)
                        {
                            textBox2.Text = textBox2.Text + " " + a[j, i].ToString();
                        }
                      textBox2.Text = textBox2.Text + "\r\n";
                    }
                if (x == 1) satirm.Enabled = true;
                if (y == 1) sutunm.Enabled = true;
                if (x >= 2 && y >= 2)
                {
                    if (x == y) karem.Enabled = true;
                    if (birim == 0) birimm.Enabled = true;
                    if (sıfır == 0) sifirm.Enabled = true;
                    if (x == y)
                    {
                        if (kosegen == 0) kosegenm.Enabled = true;
                        if (skaler == 0) skalerm.Enabled = true;
                        if (sim == 0) simm.Enabled = true;
                        if (ters == 0) terssimm.Enabled = true;
                        if (alt == 0) altm.Enabled = true;
                        if (ust == 0) ustm.Enabled = true;
                    }
                }
            }
            if (x == y)
            {
                if (x == 1) label5.Text = a[0, 0].ToString();
                else if (birim == 0) label5.Text = "1";
                else if (x == 2 && y == 2)
                {
                    det = a[0, 0] * a[1, 1] - a[0, 1] * a[1, 0];
                    label5.Text = det.ToString();
                }
                else if (x == 3 && y == 3)
                {
                    det = (a[0, 0] * a[1, 1] * a[2, 2] + a[1, 0] * a[2, 1] * a[0, 2] + a[2, 0] * a[0, 1] * a[1, 2]) - (a[2, 0] * a[1, 1] * a[0, 2] + a[0, 0] * a[2, 1] * a[1, 2] + a[1, 0] * a[0, 1] * a[2, 2]);
                    label5.Text = det.ToString();
                }
                else
                {
                    label5.Text = DeterminantHesap(a).ToString();
                }
                //label3.Visible = label5.Visible = true;
            }
            else label5.Text = "Yok"; 
            label3.Visible = label5.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Visible = label3.Visible = button2.Enabled = false;
            textBox1.Clear(); textBox2.Clear();
            satirm.Enabled = birimm.Enabled = sifirm.Enabled = kosegenm.Enabled = karem.Enabled = simm.Enabled = terssimm.Enabled = altm.Enabled = skalerm.Enabled = ustm.Enabled = sutunm.Enabled = false;
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
                            if (matris.Length == 0) break;
                        } while (!IsNumeric(matris));
                        if (matris.Length == 0) break;
                        a[i, j] = Convert.ToInt32(matris);
                        textBox1.Text = textBox1.Text + " " + a[i, j].ToString();
                    }
                    if (matris.Length == 0) { textBox1.Clear(); break; }
                    textBox1.Text = textBox1.Text + "\r\n";
                }
                if (textBox1.TextLength > 0) button2.Enabled = true;
            }
            birim = 0; sıfır = 0; skaler = 0; kosegen = 0; sim = 0; ters = 0; ust = 0; alt = 0;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (i != j) //köşegen matris
                    {
                        if (a[i, j] != 0)
                        {
                            kosegen++;
                            birim++;
                        }
                    }
                    if (i == j) //köşegen elemanları demek
                    {
                        if (a[i, j] != 1) birim++; //birim matris
                    }
                    if (a[i, j] != 0) sıfır++; //sıfır matris

                    if (i > j) //üstüçgensel matris
                    {
                        if (a[i, j] != 0) ust++;
                    }
                    if (i < j) //altüçgensel matris
                    {
                        if (a[i, j] != 0) alt++;
                    }
                }
            }

            if (x == y)
            {
                for (int i = 0; i < x; i++) //simetrik matris
                {
                    for (int j = 0; j < y; j++)
                    {
                        if (i != j) //köşegen olmayanlar
                        {
                            if (a[i, j] != a[j, i]) sim++;
                        }
                    }
                }
                for (int i = 0; i < x; i++) //ters simetrik matris
                {
                    for (int j = 0; j < y; j++)
                    {
                        if (i == j)
                        {
                            if (a[i, j] != 0) ters++;
                        }
                        if (i != j) //köşegen olmayanlar
                        {
                            if (a[i, j] != -a[j, i]) ters++;
                        }
                    }
                }
                for (int i = 0; i < x; i++)//skaler matris
                {
                    for (int j = 0; j < y; j++)
                    {
                        if (i == j)
                        {
                            if (a[i, j] != a[0, 0]) skaler++;
                        }
                        else if (i != j)
                        {
                            if (a[i, j] != 0) skaler++;
                        }
                    }
                }
            }

        }     
        }
    }

